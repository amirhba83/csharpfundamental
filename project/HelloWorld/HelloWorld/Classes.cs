using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Car
    {
        private int _year;
        public string Brand { get; init; }
        public string Model { get; init; }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value <= 2026 && value >= 1900)
                    _year = value;
            }
        }
        //--
        public Car(string brand, string model, int year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
        }
        public Car()
        {
            Brand = "UNKNOWN";
            Model = "UNKNOWN";
            Year = 0;
        }

        public void Start()
        {
            Console.WriteLine($"{Model} is starting");
        }

    }
    //--
    public class Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        //--
        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        //--
        public void ShowInfo()
        {
            Console.WriteLine($"{nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(Price)}: {Price}");
        }
        public void ApplyDiscount(decimal discountPercentage)
        {
            Price -= Price * discountPercentage / 100;
        }
        /////
        ///
    }
    public class Student
    {
        // fields
        private string _name;
        private byte _age;

        //properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public byte Age
        {
            get { return _age; }
            private set
            {
                if (value >= 1 && value <= 120)
                    _age = value;
            }
        }

        public Student(string name, byte age)
        {
            this.Name = name;
            this.Age = age;

        }
        //public double Average()
        //{
        //    return (Score1 + Score2) / 2.0;
        //}
        //public bool IsPassed()
        //{
        //    return Average() >= 10;
        //}
        //public void ShowInfo()
        //{
        //    Console.WriteLine($"{nameof(Name)}: {Name}," +
        //        $"  {nameof(Average)}: {Average()}," +
        //        $" {nameof(IsPassed)}?: {(IsPassed() ? "passed" : "failed")}");
        //}
    }
    //--------

    public class Rectangle
    {
        public double Width;
        public double Height;
        //--
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        //--
        public double GetArea()
        {
            return Width * Height;
        }
        //--
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        //--
        public bool IsSquare()
        {
            return Width == Height;
        }
        //--
        public void Scale(double factor)
        {
            Width *= factor;
            Height *= factor;
        }
        //--
        public void ShowInfo()
        {
            Console.WriteLine($"{nameof(Width)}: {Width}," +
                $" {nameof(Height)}: {Height},\n" +
                $" {nameof(GetArea)}: {GetArea()},\n " +
                $"{nameof(GetPerimeter)}: {GetPerimeter()},\n" +
                $" {nameof(IsSquare)}?: {(IsSquare() ? "Yes" : "No")}");
        }

    }
    //
    public class Account
    {
        public Account(string name, decimal amount)
        {
            this.OwnerName = name;
            this.Balance = amount;
            _totalAccount++;
        }
        private string _ownerName;
        private decimal _balance;
        static int _totalAccount;

        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if (value >= 0)
                    _balance = value;
            }

        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine(" موجودی کافی نیست");

        }
        public void ShowBalance()
        {
            Console.WriteLine($"owner {OwnerName} your balance is {Balance}");
        }
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Total accounts: {_totalAccount}");
        }
    }
    public class Product
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            private set
            {
                if (value >= 0)
                    _price = value;
            }
        }


        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void ChangePrice(decimal newPrice)
        {
            this.Price = newPrice;
        }
    }
    public class Employee
    {
        private string _name;
        private decimal _salary;
        //-- 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            private set
            {
                if (value >= 0)
                    _salary = value;
            }
        }
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public void IncreaseSalary(decimal amount)
        {
            if (amount > 0)
                Salary += amount;
        }
    }
    public class Boook
    {
        public string Title { get; set; }

        public string Author { get; set; }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            private set
            {
                if (value >= 0)
                    _price = value;
            }

        }

        public Boook(string title, string author, decimal price)
        {
            Price = price;
            Title = title;
            Author = author;
        }

        public void Discount(decimal amount)
        {
            // اگر amount مثبت بود،
            // قیمت را به اندازه amount کاهش بده
            // ولی قیمت نباید منفی شود.
            if (amount > 0 && amount <= Price)
                Price -= amount;
        }
    }
}

