namespace SignUp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(500, 500);//Size of console
            Console.BackgroundColor = ConsoleColor.DarkCyan;//Set Background color
            Console.ForegroundColor = ConsoleColor.Gray;//Set Text color
            Console.Clear();// fix 
            Console.Title = "Hello World portal!";//Title
            Console.SetCursorPosition(3, 3);//Start of cursor
            // end of graphic unit
            // get first name
            Console.WriteLine("welcome! please enter your first name");
            string? firstName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("name is necessary");
                return;
            }
            // get last name    
            Console.WriteLine("now enter your last name");
            string? lastName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("last name is necessary to");
                return;
            }
            // get age
            Console.WriteLine("how old are you??");
            string ageStr = Console.ReadLine() ?? "0";// we can do try parse 
            bool isValidAge = byte.TryParse(ageStr, out byte age);
            if (!isValidAge || age < 1 || age > 120)
            {
                Console.WriteLine("please enter a valid age (1 to 120)");
                return;
            }
            else if (age < 18)
            {
                Console.WriteLine("you cant register in this app now (18+)");
                return;
            }
            // get gender
            //string gender;
            Console.WriteLine("enter gender--> m: Male , f: Female , e:Email :/");
            string? gender = Console.ReadLine();
            switch(gender)
            {
                case "m" or "M" or "male" or "Male" :
                    {
                        gender = "Male";
                        break;
                    }
                case "f" or "F" or "female" or "Female":
                    {
                        gender = "Female";
                        break;
                    }
                case "e":
                    {
                        Console.WriteLine("Nice try! We don't register email addresses as a gender. 😄");
                        return;
                    }
                case "":
                    {
                        gender = "prefer not to say";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please enter a valid option");
                        return;
                    }
            }
            // print profile
            Console.WriteLine( $"you entered:\n" +
                               $"first name: {firstName}\n" +
                               $"last name: {lastName}\n"+
                               $"age: {age}\n"+
                               $"gender: {gender}");
        }
    }
}
