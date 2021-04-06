using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Map: Objects
    {
        public  string end = "";
        private int[,] _coordinates=new int[Size, Size];
        public static int Size;
        public Map(int size)
        {
            Size = size;
        }
        
        public string Generait()
        {
            
  
            for (int x=0; x<Size;x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    end += "[]";
                }
                end+="\n";
            }
            return end;
        }
        
        
    }
}
/*
   Y
 5  |[1,5][][][][]
 4  |[1,4][][][][]
 3  |[1,3][][][][]
 2  |[1,2][][][][]
 1  |___________X
   0 1 2 3 4 5
 */