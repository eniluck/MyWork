using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Player : Objects, GetCoordinates
    {
        private const ConsoleKey Fire = ConsoleKey.Spacebar;
        private const ConsoleKey MoveUp = ConsoleKey.W;
        private const ConsoleKey MoveDown = ConsoleKey.S;
        private const ConsoleKey MoveLeft = ConsoleKey.A;
        private const ConsoleKey MoveRight = ConsoleKey.D;
        public Player()
        {
            X = 3;
            Y = 2;
        }
        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
        public bool CheckScope(Map map,Player player)
        {
            if (map.GetSize() - 1 < player.GetX() || player.GetX() < 0 || map.GetSize() - 1 < player.GetY() || player.GetY() < 0)
            {
                return true;
            }
            else
               
                return false;

        }
        public void Move(ConsoleKeyInfo input)
        {

            {
                switch (input.Key)
                {
                    case MoveDown:
                        {
                            X += 1;
                            break;
                        }
                    case MoveUp:
                        {
                            X -= 1;
                            break;
                        }
                    case MoveLeft:
                        {
                            Y -= 1;
                            break;
                        }
                    case MoveRight:
                        {
                            Y += 1;
                            break;
                        }
                    case Fire:
                        {
                           
                            break;
                        }
                }
            }
        }
        public void MoveBack(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case MoveDown:
                    {

                        X -= 1;
                        break;
                    }
                case MoveUp:
                    {
                        X += 1;
                        break;
                    }
                case MoveLeft:
                    {
                        Y += 1;
                        break;
                    }
                case MoveRight:
                    {
                        Y -= 1;
                        break;
                    }
                case Fire:
                    {
                        
                        break;
                    }
            }
        }
        public void Feeling(Wumpus wumpus,Pit pit,Bat bat,Player player)
        {
            if (wumpus.CompareCordinates(player,wumpus))
                wumpus.Voice();
            if (pit.CoompareCodinates(player,pit))
                pit.Voice();
            if (bat.CompareCodinates(player,bat))
                bat.Voice();
        }
        public bool IsDide(Wumpus wumpus, Pit pit, Player player)
        {
            if (wumpus.GetX() == player.GetX() && wumpus.GetY()==player.GetY())
                return true;
            if (pit.GetX() == player.GetX() && pit.GetY() ==player.GetY() )
                return true;
            return false;
        }
        public void StepOnBat(Player player,Bat batOne,Bat batTwo)
        {
            if(player.GetX()==batOne.GetX() && player.GetY()==batOne.GetY() && batOne.GetLive())
            {
                X=new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
                Y = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
                batOne.Died();
            }
            if (player.GetX() == batTwo.GetX() && player.GetY() == batTwo.GetY() && batTwo.GetLive())
            {
                X = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
                Y = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
                batTwo.Died();
            }
        }
        
        }
    }


              
           
