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
        private const int range = 1;
        private const int factor = 1;

        public Tower( MapLocation location, Path path)
        {
            //if (path.OnPath(location))
                _location = location;
            //else
            //    throw new Exception(location.X + "," + location.Y + "is on path");
                  
        }

        // If Invader is in range of Tower and not Nuetralized yet, then fire

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if(_location.InRangeOf(invader.Location, range)&& invader.IsActive)
                {
                    invader.DecreaseHealth(factor);
                    break; // To make sure it breaks out after hitting one invader
                }
                
            }
        }
    }
}
