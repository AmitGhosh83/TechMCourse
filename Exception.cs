using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    public class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }
        public TowerDefenseException(string v) : base(v)
        {
            
        }
    }

    public class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string v): base(v)
        {
        }
    }
}

