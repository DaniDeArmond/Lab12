using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    class Sheldon : Player
    {
        Random SheldonRandom = new Random();

        public Sheldon()
        {
            PlayerName = "Sheldon";
        }


        public override int GenerateRoshambo()
        {
            return SheldonRandom.Next(0, 2);
        }
        public override string ToString()
        {
            return PlayerName;
        }
    }
}
