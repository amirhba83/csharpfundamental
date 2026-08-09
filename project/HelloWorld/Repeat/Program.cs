namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i =2 ; i<=100 ; i+=2)
            {
                Console.WriteLine(i);
                count ++;
            }
            Console.WriteLine($"the count of even number is {count}");

            // second practice
            Console.WriteLine("please enter a number");
            string numberStr = Console.ReadLine() ?? string.Empty;
            bool isNumberValid = int.TryParse(numberStr, out int number);
            if (!isNumberValid)
            {
                Console.WriteLine($"{number} is invalid");
                return;
            }
            else if (number <= 0)
            {
                Console.WriteLine($"{number} is not powitive");
                return;
            } 
            else
            {
                for(int i = 0 ; i <= number ;i++)
                    Console.WriteLine(i);
            }
        }
    }
}
