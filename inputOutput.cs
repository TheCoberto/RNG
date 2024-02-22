using System;

namespace RNG
{
    public class inputOutput
    {
        public int GetMinimumNumber()
        {
            int min = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter a minimum number.");
                validInput = int.TryParse(Console.ReadLine(), out min);
            }

            return min;
        }

        public int GetMaximumNumber()
        {
            int max = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter a maximum number.");
                validInput = int.TryParse(Console.ReadLine(), out max);
            }

            return max;
        }

        public int HowManyNumbers()
        {
            int howMany = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("How many random numbers do you want to display?");
                validInput = int.TryParse(Console.ReadLine(), out howMany);
                Console.WriteLine();
            }

            return howMany;
        }

        public void RandomNumberGenerator(int minimum, int maximum, int howMany)
        {
            string userInput = "";

            while (true)
            {
                Random rng = new Random();
                int min = minimum;
                int max = maximum;
                int hm = howMany;

                for (int i = 0; i < hm; i++)
                {
                    Console.WriteLine(rng.Next(min, max + 1));
                }

                Console.WriteLine();
                Console.WriteLine("Enter any key for {0} new random number(s). Enter r to reset.", howMany);
                userInput = Console.ReadLine();

                if (userInput == "r")
                {
                    Program.Start();
                }
            }
        }
    }
}