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
        public int Length => _path.Length;

        public MapLocation GetLocationAt( int pathstep)
        {
           return (pathstep < _path.Length) ? _path[pathstep] : null;
        }

        /*public bool OnPath( MapLocation loc)
        {
            foreach (MapLocation onPath in _path)
            {
                if (onPath.X != loc.X && onPath.Y != loc.Y)
                    return true;
            }
            

        }*/
    }
}
