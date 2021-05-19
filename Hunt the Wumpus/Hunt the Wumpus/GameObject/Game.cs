using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Game : Objects
    {
        private const ConsoleKey Fire = ConsoleKey.Spacebar;
        private const ConsoleKey MoveUp = ConsoleKey.W;
        private const ConsoleKey MoveDown = ConsoleKey.S;
        private const ConsoleKey MoveLeft = ConsoleKey.A;
        private const ConsoleKey MoveRight = ConsoleKey.D;
        Wumpus wumpus = new Wumpus();
        Map map = new Map(6);
        Bat batOne = new Bat();
        Bat batTwo = new Bat();
        Player player = new Player();
        Pit pit = new Pit();

        private string GeneraitObject()
        {
            string end = "";
            for (int x = 0; x < map.GetSize(); x++)
            {
                for (int y = 0; y < map.GetSize(); y++)
                {
                    if (player.CheckCoordinates(x, y))
                        end += "[@]";
                    else if (pit.CheckCoordinates(x, y))
                        end += "[O]";
                    else if (wumpus.CheckCoordinates(x, y))
                        end += "[W]";
                    else if (batOne.CheckCoordinates(x, y))
                        end += "[B]";
                    else if (batTwo.CheckCoordinates(x, y))
                        end += "[B]";
                    else
                        end += "[ ]";
                }
                end += "\n";
            }
            return end;
        }
        private string GeneraitForPlayer()
        {

            string end = "";
            for (int x = 0; x < map.GetSize(); x++)
            {
                for (int y = 0; y < map.GetSize(); y++)
                {
                    if (player.CheckCoordinates(x, y))
                        end += "[@]";
                    else
                        end += "[ ]";
                }
                end += "\n";
            }
            return end;
        }
        public void Start()
        {
            GeneraitObject();
            Console.WriteLine(GeneraitForPlayer());
            while (!player.IsDide(wumpus, pit, player) || !wumpus.GetLive())
            {
                ConsoleKeyInfo UserInput = Console.ReadKey(true);
                Console.Clear();
                if (UserInput.Key == Fire)
                {
                    Console.WriteLine(GeneraitForPlayer());
                    GeneraitObject();
                    ShootInWumpus(player, wumpus);
                }
                else
                    player.Move(UserInput);
                if (player.CheckScope(map, player))
                {
                    player.MoveBack(UserInput);
                    Console.WriteLine(GeneraitForPlayer());

                    Console.WriteLine("Нельзя выходить за границы");
                }
                else
                {
                    player.StepOnBat(player, batOne, batTwo);
                    GeneraitObject();
                    Console.WriteLine(GeneraitForPlayer());
                    player.Feeling(wumpus, pit, batOne, player);
                }
                if (player.IsDide(wumpus, pit, player))
                {
                    Console.WriteLine(GeneraitObject());
                    Console.WriteLine("RIP");
                }
                if (!wumpus.GetLive())
                {
                    Console.Clear();
                  Console.WriteLine(GeneraitObject());
                    Console.WriteLine("Вы выйграли");
                }
            }
        }
        public void ShootInWumpus(Player player, Wumpus wumpus)
        {
            Console.WriteLine("В какую стопону стрелять");
            ConsoleKeyInfo input = Console.ReadKey(true);
            int shootX = player.GetX();
            int shootY = player.GetY();
            switch (input.Key)
            {
                case MoveDown:
                    {
                        shootX += 1;
                        break;
                    }
                case MoveUp:
                    {
                        shootX -= 1;
                        break;
                    }
                case MoveLeft:
                    {
                        shootY -= 1;
                        break;
                    }
                case MoveRight:
                    {
                        shootY += 1;
                        break;
                    }
            }
            if (IsHit(wumpus, shootX, shootY))
            {
                wumpus.Died();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы промахнулись");
            }
        }
        private bool IsHit(Wumpus wumpus,int shootX,int shootY)
        {
            if (wumpus.GetX() == shootX && wumpus.GetY() == shootY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
