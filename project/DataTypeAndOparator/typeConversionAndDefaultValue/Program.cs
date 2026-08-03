namespace typeConversionAndDefaultValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = null;
            string? str2 = default;// string default value is null
            string? str3 = "249";// zero length string
            //----------------------------------------------------
            int x = 1111111111;
            short y = default;
            x = y; //implicit conversion
            Console.WriteLine(x + " " + y);
            //----------------------------------------------------
            y = (short)x;// explicit type conversion -- casting 
            Console.WriteLine(x + " ---" + y);
            //----------------------------------------------------
            x = Convert.ToInt32(str2);// using convert
            Console.WriteLine(x);
            //----------------------------------------------------
            y = short.Parse(str2);// test parse method
            Console.WriteLine(y);
            //----------------------------------------------------
            bool isInt = int.TryParse(str2, out x);// using tryparse method
            Console.WriteLine(x);
        }
    }
}
