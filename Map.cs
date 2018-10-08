using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map( int height, int width)
        {
            Height = height;
            Width = width;
        }

        public bool OnMap(Point point)
        {
            return point.X < Width && point.X >= 0 && point.Y < Height && point.X >= 0;
        }
    }
}
