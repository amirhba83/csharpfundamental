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
            Console.SetCursorPosition(3, 3);//ser cursor position 
            // Configure console appearance
            // get first name
            Console.WriteLine("welcome! please enter your first name");
            string firstName = Console.ReadLine() ?? String.Empty;
            firstName = firstName.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("name is necessary");
                return;
            }
            // get last name    
            Console.WriteLine("now enter your last name");
            string lastName = Console.ReadLine() ?? String.Empty;
            lastName = lastName.Trim();// because of IsNullOrWhiteSpace it's not necessary 
            lastName = lastName.ToLower();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Last name is required");
                return;
            }
            // get age
            Console.WriteLine("how old are you ?");
            string ageStr = Console.ReadLine() ?? "0";// we should do try parse 
            ageStr = ageStr.Trim();
            bool isAgeValid = byte.TryParse(ageStr, out byte age);
            if (!isAgeValid || age < 1 || age > 120)
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
            string? gender = Console.ReadLine() ?? String.Empty;
            gender = gender.Trim();
            gender = gender.ToLower();
            switch (gender)
            {
                case "m" or "male":
                    {
                        gender = "Male";
                        break;
                    }
                case "f" or "female":
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
            Console.WriteLine("please enter your phone number");
            string phone;
            string enteredPhone = Console.ReadLine() ?? String.Empty;
            enteredPhone = enteredPhone.Trim();
            bool isPhoneValid = default;
            bool isNumericValid = default;
            isNumericValid = long.TryParse(enteredPhone.Substring(1), out long p);
            if (enteredPhone.Length == 13 && enteredPhone.StartsWith("+98"))
            {
                phone = enteredPhone;
                isPhoneValid = true;
            }
            else if(enteredPhone.Length == 14 && enteredPhone.StartsWith("0098"))
            {
                phone = (enteredPhone.Remove(0,2)).Insert(0,"+");
                isPhoneValid = true;
            }
            else if (enteredPhone.Length == 12 && enteredPhone.StartsWith("98"))
            {
                phone = enteredPhone.Insert(0, "+");
                isPhoneValid = true;
            }
            else if(enteredPhone.Length == 11 && enteredPhone.StartsWith("09"))
            {
                phone = (enteredPhone.Remove(0, 2)).Insert(0, "+98");
                isPhoneValid = true;
            }
            else if (enteredPhone.Length == 10 && enteredPhone.StartsWith("9"))
            {
                phone = (enteredPhone.Remove(0, 1)).Insert(0, "+98");
                isPhoneValid = true;
            }
            else if (!isNumericValid)
            {
                Console.WriteLine("please enter a valid phone");
                return;
            }
            else 
            {
                Console.WriteLine("please enter a valid phone");
                return;
            }

            // print profile
            if (isPhoneValid && isAgeValid)
            Console.WriteLine(
                $"Registration Summary:\n" +
                $"first name: {firstName}\n" +
                $"last name: {lastName}\n" +
                $"age: {age}\n" +
                $"gender: {gender}\n" +
                $"phone number: {phone}\n");
        }
    }
}
