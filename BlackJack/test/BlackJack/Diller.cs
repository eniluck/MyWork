using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Diller
    {
        private static int _cardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
       private static int _cardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        private static  int _summ = _cardOne + _cardTwo;
        public static int CardOne()
        {
            return _cardOne;
        }
        public static int CardTwo()
        {
            return CardTwo();
        }
        public static int Summ()
        {
            return _summ;
        }
        public static int Summ(int nextCard)
        {
            _summ = _cardOne + _cardTwo + nextCard;
            return _summ;
        }
        public static void NewRandom()
        {
            _cardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            _cardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            _summ = _cardOne + _cardTwo;
        }
    }

}
