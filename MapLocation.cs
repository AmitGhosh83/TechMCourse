using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class MapLocation : Point
    {
        public MapLocation( int x, int y, Map map ) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + " , " + y + " is outside the map");
            }
         
        }

        // to check if Tower and Invader are Within Range
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
