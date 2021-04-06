using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Game : Object
    {
        Player player = new Player();
        Map map = new Map(6);
        public string PrintPlayer()
        {
            for (int x = 0; x < player._coordinatesX; x++)
            {
                for (int y = 0; y < player._coordinatesY; y++)
                {
                    map.end += "@";
                }
                
            }
            return map.end;
        }
    }
}
