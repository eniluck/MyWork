using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Player : Objects
    {
        //public int startX = new Random(Guid.NewGuid().GetHashCode()).Next(1,);
        //public int startY = new Random(Guid.NewGuid().GetHashCode()).Next(1, Map.Size);

        //public string Name { get; set; }
        private int _arrow=5;
        public int _coordinatesX = new Random(Guid.NewGuid().GetHashCode()).Next(1, Map.Size);
        public int _coordinatesY = new Random(Guid.NewGuid().GetHashCode()).Next(1, Map.Size);
    }
}
