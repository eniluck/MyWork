using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Map: Objects, GetCoordinates
    {
        private string _map="";
       private int _size;
        public Map(int size)
        {
            _size = size;
        }
        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
        public int GetSize()
        {
            return _size;
        }
       public string PrintMap()
        {

            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {

                    _map += "[ ]";
                }
                _map += "\n";
            }
            return _map;
        }
    }
}
