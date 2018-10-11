using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Invader
    {
        private readonly Path _path;

        private int _pathStep = 0;
        
        // Computing Invader location based on pathStep
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; set; } = 2;

        // Checking to see if the Invader has reached the end of the path
        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length;
            }
        }

        // Checking to see if Health is remaining
        public bool IsNuetralized => Health <= 0;

        // Checking to see if invader has health left and not reached the end of the path
        public bool IsActive
        {
            get
            {
                return !(IsNuetralized || HasScored);
            }
        }


        public Invader( Path path)
        {
            _path = path;
        }

        //Move the Invader forward by 1 step
        public void Move()
        {
            _pathStep = _pathStep + 1;
        }

        // Decrease Invader Health upon being hit
        public int DecreaseHealth( int factor)
        {
            return Health -= factor;
        }

   
    }
} 
