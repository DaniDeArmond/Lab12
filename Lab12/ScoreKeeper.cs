using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ScoreKeeper
    {
        //win 0, loss 1, draw 2
        //rock 0, paper 1, scissors 2
        public int FindScore(int Choice1, int Choice2)
        {
            if (Choice1 == 0 && Choice2 == 2 || Choice1 == 1 && Choice2 == 0 || Choice1 == 2 && Choice2 == 1)
            {
                return 0;
            }
            else if (Choice1 == 0 && Choice2 == 1 || Choice1 == 1 && Choice2 == 2 || Choice1 == 2 && Choice2 == 0)
            {
                return 1;
            }
 
            else if (Choice1 == 0 && Choice2 == 0 || Choice1 == 1 && Choice2 == 1 || Choice1 == 2 && Choice2 == 2)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

    }
}
