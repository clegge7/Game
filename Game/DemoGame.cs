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
        Sprite2D sprite;
        Map2D map;

        string[,] mapinfo =
        {
            {"pl","pl","pl","pl","pl","pl","pl","pl","pl","pl","pl","fo",".",".","." },
            {"fo","fo","pl","pl","pl","pl","pl","pl","pl","pl","pl","fo",".",".","." },
            {"pl","pl","pl","pl","pl","pl","pl","pl","pl","pl","pl","ft",".","ga","." },
            {"pl","pl","pl","pl","pl","sa","pl","pl","pl","pl","pl","pl","pl","pl","pl" },
            {"pl","pl","fo","pl","pl","sa","sa","pl","pl","pl","pl","pl","pl","pl", "pl"},
            {"pl","pl","fo","pl","pl","cl","cl","pl","pl","pl","pl","pl","pl","pl", "pl"},
            {"pl","pl","pl","pl","pl","pl","pl","pl","ar","pl","pl","pl","pl","pl", "pl"},
            {"pl","pl","pl","pl","fo","pl","hi","pl","cl","pl","fo","pl","pl","pl", "pl"},
            {"pl","pl","pl","pl","pl","pl","pl","fo","pl","cl","pl","pl","pl","pl", "pl"},
            {"pl","pl","pl","pl","fo","pl","pl","pl","fo","pl","fo","pl","pl","pl", "pl"}
        };
        public DemoGame() : base(new Engine.Vector2(615,515), "Game Demo") { }

        public override void OnLoad()
        {
            BackgroundColor = Color.Black;

            //player = new Shape2D(new Vector2(10,10), new Vector2(10,10), "Test");
            sprite = new Sprite2D(new Vector2(24, 24), new Vector2(24, 24), "adventurer-attack1-00", "Player");
            map = new Map2D(new Vector2(240, 160), mapinfo, "test", "test");
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
