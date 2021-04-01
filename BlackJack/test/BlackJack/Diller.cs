using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Diller
    {
        static public int CardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        static public int CardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        public static  int Summ = CardOne + CardTwo;
        public  static void Cards()
        {
            CardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            CardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            Summ = CardOne + CardTwo;
            while (Summ < 17)
            {
                int DillerCardNext = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
                Summ += DillerCardNext;
                
            }
        }   
    }
}
