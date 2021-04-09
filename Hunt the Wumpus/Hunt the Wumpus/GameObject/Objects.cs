using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
   abstract class  Objects
    { 
        protected bool IsLive { get; set;}
        protected int X = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        protected int Y= new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        public bool CheckCoordinates(int x, int y)
        {
            if (x == X && y == Y)
                return true;
            else
                return false;
        }
        
           


    }
}
