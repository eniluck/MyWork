using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus.GameObject
{
    class Bat : Objects,GetCoordinates
    {
        public Bat()
        {
            X = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
            Y = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);
            IsLive = true;
        }
        public int GetX()
        {
            return X;
        }
        public bool GetLive()
        {
            return IsLive;
        }

        public int GetY()
        {
            return Y;
        }
        public bool CompareCodinates(Player player, Bat bat)
        {
            if (bat.GetX() == player.GetX() - 1 && bat.GetY() == player.GetY() || bat.GetX() == player.GetX() && bat.GetY() == player.GetY() - 1 || bat.GetX() == player.GetX() + 1 && bat.GetY() == player.GetY() || bat.GetX() == player.GetX() && bat.GetY() == player.GetY() + 1)
                return true;
            else
                return false;
        }
        public void Voice()
        {
            Console.WriteLine("Шум");
        }
        public void Died()
        {
            IsLive = false;
        }

    }
}
