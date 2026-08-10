namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome please enter your number (max:  4,294,967,295)");
            string numStr = Console.ReadLine() ?? "error";
            bool isValid = int.TryParse(numStr, out int num);
            if (!isValid)
            {
                Console.WriteLine("please enter a valid number");
                return;
            }
            else if (num < 1)
            {
                Console.WriteLine("being odd or even is just for natural numbers");
                return;
            }
            string parity = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"{num} is {parity}");
            //Console.WriteLine($"{num} is {(num % 2 == 0 ? "even" : "odd")}.");
        }
    }
}
