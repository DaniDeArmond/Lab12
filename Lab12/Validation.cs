using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12
{
    class Validation
    {
        public static string ValidateYesNo(string Word)
        {
            while (!Regex.IsMatch(Word, @"[YyNn]"))
            {
                Console.WriteLine("You did not enter 'Y' or 'N'. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static string ValidateInput1()
        {
            string Word = Console.ReadLine();
            while (Regex.IsMatch(Word.ToLower(), "[rps]") != true)
            {
                Console.WriteLine("You did not enter R, P, or S. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static string ValidateInput1(string Word)
        {
             
            while (Regex.IsMatch(Word.ToLower(), "[rps]") != true)
            {
                Console.WriteLine("You did not enter R, P, or S. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static string ValidateInput2(string Word)
        {


            while (Regex.IsMatch(Word.ToLower(), "(penny)|(sheldon)") != true)
            {
                Console.WriteLine("You did not enter 'Penny' or 'Sheldon'. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static int ValidateInteger(string Input)
        {
            int Answer = 0;
            bool Repeat = true;

            while (Repeat == true)
            {
                while (int.TryParse(Input, out int Result) != true)
                {
                    Console.WriteLine("You did not enter a valid number choice. Please try again.");
                    Input = Console.ReadLine();
                }

                Answer = int.Parse(Input);
                if (Answer > -1 && Answer < 4)
                {
                    Repeat = false;
                }
                else
                {
                    Console.WriteLine("You can only enter 1, 2, or 3. Please try again.");
                }
            }
            return Answer;
        }
    }
}
