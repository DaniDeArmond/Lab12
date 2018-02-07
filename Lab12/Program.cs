using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    //worked with Jacob

    enum Roshambo { Rock, Paper, Scissors };
    enum Score { Win, Loss, Draw };
    class Program
    {
        static void Main(string[] args)
        {
            bool Repeat = true;
            string PlayerChoice, DoAgain; 
            int RPSChoice, BotPlayerChoice = 0, WinCount = 0, LossCount = 0, DrawCount = 0;

            ScoreKeeper MyScore = new ScoreKeeper();
            Console.WriteLine("Welcome to Roshambo!");



            while (Repeat)
            {
                RoshamboApp BotChoice = new RoshamboApp();
                Player UserPlayer = BotChoice.ChooseUserPlayer();

                Penny Penny = new Penny();
                Sheldon Sheldon = new Sheldon();

                Console.WriteLine($"Would you like to play against {Penny} or {Sheldon}?");
                PlayerChoice = Validation.ValidateInput2(Console.ReadLine());

                Console.WriteLine("Rock, Paper, or Scissors?(Please enter R,P,S)");
                RPSChoice = UserPlayer.GenerateRoshambo();

                Console.WriteLine($"{UserPlayer}: {((Roshambo)RPSChoice)}");
                if (PlayerChoice == Penny.PlayerName)
                {
                    BotPlayerChoice = Penny.GenerateRoshambo();
                    Console.WriteLine($"{PlayerChoice}: {((Roshambo)BotPlayerChoice)}");
                }
                else if (PlayerChoice == Sheldon.PlayerName)
                {
                    BotPlayerChoice = Sheldon.GenerateRoshambo();
                    Console.WriteLine($"{PlayerChoice}: {((Roshambo)BotPlayerChoice)}");
                }
                if (MyScore.FindScore(RPSChoice, BotPlayerChoice)==0)
                {
                    WinCount++;
                }
                else if (MyScore.FindScore(RPSChoice, BotPlayerChoice)==1)
                {
                    LossCount++;
                }
                else if (MyScore.FindScore(RPSChoice, BotPlayerChoice)==2)
                {
                    DrawCount++;
                }
                Console.WriteLine($"{(Score)0}: {WinCount}, {(Score)1}: {LossCount}, {(Score)2}: {DrawCount}");

                Console.WriteLine("Would you like to play again? (Y or N)");
                DoAgain = Validation.ValidateYesNo(Console.ReadLine());

                if (DoAgain.ToLower() == "n")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    Repeat = false;
                }

            }
        }
    }
}
