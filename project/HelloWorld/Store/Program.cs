using Store.Models;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("mobile");
            Product p2 = new Product("mobile",100);
            Product p3 = new Product("mobile") {Name="minote"};
            p1.ApplyDiscount(10);
            p2.ApplyDiscountByAmount(10);
            p1.Show();
            p2.Show();
            p3.Show();
            Product.ShowTotalProduct();


        }
    }
}
