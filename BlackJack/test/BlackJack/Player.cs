using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   class Player
    {
        public static int CardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        public static int CardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
        public static int Summ = CardOne + CardTwo;

        public static void Cards()
        {
            CardOne = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            CardTwo = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
            Summ = CardOne + CardTwo;
            Console.WriteLine("У вас в руке:\n" + "1)" + (Cards)CardOne + "\n2)" + (Cards)CardTwo +"\nВ сумме: " + Summ);
            string read = "";
            int playerCardNext;
            while (read != "нет")
            {
                
                switch (read)
                {
                    case "да":
                        {
                            playerCardNext = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
                            Console.WriteLine("Вы взяли " + (Cards)playerCardNext);
                            Summ += playerCardNext;
                            Console.WriteLine("В сумме: " + Summ);
                            Console.WriteLine("Хотите взять еще карту да/нет");
                            read = Console.ReadLine().ToLower();
                            break;
                        }
                    case "нет":
                        {
                            Console.WriteLine("У вас в сумме: " + Summ);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Хотите взять еще карту да/нет");
                            read = Console.ReadLine().ToLower();
                            break;
                        }
                        
                }
                if (Summ > 21)
                {
                    Console.WriteLine("У вас" + Summ + "\n Вы проиграли");
                    break;
                }
            }
        }
    }
}
