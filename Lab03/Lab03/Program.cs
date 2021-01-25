using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool userContinue = true;

            Console.WriteLine("Hello! What is your name?");
            var userName = Console.ReadLine();

            
            do
            {
                Console.WriteLine(userName + ", Enter a number between 1-100:");
                int inputNum = Convert.ToInt32(Console.ReadLine());


                if (inputNum % 2 != 0 || (inputNum >=60 && inputNum % 2 != 0))
                {
                    Console.WriteLine(inputNum + "and Odd.");                   
                }
                else
                {                    
                    if (inputNum >= 2 && inputNum <= 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (inputNum >= 26 && inputNum <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (inputNum >= 60)
                    {
                        Console.WriteLine(inputNum + "and Even.");
                    }                    
                }
                Console.WriteLine("Continue? (y/n):");
                var userInput = Console.ReadLine();

                if (userInput == "n")
                {
                    userContinue = false;
                }
            } while (userContinue == true);

            Console.WriteLine("Live Long & Prosper");
            Console.WriteLine("Bye!");






        }
    }
}
