using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Path
    {
        public MapLocation[] _path;
        public Path( MapLocation[] path)
        {
            _path = path;
        }

        // Public property to return Length of the Path class
        public int Length => _path.Length;

        //Method to verify where on the path a invader is
        public MapLocation GetLocationAt( int pathstep)
        {
           return (pathstep < _path.Length) ? _path[pathstep] : null;
        }

        // Check to see that a Tower cant be placed on a Path
        public bool OnPath( MapLocation loc)
        {
            foreach (MapLocation onPath in _path)
            {
                if (onPath.X != loc.X && onPath.Y != loc.Y)
                    return true;
            }
            
           return false;
        }
    }
}
