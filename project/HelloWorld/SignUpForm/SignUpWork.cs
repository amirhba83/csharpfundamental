using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpForm
{
    public class SignUpWork
    {
        public static string CleanDataFromTextBox(string item)
            => (item.Trim().Replace(" ", "").ToLower());
        //------------
        public static void ShowNecessaryMessage(string property)
        => MessageBox.Show($"{property} is necessary, please try again. ");

        //-----------------
        public static bool CheckString(string property, string item)
        {
            string tempProperty = CleanDataFromTextBox(item);
            if (string.IsNullOrWhiteSpace(tempProperty))
            {
                ShowNecessaryMessage(property);
                return false;
            }
            else
                return true;
        }//
        public static string GetStringWithEmpty(string property)
        {
            while (true)
            {
                string tempProperty = CleanDataFromTextBox(property);
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
        public static int GetInt(string property)
        {
            return int.Parse(CleanDataFromTextBox(property));
        }
        //------------
        public static bool CheckInt(string property)
        {

            if (int.TryParse(CleanDataFromTextBox(property), out int number))
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        //___________________
        
        //----

        public static bool IsValidAgeWithMessage(string ageStr)
        {
            
            if (!CheckInt(ageStr))
            {
                MessageBox.Show($"age can just be numeric");
                return false;
            }
            else if (CheckInt(ageStr) && !(121 > GetInt(ageStr) && GetInt(ageStr) > 1))
            {
                MessageBox.Show($"age should be between 1 to 121");
                return false;
            }
            else if (CheckInt(ageStr) && 121 > GetInt(ageStr) && GetInt(ageStr) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------
        public static int GetAge(string property)
        {
            int age = default;
            age = GetInt(property);
            return age;
        }
        //-------------------------------
        public static bool CheckPhone(string phone)
        {
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("please enter a valid phone number");
                return false;
            }
            else
                return true;
        }
        //-------------------------
        public static bool IsValidPhone(string phone)
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
        public static string CleanPhone(string phone)
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
        public static void PrintProfile(string firstName, string lastName, int age, string gender, string phone)
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
        public static string GetGender()
        {

            string? gender = default;
            gender = GetStringWithEmpty(nameof(gender));
            while (!IsValidGender(gender))
            {
                gender = GetStringWithEmpty(nameof(gender));
                if (!IsValidGender(gender))
                    MessageBox.Show("please enter a valid  option (m for male - f for female - e for email)");
            }
            gender = CleanGender(gender);
            return gender;

        }
        //--------------------
        public static bool IsValidGender(string gender)
        {
            if (gender == "male" || gender == "m" || gender == "f" || gender == "female" || gender == string.Empty)
            {
                return true;
            }
            else if (gender == "e" || gender == "email")
            {
                MessageBox.Show("Nice try! We don't register emails 😄");
                return false;
            }
            else
                return false;
        }
        //--------------------------------------
        public static string CleanGender(string gender)
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
                        MessageBox.Show("please enter a valid option");
                        break;
                    }

            }
            return gender;
        }
    }
}
