namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome please enter your number (max:  4,294,967,295)");
            string numStr = Console.ReadLine() ?? "error";
            bool isValid = uint.TryParse(numStr, out uint num);
            if (!isValid)
            {
                Console.WriteLine("please enter a valid number");
                return;
            }
            else if (num < 1)
            {
                Console.WriteLine("being odd or even is just for natural numbers");
                return ;
            }
            else if(num % 2 ==0)
            {
                Console.WriteLine($"{num} is even");
                
            }
            else 
            {
                Console.WriteLine($"{num} is odd");
            }
        } 
    }
}
