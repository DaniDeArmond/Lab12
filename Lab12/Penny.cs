using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Penny : Player
    {
        public Penny()
        {
            PlayerName = "Penny";
        }

        public override int GenerateRoshambo()
        {
            return 0;
        }
        public override string ToString()
        {
            return PlayerName;
        }
    }
}
