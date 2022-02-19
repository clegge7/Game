using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game.Engine
{
    public class Map2D
    {
        public Vector2 Scale = null;
        public string Directory = "";
        public string Tag = "";
        public Image MapImage = null;
        public string[,] Map = null;
        
        public Map2D()
        {
            this.Scale = null;
            this.Directory = null;
            this.Tag = null;
            this.MapImage = null;
            this.Map = null;
        }
        public Map2D(Vector2 Scale, string[,] Map, string Directory, string Tag)
        {
            this.Scale = null;
            this.Map = Map;
            this.Directory = Directory;
            this.Tag = Tag;

            Image tmp = Image.FromFile($"assets/maps/{Directory}.png");
            Bitmap mapImage = new Bitmap(tmp, (int)Scale.X, (int)Scale.Y);
            MapImage = mapImage;

            Log.Info($"[MAP2D]({Tag}) - Has been loaded");
            Engine.RegisterMap(this);
        }

        public void DestroySelf()
        {
            Engine.UnregisterMap(this);
        }
    }
}
