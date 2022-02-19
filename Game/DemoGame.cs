using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine;
using System.Drawing;

namespace Game
{
    class DemoGame : Engine.Engine
    {
        //Shape2D player;
        //Sprite2D sprite;
        string[,] Map =
        {
            {".",".",".",".",".","." },
            {".",".",".",".","g","." },
            {".",".",".","g","g","." },
            {".",".","g","g","g","." },
            {"g","g","g","g","g","g" },
            {".",".",".",".",".","." }
        };
        public DemoGame() : base(new Engine.Vector2(615,515), "Game Demo") { }

        public override void OnLoad()
        {
            BackgroundColor = Color.Black;

            //player = new Shape2D(new Vector2(10,10), new Vector2(10,10), "Test");
            //sprite = new Sprite2D(new Vector2(10, 20), new Vector2(100, 100), "adventurer-attack1-00", "Player");

            //making map
            //for(int i = 0; i< Map.GetLength(0); i++)
            //{
            //    for(int j = 0; j < Map.GetLength(1); j++)
            //    {
            //        if(Map[i,j] == "g")
            //        {
            //            new Sprite2D(new Vector2(i*100, j*100), new Vector2(20, 20), "adventurer-attack1-00", "Player");
            //        }
            //    }
            //}
        }
        public override void OnDraw()
        {
            //Console.WriteLine("Yay ondraw works");
        }
        public override void OnUpdate()
        {
            //if(time > 400)
            //{
            //    player.DestroySelf();
            //}
            //time++;
            //player.Position.X += x;
            //player.Scale.X += x;

            //sprite.Position.X += x;
        }
    }
}
