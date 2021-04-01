using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ItGame
    {
        public static void Game()
        {
            Player.Cards();

            Diller.Cards();
            if (Diller.Summ > 21 || Player.Summ == 21 && Diller.Summ!=21 ||Player.Summ>Diller.Summ && Player.Summ<21 )
            {
                Console.WriteLine("У вас " + Player.Summ);
                Console.WriteLine("У диллера: " + Diller.Summ);
                Console.WriteLine("Вы выйграли!!");
                return;
            }

            else if(Player.Summ < Diller.Summ && Player.Summ<22)
            {
                Console.WriteLine("У диллера: " + Diller.Summ);
                Console.WriteLine("У вас: " + Player.Summ);
                Console.WriteLine("Вы проиграли");
            }
            else if(Diller.Summ == Player.Summ)
            {
                Console.WriteLine("У диллера: " + Diller.Summ);
                Console.WriteLine("У вас: " + Player.Summ);
                Console.WriteLine("Ничья");
            }
        }
    }
}