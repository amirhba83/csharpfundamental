namespace SignUp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsole();
            Console.WriteLine("welcome!");
            string? firstName = default;
            firstName = GetString(nameof(firstName));
            // get last name
            string? lastName = default;
            lastName = GetString(nameof(lastName));
            // get age
            int age = default;
            age = GetAge(nameof(age));
            // get gender
            string gender = GetGender();
            //--
            string phone = GetPhone();
            // print profile
            PrintProfile(firstName: firstName, lastName: lastName, age: age, gender: gender, phone: phone);
        }

        // _______________________________________________________________________________________
        //other methods
        static void ConfigureConsole()
        {
            Console.SetBufferSize(500, 500);//Size of console
            Console.BackgroundColor = ConsoleColor.DarkCyan;//Set Background color
            Console.ForegroundColor = ConsoleColor.Gray;//Set Text color
            Console.Clear();// fix 
            Console.Title = "Hello World portal!";//Title
            Console.SetCursorPosition(3, 3);//ser cursor position 

        }
        //-------------
        static string GetDataFromUser(string property)
        {
            ShowInputMessage(property);
            string tempProperty = Console.ReadLine() ?? string.Empty;
            tempProperty = tempProperty.Trim().Replace(" ", "").ToLower();
            return tempProperty;
        }
        //------------
        static void ShowInputMessage(string property)
        => Console.WriteLine($"pleas enter your {property}:");
        //-------------
        static void ShowNecessaryMessage(string property)
        => Console.WriteLine($"{property} is necessary, please try again. ");

        //-----------------
        static string GetString(string property)
        {
            while (true)
            {
                string tempProperty = GetDataFromUser(property);
                if (string.IsNullOrWhiteSpace(tempProperty))
                {
                    ShowNecessaryMessage(property);
                    continue;
                }
                else
                    return tempProperty;

            }

        }//
        static string GetStringWithEmpty(string property)
        {
            while (true)
            {
                string tempProperty = GetDataFromUser(property);
                if (tempProperty == null)
                {
                    ShowNecessaryMessage(property);
                    continue;
                }
                else
                    return tempProperty;

            }

        }
        //-----------------
        static int GetInt(string property)
        {
            while (true)
            {
                if (int.TryParse(GetString(property), out int number))
                {
                    return number;
                }
                else
                    Console.WriteLine("please enter a valid number");
                continue;
            }
        }
        //___________________
        static bool IsValidAge(int age)
        {
            if (1 < age && age < 120)
                return true;
            else
                return false;
        }
        //----------------
        static int GetAge(string property)
        {
            int age = default;
            while (!IsValidAge(age))
            {
                age = GetInt(property);
                if (!IsValidAge(age))
                    Console.WriteLine("legal range is 1 to 120");
            }
            return age;
        }
        //-------------------------------
        static string GetPhone()
        {
            string? phone = default;
            phone = GetString(nameof(phone));
            while (!IsValidPhone(phone))
            {
                phone = GetString(nameof(phone));
                if (!IsValidPhone(phone))
                    Console.WriteLine("please enter a valid phone number");
            }
            phone = CleanPhone(phone);
            return phone;
        }
        //-------------------------
        static bool IsValidPhone(string phone)
        {
            if (
                  (phone.Length > 1 && long.TryParse(phone.Substring(1), out long number)) &&
                     (
                        phone.Length == 13 && phone.StartsWith("+98") ||
                        phone.Length == 14 && phone.StartsWith("0098") ||
                        phone.Length == 12 && phone.StartsWith("98") ||
                        phone.Length == 11 && phone.StartsWith("09") ||
                        phone.Length == 10 && phone.StartsWith("9")
                     )
                )
            {
                return true;
            }
            else
                return false;
        }
        //----------------
        static string CleanPhone(string phone)
        {
            if (phone.Length == 14 && phone.StartsWith("0098"))
            {
                phone = (phone.Remove(0, 2)).Insert(0, "+");
            }
            else if (phone.Length == 12 && phone.StartsWith("98"))
            {
                phone = phone.Insert(0, "+");
            }
            else if (phone.Length == 11 && phone.StartsWith("09"))
            {
                phone = (phone.Remove(0, 2)).Insert(0, "+98");
            }
            else if (phone.Length == 10 && phone.StartsWith("9"))
            {
                phone = (phone.Remove(0, 1)).Insert(0, "+98");
            }
            return phone;
        }
        //----------------
        static void PrintProfile(string firstName, string lastName, int age, string gender, string phone)
        {
            Console.WriteLine(
                    $"Registration Summary:\n" +
                    $"first name: {firstName}\n" +
                    $"last name: {lastName}\n" +
                    $"age: {age}\n" +
                    $"gender: {gender}\n" +
                    $"phone number: {phone}\n");

        }
        //-------------------
        static string GetGender()
        {

            string? gender = default;
            gender = GetStringWithEmpty(nameof(gender) + " (m for male - f for female - e for email)");
            while (!IsValidGender(gender))
            {
                gender = GetStringWithEmpty(nameof(gender));
                if (!IsValidGender(gender))
                    Console.WriteLine("please enter a valid  option");
            }
            gender = CleanGender(gender);
            return gender;

        }
        //--------------------
        static bool IsValidGender(string gender)
        {
            if (gender == "male" || gender == "m" || gender == "f" || gender == "female"|| gender == string.Empty)
            {
                return true;
            }
            else if (gender == "e" || gender == "email")
            {
                Console.WriteLine("Nice try! We don't register emails 😄");
                return false;
            }
             else
                return false;
        }
        //--------------------------------------
        static string CleanGender(string gender)
        {
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
                case "":
                    {
                        gender = "prefer not to say";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please enter a valid option");
                        break;
                    }

            }
            return gender;
        }
 }

}
