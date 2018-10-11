using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Distance between a given point (x,y coordinates) and the Point (X,Y) called on
        public int DistanceTo(int x, int y)
        {
            return (int) Math.Sqrt(Math.Pow(X-x,2)+Math.Pow(Y-y,2));
        }

        // Distance between 2 given points
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
