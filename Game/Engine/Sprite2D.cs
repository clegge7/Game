using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game.Engine
{
    public class Sprite2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Directory = "";
        public string Tag = "";
        public Image Sprite = null;

        public Sprite2D(Vector2 Position, Vector2 Scale, string Directory, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Directory = Directory;
            this.Tag = Tag;

            Image tmp = Image.FromFile($"assets/sprites/{Directory}.png");
            Bitmap sprite = new Bitmap(tmp, (int)Scale.X, (int)Scale.Y);
            Sprite = sprite;

            Log.Info($"[SPRITE2D]({Tag}) - Has been registered");
            Engine.RegisterSprite(this); 
        }

        public void DestroySelf()
        {
            Engine.UnregisterSprite(this);
        }
    }
}
