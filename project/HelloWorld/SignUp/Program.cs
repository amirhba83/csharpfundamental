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
                                            //------------------------
            string firstName;
            while (true)
            {
                Console.WriteLine("welcome! please enter your first name");
                firstName = Console.ReadLine() ?? String.Empty;
                firstName = firstName.Trim().ToLower();
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("name is necessary please try again");
                }
                else
                    break;
            }
            // get last name
            string lastName;
            while (true)
            {
                Console.WriteLine("now enter your last name");
                lastName = Console.ReadLine() ?? String.Empty;
                lastName = lastName.Trim();// because of IsNullOrWhiteSpace it's not necessary 
                lastName = lastName.ToLower();
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Last name is required");
                }
                else break;
            }
            // get age
            byte age;
            bool isAgeValid;
            while (true)
            {
                Console.WriteLine("how old are you ?");
                string ageStr = Console.ReadLine() ?? "0";// we should do try parse 
                ageStr = ageStr.Trim();
                isAgeValid = byte.TryParse(ageStr, out age);
                if (!isAgeValid || age < 1 || age > 120)
                {
                    Console.WriteLine("please enter a valid age (1 to 120)");
                }
                else if (age < 18)
                {
                    Console.WriteLine("you cant register in this app now (18+)");
                    return;
                }
                else break;
            }
            // get gender
            string gender;
            bool isGenderValid = default;
            while (true)
            {
                Console.WriteLine("enter gender--> m: Male , f: Female , e:Email :/");
                gender = Console.ReadLine() ?? string.Empty;
                gender = gender.Trim();
                gender = gender.ToLower();
                switch (gender)
                {
                    case "m" or "male":
                        {
                            gender = "Male";
                            isGenderValid = true;
                            break;
                        }
                    case "f" or "female":
                        {
                            gender = "Female";
                            isGenderValid = true;
                            break;
                        }
                    case "":
                        {
                            gender = "prefer not to say";
                            isGenderValid = true;
                            break;
                        }
                    case "e":
                        {
                            Console.WriteLine("Nice try! We don't register email addresses as a gender. 😄");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("please enter a valid option");
                            break;
                        }
                }
                if (isGenderValid)
                    break;

            }
            //--
            string phone = default;
            bool isPhoneValid = default;
            bool isNumericValid = default;
            while (!isPhoneValid)
            {
                Console.WriteLine("please enter your phone number");
                string enteredPhone = Console.ReadLine() ?? string.Empty;
                enteredPhone = enteredPhone.Trim();
                if (enteredPhone == string.Empty || enteredPhone.Length < 2)
                {
                    Console.WriteLine("not valid");
                    continue;
                }                    
                isNumericValid = long.TryParse(enteredPhone.Substring(1), out long p);
                if (enteredPhone.Length == 13 && enteredPhone.StartsWith("+98"))
                {
                    phone = enteredPhone;
                    isPhoneValid = true;
                }
                else if (enteredPhone.Length == 14 && enteredPhone.StartsWith("0098"))
                {
                    phone = (enteredPhone.Remove(0, 2)).Insert(0, "+");
                    isPhoneValid = true;
                }
                else if (enteredPhone.Length == 12 && enteredPhone.StartsWith("98"))
                {
                    phone = enteredPhone.Insert(0, "+");
                    isPhoneValid = true;
                }
                else if (enteredPhone.Length == 11 && enteredPhone.StartsWith("09"))
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
                    Console.WriteLine("not valid");
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }

            // print profile
            if (isPhoneValid && isAgeValid)
            {
                Console.WriteLine(
                    $"Registration Summary:\n" +
                    $"first name: {firstName}\n" +
                    $"last name: {lastName}\n" +
                    $"age: {age}\n" +
                    $"gender: {gender}\n" +
                    $"phone number: {phone}\n");
                return;
            }

        }
    }
}
