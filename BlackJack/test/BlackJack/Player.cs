using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Player
    {
        private static int _cardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        private static int _cardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        private static int _sum = _cardOne + _cardTwo;
        public static int CardOne()
        {
            return _cardOne;
        }
        public static int CardTwo()
        {
            return _cardTwo;
        }
        public static int Summ(int nextCard)
        {
            _sum += nextCard;
            return _sum;
        }
        public static int Summ()
        {
            return _sum;
        }
        public static void NewRandom()
        {
            _cardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            _cardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            _sum = _cardOne + _cardTwo;
        }
    
    }
}