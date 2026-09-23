namespace ShopFirstConsole;

internal class Program
{
    static void Main(string[] args)
    {
        //Product p1 = new("laptop", "lenovo", 1000, 1500, 10);
        //Party pa1 = new("ali rezaei", "0160719176", "09123354361");
        //Invoice in1 = new(pa1, InvoiceType.Sale);
        //InvoiceItem initem1 = new(p1, 10, 1600);
        //in1.AddItem(initem1);
        //Console.WriteLine(in1.IsConfirmed);
        //in1.ConfirmSale();
        //foreach (var item in in1.Items)
        //{
        //    Console.WriteLine(item.Product.Name + " " + item.Quantity + " " + item.UnitPrice + "total  " + item.TotalPrice);
        //}
        //in1.ConfirmSale();
        //Console.WriteLine(in1.IsConfirmed);
        //Product p2 = new("mobile", "iphone", 600, 850, 10);
        //Product p3 = new("mouse", "lenovo", 100, 150, 10);
        //Party pa2 = new("ali rezaei", "0160719176", "09123354361");
        //Invoice in1 = new(pa2, InvoiceType.Sale);
        //InvoiceItem initem2 = new(p2, 6, 900);
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
        //Show.OutputMessage(in1.Total.ToString());
        //in1.ConfirmSale();
        //Show.OutputMessage(p2.StockQuantity.ToString());
        //Show.OutputMessage(p3.StockQuantity.ToString());
        //Show.OutputMessage(in1.IsConfirmed.ToString());
        //Invoice in2 = new(pa2, InvoiceType.Purchase);
        //InvoiceItem initem4  = new(p2, 25, 1000);
        ////List<InvoiceItem> items2 = new List<InvoiceItem>();
        ////items2.Add(initem4);
        //in2.AddItem(initem4);
        //in2.ConfirmPurchase();
        //Show.OutputMessage(p2.StockQuantity.ToString());
        ///---------------

        // =========================
        // 1. Products
        // =========================

        Product laptop = new(
            "Laptop",
            "Lenovo",
            1000,
            1500,
            5);

        Product mobile = new(
            "Mobile",
            "iPhone",
            600,
            850,
            10);

        Product mouse = new(
            "Mouse",
            "Lenovo",
            100,
            150,
            10);


        // =========================
        // 2. Parties
        // =========================

        Party ali = new(
            "Ali Rezaei",
            "09123354361",
            "0160719176");

        Party reza = new(
            "Reza Ahmadi",
            "09121111111",
            "1234567890");


        // =========================
        // 3. Purchase Invoice
        // =========================

        Invoice purchaseInvoice = new(
            ali,
            InvoiceType.Purchase);

        InvoiceItem purchaseLaptop = new(
            laptop,
            5,
            1000);

        InvoiceItem purchaseMobile = new(
            mobile,
            10,
            600);

        InvoiceItem purchaseMouse = new(
            mouse,
            20,
            100);

        purchaseInvoice.AddItem(purchaseLaptop);
        purchaseInvoice.AddItem(purchaseMobile);
        purchaseInvoice.AddItem(purchaseMouse);

        Show.OutputMessage("========== PURCHASE INVOICE ==========");

        Show.OutputMessage(
            $"Total: {purchaseInvoice.Total}");

        purchaseInvoice.ConfirmPurchase();


        // =========================
        // 4. First Sale Invoice
        // =========================

        Invoice saleInvoice1 = new(
            ali,
            InvoiceType.Sale);

        InvoiceItem saleLaptop = new(
            laptop,
            2,
            1600);

        InvoiceItem saleMouse = new(
            mouse,
            3,
            150);

        saleInvoice1.AddItem(saleLaptop);
        saleInvoice1.AddItem(saleMouse);

        Show.OutputMessage("\n========== SALE INVOICE 1 ==========");

        Show.OutputMessage(
            $"Total: {saleInvoice1.Total}");

        saleInvoice1.ConfirmSale();


        // =========================
        // 5. Second Sale Invoice
        // =========================

        Invoice saleInvoice2 = new(
            reza,
            InvoiceType.Sale);

        InvoiceItem saleMobile = new(
            mobile,
            3,
            900);

        InvoiceItem saleMouse2 = new(
            mouse,
            2,
            160);

        saleInvoice2.AddItem(saleMobile);
        saleInvoice2.AddItem(saleMouse2);

        Show.OutputMessage("\n========== SALE INVOICE 2 ==========");

        Show.OutputMessage(
            $"Total: {saleInvoice2.Total}");

        saleInvoice2.ConfirmSale();


        // =========================
        // 6. Products Status
        // =========================

        Show.OutputMessage("\n========== PRODUCTS ==========");

        Show.OutputMessage(
            $"{laptop.Name} | Stock: {laptop.StockQuantity}");

        Show.OutputMessage(
            $"{mobile.Name} | Stock: {mobile.StockQuantity}");

        Show.OutputMessage(
            $"{mouse.Name} | Stock: {mouse.StockQuantity}");


        // =========================
        // 7. Invoice Details
        // =========================

        Show.OutputMessage("\n========== INVOICE DETAILS ==========");

        PrintInvoice(purchaseInvoice);
        PrintInvoice(saleInvoice1);
        PrintInvoice(saleInvoice2);
    }


    static void PrintInvoice(Invoice invoice)
    {
        Show.OutputMessage(
            $"\nInvoice ID: {invoice.InvoiceId}");

        Show.OutputMessage(
            $"Party: {invoice.Party.Name}");

        Show.OutputMessage(
            $"Type: {invoice.Type}");

        Show.OutputMessage(
            $"Date: {invoice.Date}");

        foreach (InvoiceItem item in invoice.Items)
        {
            Show.OutputMessage(
                $"{item.Product.Name} | " +
                $"Quantity: {item.Quantity} | " +
                $"Unit Price: {item.UnitPrice} | " +
                $"Total: {item.TotalPrice}");
        }

        Show.OutputMessage(
            $"Invoice Total: {invoice.Total}");

        Show.OutputMessage(
            $"Confirmed: {invoice.IsConfirmed}");
    }
}