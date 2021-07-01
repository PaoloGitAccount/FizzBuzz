using System;
using System.Linq;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConsoleWriter console = new ConsoleLog();
            Go(console);
        }

        public static void Go(IConsoleWriter console)
        {
            console.WriteLine("Starting FizzBuzz");

            // Run the FizzBuzz methods:
            FizzBuzz(console, 1, 100);
            FizzBuzz_2(console);

            console.WriteLine("Press any key to exit the program.");
            console.ReadKey();
        }

        public static void FizzBuzz(IConsoleWriter console, int start, int end)
        {
            console.WriteLine("Starting 1st standard method for FizzBuzz:");
            console.WriteLine(String.Format("Start: {0}, End: {1}", start, end));

            //const int n = 100;
            ////for (int i = 1; i <= n; i++)
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    console.Output("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    console.Output("Fizz");
                }
                else if (i % 5 == 0)
                {
                    console.Output("Buzz");
                }
                else
                {
                    console.Output(i);
                }
            }
        }

        public static void FizzBuzz_2(IConsoleWriter console)
        {
            //2nd method more efficient:
            console.WriteLine("Starting 2nd method for FizzBuzz:");

            Enumerable.Range(1, 100)
                .ToList()
                .ForEach(i => console.WriteLine(
                    i % 3 * i % 5 == 0 ? 
                    (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") : i.ToString()));
        }
    }
}
