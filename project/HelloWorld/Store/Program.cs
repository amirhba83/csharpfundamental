using Store.Models;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("mobile");
            Product p2 = new Product("mobile", 100);
            Product p3 = new Product("mobile") { Name = "minote" };
            p1.ApplyDiscount(10);
            p2.ApplyDiscountByAmount(10);
            p1.Show();
            p2.Show();
            p3.Show();
            Product.ShowTotalProduct();

            //Employee e1 = new("hamid", 500);
            //Manager m1 = new Manager("mohsen", 2000, 5);
            //SalesPerson s1 = new SalesPerson("arash", 2500, 100000);
            //e1.ShowInfo();
            //m1.ShowInfo();
            //s1.ShowInfo();



        }
    }
}
