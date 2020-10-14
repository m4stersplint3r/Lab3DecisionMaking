using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Day2_DecisionMaking
{
    class Program
    {
        public static bool validInputCheck(int x)
        {
            if (x <= 0 || x > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            string username, inputYN;
            int inputNum;
            bool validInput = false;
            bool continueInput = true;

            Console.Write("Please enter your name: ");
            username = Console.ReadLine();

            while (continueInput)
            {
                Console.Write($"{username}, please enter a number between 1 and 100: ");
                
                if(int.TryParse(Console.ReadLine(), out inputNum))
                {
                    validInput = validInputCheck(inputNum);
                }

                while (!validInput)
                {
                    Console.Write($"Really now {username}... Please try again. Enter a number between 1 and 100: ");
                    if (int.TryParse(Console.ReadLine(), out inputNum))
                    {
                        validInput = validInputCheck(inputNum);
                    }
                }

                if (inputNum % 2 != 0 && inputNum > 60)
                {
                    Console.WriteLine($"{username}, you entered {inputNum} which is an odd number and greater than 60.");
                }
                else if (inputNum % 2 != 0)
                {
                    Console.WriteLine($"{username}, you entered {inputNum} which is an odd number.");
                }
                else if (inputNum % 2 == 0 && inputNum > 60)
                {
                    Console.WriteLine($"{username}, you entered {inputNum} which is an even number and greater than 60.");
                }
                else if (inputNum % 2 == 0 && inputNum >= 26 && inputNum <= 60)
                {
                    Console.WriteLine($"{username}, you entered {inputNum} which is an even number and between 25 and 61.");
                }
                else if (inputNum % 2 == 0 && inputNum >= 2 && inputNum <= 25)
                {
                    Console.WriteLine($"{username}, you entered {inputNum} which is an even number and less than 25.");
                }

                Console.Write(Environment.NewLine + $"Would you like to continue {username}? (y/n): ");
                inputYN = Console.ReadLine();

                if (!(inputYN.ToLower().Trim() == "y"))
                {
                    continueInput = false;
                } else
                {
                    Console.WriteLine(Environment.NewLine);
                }
            }
            Console.WriteLine(Environment.NewLine + $"Thanks for using my program! Bye {username}!");
            

        }
    }
}
