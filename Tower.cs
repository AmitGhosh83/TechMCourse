using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Tower
    {
        private readonly MapLocation _location;
        private readonly Path _path;

        public Tower( MapLocation location, Path path)
        {
            //if (path.OnPath(location))
                _location = location;
            //else
            //    throw new Exception(location.X + "," + location.Y + "is on path");
                  
        }
    }
}
