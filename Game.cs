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
            Map map = new Map(5,8);
            try
            {
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

                Tower tower = new Tower(new MapLocation(3,2,map), p);
                
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
