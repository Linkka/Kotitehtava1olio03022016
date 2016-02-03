using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava1olio03022016
{
    class Dice
    {
        private Random rand = new Random();
        public int Throw()
        { 
            return rand.Next(6) + 1;
        }


    }
}
