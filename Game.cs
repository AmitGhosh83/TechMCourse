using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            // Create the map object where the game will be played
            Map map = new Map(5,8);
            try
            {
               // Create the path in which the invaders would come down to attack
               Path p = new Path(
                    new[] 
                    {
                        new MapLocation(0,2,map),
                        new MapLocation(1,2,map),
                        new MapLocation(2,2,map),
                        new MapLocation(3,2,map),
                        new MapLocation(4,2,map),
                        new MapLocation(5,2,map),
                        new MapLocation(6,2,map),
                        new MapLocation(7,2,map),

                    }
                    );
                // Create an array of Invaders
                Invader[] invaders =
                    
                    {
                        new Invader(p),
                        new Invader(p),
                        new Invader(p),
                        new Invader(p),
                    };

                //Create an array of Towers who would be firing on the invaders
                Tower[] towers =
                    {
                        new Tower(new MapLocation(1,3,map), p),
                        new Tower(new MapLocation(1,3,map), p),
                        new Tower(new MapLocation(1,3,map), p),
                    };

                // Play the Game

                Level level = new Level(invaders); // passing the invader array to Level
                level.Towers = towers;             // assigning the towers to the level object

                bool result =level.Play();        // Play the game and see who own, Player wins if all attackers are nuetralized, 
                                                  //loses otherwise
                Console.WriteLine();
                Console.WriteLine("Player {0}", result ? "won" : "lost");
            }
            

            
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefense Exception");
            }
            catch(System.Exception ex)
            {
                Console.WriteLine("Unhandled Exception "+ ex.Message);
            }
                       
            Console.ReadKey();
        }
    }
}
