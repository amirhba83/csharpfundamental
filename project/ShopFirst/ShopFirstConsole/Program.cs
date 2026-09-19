using ShopFirst;

namespace ShopFirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new("laptop", "lenovo", 1000, 1500, 10);
            Party pa1 = new("ali rezaei", "0160719176", "09123354361");
            Invoice in1 = new(pa1, InvoiceType.Sale);
            InvoiceItem initem1 = new(p1, 10, 1600);
            in1.AddItem(initem1);
            Console.WriteLine(in1.IsConfirmed);
            in1.ConfirmSale();
            foreach (var item in in1.Items)
            {
                Console.WriteLine(item.Product.Name+" "+item.Quantity+ " " + item.UnitPrice+ "total  "+item.TotalPrice);
            }
            in1.ConfirmSale();
            Console.WriteLine(in1.IsConfirmed);










            //Product p2 = new("mobile", "lenovo", 600, 850, 10);
            //Product p3 = new("mouse", "lenovo", 100, 150, 10);
            //InvoiceItem initem2 = new(p2, 2, 900);
            //InvoiceItem initem3 = new(p3, 2, 150);
            //List<InvoiceItem> items = new List<InvoiceItem>()
            //{
            //    initem2,
            //    initem3
            //};
            //foreach (InvoiceItem item in items)
            //{
            //    in1.AddItem(item);
            //}
            //Console.WriteLine(in1.Total);
            




        }
    }
}
