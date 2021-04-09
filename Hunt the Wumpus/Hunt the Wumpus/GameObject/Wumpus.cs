using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Wumpus : Objects, GetCoordinates
    {
        public Wumpus()
        {
            IsLive = true;
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
        public void Voice()
        {
            Console.WriteLine("Запах");
        }
        public bool CompareCordinates(Player player,Wumpus wumpus)
        {
            if (wumpus.GetX() == player.GetX() - 1 && wumpus.GetY() == player.GetY() || wumpus.GetX() == player.GetX() && wumpus.GetY() == player.GetY() - 1 || wumpus.GetX() == player.GetX() + 1 && wumpus.GetY() == player.GetY() || wumpus.GetX() == player.GetX() && wumpus.GetY() == player.GetY() + 1)
                return true;
            return
                false;
        }
        public void Died()
        {
            IsLive = false;
        }
        public bool GetLive()
        {
            return IsLive;
        }

    }
}
