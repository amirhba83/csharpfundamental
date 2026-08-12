using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Car
    {
        public string Model;
        public int Year;
        //--
        public void Honk()
        {
            Console.WriteLine($"{Model}says بوووووووق");
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
        public string Name;
        public byte Score1;
        public byte Score2;
        public Student(string name, byte score1, byte score2)
        {
            Name = name;
            Score1 = score1;
            Score2 = score2;
        }
        public double Average()
        {
            return (Score1 + Score2) / 2.0;
        }
        public bool IsPassed()
        {
            return Average() >= 10;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{nameof(Name)}: {Name}," +
                $"  {nameof(Average)}: {Average()}," +
                $" {nameof(IsPassed)}?: {(IsPassed() ? "passed" : "failed")}");
        }
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
}
