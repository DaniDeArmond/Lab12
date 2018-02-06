using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player2 : Player
    {
        public Player2()
        {
            Console.WriteLine("Please enter your name");
            PlayerName = Console.ReadLine();
            if (PlayerName == "")
            {
                PlayerName = "Barry";
            }
            Console.WriteLine($"Hello, {PlayerName}!");

        }


        public override int GenerateRoshambo()
        {
            string Choice = Validation.ValidateInput1();
            if (string.Compare(Choice, "R", true) == 0)
            {
                return 0;
            }
            else if (string.Compare(Choice, "P", true) == 0)
            {
                return 1;
            }
            else if (string.Compare(Choice, "S", true) == 0)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
        public override string ToString()
        {
            return PlayerName;
        }
    }
}
