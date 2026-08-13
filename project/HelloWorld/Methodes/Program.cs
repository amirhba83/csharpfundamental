using System.ComponentModel.DataAnnotations;

namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write a method to check parity
            string sendParity = default;
            if (IsEven(num))
                sendParity = "even";
            else
                sendParity = "odd";
            Console.WriteLine($"the number is {sendParity}");
        }
        //___________________
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //---------------------
        static bool IsPositive(int num)
        {
            return (num > 0);
        }
        //--------------------------
        static bool IsGreater(int num, int num2)
        {
            return (num > num2);
        }
        // -------------------------
        static int Square(int num)
        {
            return num * num;
        }
        // -------------------
        static int Max(int num, int num2)
        {
            if (num > num2)
                return num;
            else
                return num2;
        }
        //---------------
        static int Min(int num, int num2)
        {
            if (num < num2)
                return num;
            else
                return num2;
        }
        // -----------------
        static double Avg(int num, int num2, int num3)
        {
            return (num + num2 + num3) / 3;
        }
        //----------------
        static int DigitCount(int num)
        {
            int count = 0;
            while (num >= 1)
            {
                num = num / 10;
                count++;
            }
            return count;
        }


        static void GetMinMax(int num, int num2, out int min, out int max)
        {
            max = 0;
            min = 0;
            if (num > num2)
            {
                min = num2;
                max = num;
            }
        }
        //---------------
        static void GetMinMax(int num, int num2, int num3, out int min, out int max)
        {
            if (num > num2)
            {
                max = num;
                min = num2;
            }
            else
            {
                max = num2;
                min = num;
            }

            if (num3 > max)
                max = num3;

            if (num3 < min)
                min = num3;
        }
        //-- 
        static void DoubleIt(ref int refer)
        {
            refer *= 2;
        }
        //---------------------------
        static void Swap(ref int num, ref int num2)
        {
            int temp;
            temp = num;
            num = num2;
            num2 = temp;
        }
        //
        static int Power(int num, int power = 2)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
                result = result * num;

            return result;
        }
        // 
        static void PrintInfo(string name, int age = 18, string city = "Unknown")
        {
            Console.WriteLine(
                $"\nname: {name}" +
                $"\nage: {age}" +
                $"\ncity: {city}");
        }
        // -----------
        static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }
        static int Multiply(int num1, int num2, int num3)
        {
            return (num1 * num2 * num3);
        }
        static double Multiply(int num1, double num2)
        {
            return (num1 * num2);
        }
        //--------------------
        static int Maz(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        static int Maz(int num1, int num2, int num3)
        {
            int max = 0;
            if (num1 > num2)
                max = num1;
            else
                max = num2;
            if (num3 > max)
                max = num3;
            return max;

        }
        static double Maz(double num1, double num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        public static int MultiMax(params int[] numbers)
        {
            int max = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
        static void AnalyzeNumber(out int min, out int max, out double average, params int[] numbers)
        {
            max = numbers[0];
            min = numbers[0];
            int sum = default;
            int count = default;
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                sum += number;
                count++;
            }
            average = sum / (double)count;
            
        }
        
    }
    
}
