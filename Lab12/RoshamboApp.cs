using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp 
    {
        public Player ChooseUserPlayer()
        {
            int BotChoice;

            Console.WriteLine("You can play as yourself, or you may play as Penny or Sheldon. Please enter 1 to play as yourself, 2 as Penny, or 3 as Sheldon. (1,2,3)");
            BotChoice = Validation.ValidateInteger(Console.ReadLine());
            if (BotChoice == 1)
            {
                Player2 UserPlayer = new Player2();
                return UserPlayer;
            }
            else if (BotChoice == 2)
            {
                Penny UserPlayer = new Penny();
                return UserPlayer;
            }
            else
            {
                Sheldon UserPlayer = new Sheldon();
                return UserPlayer;
            }
        }
    }
}
