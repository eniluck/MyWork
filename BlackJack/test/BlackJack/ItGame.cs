using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ItGame
    {
        private static int _playerNextCard=0;
        private static int _dillerNextCard=0;
        public static void Game()
        {
            PlayerMove();
            DillerMove();
            SearchVinner();
            Diller.NewRandom();
            Player.NewRandom();
        }
        public static void PlayerMove()
        {
            Player player = new Player();
            Console.WriteLine("У вас в руке:\n" + "1)" + (Cards)Player.CardOne() + "\n2)" + (Cards)Player.CardTwo() + "\nВ сумме: " + Player.Summ(_playerNextCard));
            string read = "";
            while (read != "нет")
            {
                switch (read)
                {
                    case "да":
                        {
                            _playerNextCard = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
                            Console.WriteLine("Вы взяли " + (Cards)_playerNextCard);
                            Console.WriteLine("В сумме: " + Player.Summ(_playerNextCard));
                            Console.WriteLine("Хотите взять еще карту да/нет");
                            read = Console.ReadLine().ToLower();
                            break;
                        }
                    case "нет":
                        {
                            Console.WriteLine("У вас в сумме: " + Player.Summ());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Хотите взять еще карту да/нет");
                            read = Console.ReadLine().ToLower();
                            break;
                        }
                }
                if (Player.Summ() > 21)
                {
                    Console.WriteLine("У вас" + Player.Summ() + "\n Вы проиграли");
                    break;
                }
            }
        }
        public static void DillerMove()
        {
            while (Diller.Summ(_dillerNextCard) < 17)
            {
                _dillerNextCard = new Random(Guid.NewGuid().GetHashCode()).Next(1, 11);
                Diller.Summ(_dillerNextCard) ;
            }
        }
        public static void SearchVinner()
        {
            if (Diller.Summ(_dillerNextCard) > 21 || Player.Summ() == 21 && Diller.Summ(_dillerNextCard) != 21 || Player.Summ() > Diller.Summ(_dillerNextCard) && Player.Summ() < 21)
            {
                Console.WriteLine("У вас " + Player.Summ(_playerNextCard));
                Console.WriteLine("У диллера: " + Diller.Summ(_dillerNextCard));
                Console.WriteLine("Вы выйграли!!");
                return;
            }

            else if (Player.Summ() < Diller.Summ() && Player.Summ() < 22)
            {
                Console.WriteLine("У диллера: " + Diller.Summ(_dillerNextCard));
                Console.WriteLine("У вас: " + Player.Summ());
                Console.WriteLine("Вы проиграли");
            }
            else if (Diller.Summ() == Player.Summ())
            {
                Console.WriteLine("У диллера: " + Diller.Summ());
                Console.WriteLine("У вас: " + Player.Summ());
                Console.WriteLine("Ничья");
            }
        }
    }
}