using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Game.Engine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }
    public abstract class Engine
    {
        private Vector2 ScreenSize = new Vector2(512, 512);
        private string Title = "Game";
        private Canvas Window = null;
        private Thread GameLoopThread = null;
        private static List<Shape2D> AllShapes = new List<Shape2D>();
        private static List<Sprite2D> AllSprites = new List<Sprite2D>();

        public Color BackgroundColor = Color.Beige;

        public Engine(Vector2 ScreenSize, string Title)
        {
            Log.Info("Game is Starting");
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            Window = new Canvas();
            Window.Size = new Size((int)ScreenSize.X, (int)ScreenSize.Y);
            Window.Text = this.Title;
            Window.Paint += Renderer;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        public static void RegisterShape(Shape2D shape)
        {
            AllShapes.Add(shape);
        }
        public static void RegisterSprite(Sprite2D sprite)
        {
            AllSprites.Add(sprite);
        }

        public static void UnregisterShape(Shape2D shape)
        {
            if (AllShapes.Contains(shape))
            {
                AllShapes.Remove(shape);
                Log.Info($"[SHAPE2D]({shape.Tag}) - Has been destroyed");
            };
            
        }
        public static void UnregisterSprite(Sprite2D sprite)
        {
            if (AllSprites.Contains(sprite))
            {
                AllSprites.Remove(sprite);
                Log.Info($"[SPRITE2D]({sprite.Tag}) - Has been destroyed");
            };

        }
        void GameLoop()
        {
            OnLoad();
            bool GameStarting = true;
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    OnDraw();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(1);
                    GameStarting = false;
                }
                catch
                {
                    if (GameStarting)
                    {
                        Log.Info("Game is loading...");
                        Thread.Sleep(10);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(BackgroundColor);

            foreach(Shape2D shape in AllShapes)
            {
                g.FillRectangle(new SolidBrush(Color.Red), shape.Position.X, shape.Position.Y, shape.Scale.X, shape.Position.Y);
            }
            foreach(Sprite2D sprite in AllSprites)
            {
                g.DrawImage(sprite.Sprite, sprite.Position.X, sprite.Position.Y, sprite.Scale.X, sprite.Scale.Y);
            }
        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();
    }
}
