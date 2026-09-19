namespace OutRef;

internal class Program
{
    static void Main(string[] args)
    {
        bool isEven = false;
        Calculate(5,ref isEven, out int fac);
        Console.WriteLine($"isEven: {isEven}\nfac: {fac}");



    }
    static void Calculate(int number, ref bool isEven, out int fac)
    {
        isEven = number % 2 == 0;
        fac = 1;
        for (int i = number; i >= 1; i--)
        {
            fac *= i;
        }
    }
}
