using System.Runtime.CompilerServices;

namespace divisibility

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome; please enter the bigger number");
            string firstStr = Console.ReadLine() ?? "";
            bool b1 = int.TryParse(firstStr , out int first);
            if (b1 == false)
            {
                Console.WriteLine("I said enter a number goofy");
                Environment.Exit(0);
            }
            Console.WriteLine("ok! please enter the smaller one");
            string secondStr = Console.ReadLine() ?? "";
            bool b2 = int.TryParse(secondStr, out int second);
            if (b2 == false)
            {
                Console.WriteLine("I said enter a number goofy");
                Environment.Exit(0);
            }
            if (first < second)
            {
                Console.WriteLine("I said enter bigger at first :/");
                Environment.Exit(0);
            }
            int remainder = first % second;
            if (remainder == 0)
            {
                Console.WriteLine("first number is divisible by second number");
            }
            else
            {
                Console.WriteLine("first number is not divisible by second number");
            }

        }
    }
}
