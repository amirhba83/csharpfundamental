namespace Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<double> longNumbers = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
        List<string> stringNumbers = new List<string> { "one", "two", "three", "four", "five" };

        PrintAll(numbers);
        PrintAll(longNumbers);
        PrintAll(stringNumbers);
    }
    public static void PrintAll<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
