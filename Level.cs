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
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if(invader.HasScored)
                            {
                                return false;
                            }
                        remainingInvaders += 1;
                    }
                        
                }

            }
            return true;

        }
    }
}
