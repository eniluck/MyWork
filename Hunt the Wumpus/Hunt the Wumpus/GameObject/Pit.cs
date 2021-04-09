using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Pit : Objects, GetCoordinates
    {
        public Pit()
        {
            X = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
            Y = new Random(Guid.NewGuid().GetHashCode()).Next(1,6);
        }
        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
        public bool CoompareCodinates(Player player,Pit pit)
        {
            if (pit.GetX() == player.GetX() - 1 && pit.GetY() == player.GetY() || pit.GetX() == player.GetX() && pit.GetY() == player.GetY() - 1 || pit.GetX() == player.GetX() + 1 && pit.GetY() == player.GetY() || pit.GetX() == player.GetX() && pit.GetY() == player.GetY() + 1)
                return true;
            else
                return false;
        }
        public void Voice()
        {
            Console.WriteLine("Сквозняк");
        }
    }
}
