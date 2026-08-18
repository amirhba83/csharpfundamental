using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    internal class Product
    {
        //Fields
        private decimal _price;
        private readonly int _id = default;
        private static int _nextId;
        private static int _count;
        //Properties
        public decimal Price
        {
            get { return _price; }
            private set
            {
                if (value > 0)
                    _price = value;
            }
        }

        public string Name { get; set; }
        public int Id
        {
            get { return _id; }
        }
        //Constructor
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            _id = _nextId;
            _nextId++;
            _count++;
        }
        public Product(string name) : this(name: name, price: 60)
        {
        }
        // Methodes 
        public void ApplyDiscount(decimal percent)
        {
            this.Price -= (this.Price * percent) / 100;
        }
        public void ApplyDiscountByAmount(decimal amount)
        {
            if (IsValidDiscountAmount(amount))
                this.Price -= amount;
        }
        public void Show()
        {
            Console.WriteLine($"" +
                $"\nproduct summary:" +
                $"\nproduct name:{Name}" +
                $"\nprice: {Price}" +
                $"\nID: {Id}");
        }
        public static void ShowTotalProduct()
        {
            Console.WriteLine($"the number of product is: {_count}");
        }
        private bool IsValidDiscountAmount(decimal amount)
        {
            if (amount > 0 && amount <= Price)
                return true;
            else 
            {
                Console.WriteLine("amount of discount is not valid");
                return false;
            }

        }

    }
}
