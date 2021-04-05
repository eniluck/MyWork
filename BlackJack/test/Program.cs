using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {   
            while(true)
            {
                string read = "";
                ItGame.Game();
                Console.WriteLine("Играем дальше?");
                read = Console.ReadLine();
                if (read == "нет")
                    break;
            }
                
        }
    }
}
public enum Cards
{
    one = 1,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    ten,
    will = 10,
    lady = 10,
    ace = 11,
}







