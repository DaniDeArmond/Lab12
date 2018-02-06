using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        public int RoshamboValue;
        public string PlayerName, PlayerChoice;

        public Player() { }

        public abstract int GenerateRoshambo();

    }
}
