using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
        Random random = new Random();

        public bool IsSuccessfulShot(Tower[] towers)
        {
            return random.NextDouble() < 0.75;
        }

        // True if player wins and False if player looses
        public bool Play()
        {
            // Run until all Invaders are nuetralized or an invader reaches the end of path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)   
            {
                //Each Tower has oppurtunity to fire on Invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //Count and Move the invaders that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive) // invader whose health is not 0 and not reached end of the path
                    {
                        invader.Move();     // move active invaders by 1 step                  
                            if (invader.HasScored) // check if invader has reached end of path
                            {
                                  return false; // player lost
                            }                                     
                        remainingInvaders += 1; // increment the remaining invader count by 1 and move to check the next invader status
                    }
                        
                }

            }
            return true; // Player won, all invaders nuetralized
        }
    }
}
