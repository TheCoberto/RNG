using System;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.Clear();
            inputOutput io = new inputOutput();
            int minimum = io.GetMinimumNumber();
            int maximum = io.GetMaximumNumber();
            int howMany = io.HowManyNumbers();
            io.RandomNumberGenerator(minimum, maximum, howMany);
        }
    }
}