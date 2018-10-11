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
       // private readonly Path _path;
        private const int _range = 1;
        private const int _factor = 1;
        private const double _accuracy = 0.75;
        private static Random _random = new Random();

        public bool IsSuccessfulShot
        {
            get
            {
                return _random.NextDouble() < _accuracy;
            }
        }

        public Tower( MapLocation location, Path path)
        {
            // Create Tower Object only if its not on the Path
            if (path.OnPath(location))
                _location = location;
            else
            throw new Exception("Tower in location "+ location.X + "," + location.Y + " is on Path of Invaders");
                  
        }

        // If Invader is in range of Tower and not Nuetralized yet, then fire

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot)
                    {
                        invader.DecreaseHealth(_factor);
                        Console.WriteLine("Shot At and Hit an invader");
                        if(invader.IsNuetralized)
                        {
                            Console.WriteLine("Invader is nuetralized");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an Invader");
                    }
                    break; // To make sure it breaks out after hitting one invader  
                }

            }

        }
    }
}
