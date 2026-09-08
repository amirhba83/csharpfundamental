

using Newtonsoft.Json;
using System.Text.Json;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Student student1 = new Student("Ali", 20, 18);  
            //Student student2 = new Student("Akbar", 12, 8);
            //Student student3 = new Student("Asghar", 3, 9);
            //student1.ShowInfo();
            //student2.ShowInfo();
            //student3.ShowInfo();
            //Rectangle rectangle = new Rectangle(5, 10);
            //rectangle.ShowInfo();
            //rectangle.Scale(2);
            //rectangle.ShowInfo();
            //Account a1 = new Account("Ali", 1000);
            //Account a2 = new Account("mahmood", 200);
            //Account a3 = new Account("Akbar", 500000);
            //a1.ShowBalance();
            //a2.ShowBalance();
            //a3.ShowBalance();
            //a1.Deposit(555);
            //a2.Withdraw(300);
            //a1.ShowBalance();
            //a2.ShowBalance();
            //Account.ShowTotalAccounts();
            //string filePath = "C:\\Users\\laboo\\Desktop\\c#\\project\\HelloWorld\\HelloWorld\\text1.txt";
            //if (File.Exists(filePath))
            //{
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine(content);
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}
            //Console.WriteLine("--------------------");
            //if (File.Exists(filePath))
            //{
            //    int i=1;
            //    string [] content = File.ReadAllLines(filePath);
            //    foreach (string line in content)
            //    {
            //        Console.WriteLine(line+i);
            //        i++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}
            //Console.WriteLine("--------------------");
            //StreamReader fileText = new StreamReader(filePath);
            //string  line2;
            //Console.WriteLine(fileText);
            //Console.WriteLine("--------------------");
            //while ((line2 = fileText.ReadLine()) != null)
            //{
            //    Console.WriteLine(line2);
            //}
            //Console.WriteLine("------------------++--");
            //string filePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "text1.txt");
            //string line3;
            //StreamReader filetext2 = new StreamReader(filePath2);
            //while ((line3 = filetext2.ReadLine()) != null)
            //{
            //    Console.WriteLine(line3);
            //}
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product.json");
            string jsonContent = File.ReadAllText(jsonFilePath);
            List<Product2> products = JsonConvert.DeserializeObject<List<Product2>>(jsonContent);

            foreach (var product2 in products)
            {
                Console.WriteLine($"Product Name: {product2.Name}");
                Console.WriteLine($"Product Price: {product2.Price}");
                Console.WriteLine($"Product Quantity: {product2.Quantity}");
            }
        }
    }
    internal class Product2
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }



    }
}
