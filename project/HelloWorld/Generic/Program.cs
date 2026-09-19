namespace Generic;

internal class Program
{
    static void Main(string[] args)
    {
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //List<double> longNumbers = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
        //List<string> stringNumbers = new List<string> { "one", "two", "three", "four", "five" };

        //PrintAll(numbers);
        //PrintAll(longNumbers);
        //PrintAll(stringNumbers);
        //-------------------------
        //int[] numbers = { 1, 2, 3, 4 };

        //string[] names = { "Ali", "Reza", "Sara" };

        //PrintArray(numbers);
        //PrintArray(names);
        //----------------------------
        Box<int> integerBox = new Box<int>();
        integerBox.Value = 123;
        Box<string> strBox = new Box<string>();
        strBox.Value = "123";
        Console.WriteLine(integerBox.Value);
        Console.WriteLine(strBox.Value);

    }
    public static void PrintAll<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
    static void PrintArray<T>(T [] array)
    {
        foreach (T item in array)// it could be foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
internal class Box<T>
{
    public T Value { get; set; }
}
