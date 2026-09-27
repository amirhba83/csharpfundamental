//namespace ShopFirstConsole;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        //Product p1 = new("laptop", "lenovo", 1000, 1500, 10);
//        //Party pa1 = new("ali rezaei", "0160719176", "09123354361");
//        //Invoice in1 = new(pa1, InvoiceType.Sale);
//        //InvoiceItem initem1 = new(p1, 10, 1600);
//        //in1.AddItem(initem1);
//        //Console.WriteLine(in1.IsConfirmed);
//        //in1.ConfirmSale();
//        //foreach (var item in in1.Items)
//        //{
//        //    Console.WriteLine(item.Product.Name + " " + item.Quantity + " " + item.UnitPrice + "total  " + item.TotalPrice);
//        //}
//        //in1.ConfirmSale();
//        //Console.WriteLine(in1.IsConfirmed);
//        //Product p2 = new("mobile", "iphone", 600, 850, 10);
//        //Product p3 = new("mouse", "lenovo", 100, 150, 10);
//        //Party pa2 = new("ali rezaei", "0160719176", "09123354361");
//        //Invoice in1 = new(pa2, InvoiceType.Sale);
//        //InvoiceItem initem2 = new(p2, 6, 900);
//        //InvoiceItem initem3 = new(p3, 2, 150);
//        //List<InvoiceItem> items = new List<InvoiceItem>()
//        //{
//        //    initem2,
//        //    initem3
//        //};
//        //foreach (InvoiceItem item in items)
//        //{
//        //    in1.AddItem(item);
//        //}
//        //Show.OutputMessage(in1.Total.ToString());
//        //in1.ConfirmSale();
//        //Show.OutputMessage(p2.StockQuantity.ToString());
//        //Show.OutputMessage(p3.StockQuantity.ToString());
//        //Show.OutputMessage(in1.IsConfirmed.ToString());
//        //Invoice in2 = new(pa2, InvoiceType.Purchase);
//        //InvoiceItem initem4  = new(p2, 25, 1000);
//        ////List<InvoiceItem> items2 = new List<InvoiceItem>();
//        ////items2.Add(initem4);
//        //in2.AddItem(initem4);
//        //in2.ConfirmPurchase();
//        //Show.OutputMessage(p2.StockQuantity.ToString());
//        ///---------------

//        // =========================
//        // 1. Products
//        // =========================

//    //    Product laptop = new(
//    //        "Laptop",
//    //        "Lenovo",
//    //        1000,
//    //        1500,
//    //        5);

//    //    Product mobile = new(
//    //        "Mobile",
//    //        "iPhone",
//    //        600,
//    //        850,
//    //        10);

//    //    Product mouse = new(
//    //        "Mouse",
//    //        "Lenovo",
//    //        100,
//    //        150,
//    //        10);


//    //    // =========================
//    //    // 2. Parties
//    //    // =========================

//    //    Party ali = new(
//    //        "Ali Rezaei",
//    //        "09123354361",
//    //        "0160719176");

//    //    Party reza = new(
//    //        "Reza Ahmadi",
//    //        "09121111111",
//    //        "1234567890");


//    //    // =========================
//    //    // 3. Purchase Invoice
//    //    // =========================

//    //    Invoice purchaseInvoice = new(
//    //        ali,
//    //        InvoiceType.Purchase);

//    //    InvoiceItem purchaseLaptop = new(
//    //        laptop,
//    //        5,
//    //        1000);

//    //    InvoiceItem purchaseMobile = new(
//    //        mobile,
//    //        10,
//    //        600);

//    //    InvoiceItem purchaseMouse = new(
//    //        mouse,
//    //        20,
//    //        100);

//    //    purchaseInvoice.AddItem(purchaseLaptop);
//    //    purchaseInvoice.AddItem(purchaseMobile);
//    //    purchaseInvoice.AddItem(purchaseMouse);

//    //    Show.OutputMessage("========== PURCHASE INVOICE ==========");

//    //    Show.OutputMessage(
//    //        $"Total: {purchaseInvoice.Total}");

//    //    purchaseInvoice.ConfirmPurchase();


//    //    // =========================
//    //    // 4. First Sale Invoice
//    //    // =========================

//    //    Invoice saleInvoice1 = new(
//    //        ali,
//    //        InvoiceType.Sale);

//    //    InvoiceItem saleLaptop = new(
//    //        laptop,
//    //        2,
//    //        1600);

//    //    InvoiceItem saleMouse = new(
//    //        mouse,
//    //        3,
//    //        150);

//    //    saleInvoice1.AddItem(saleLaptop);
//    //    saleInvoice1.AddItem(saleMouse);

//    //    Show.OutputMessage("\n========== SALE INVOICE 1 ==========");

//    //    Show.OutputMessage(
//    //        $"Total: {saleInvoice1.Total}");

//    //    saleInvoice1.ConfirmSale();


//    //    // =========================
//    //    // 5. Second Sale Invoice
//    //    // =========================

//    //    Invoice saleInvoice2 = new(
//    //        reza,
//    //        InvoiceType.Sale);

//    //    InvoiceItem saleMobile = new(
//    //        mobile,
//    //        3,
//    //        900);

//    //    InvoiceItem saleMouse2 = new(
//    //        mouse,
//    //        2,
//    //        160);

//    //    saleInvoice2.AddItem(saleMobile);
//    //    saleInvoice2.AddItem(saleMouse2);

//    //    Show.OutputMessage("\n========== SALE INVOICE 2 ==========");

//    //    Show.OutputMessage(
//    //        $"Total: {saleInvoice2.Total}");

//    //    saleInvoice2.ConfirmSale();


//    //    // =========================
//    //    // 6. Products Status
//    //    // =========================

//    //    Show.OutputMessage("\n========== PRODUCTS ==========");

//    //    Show.OutputMessage(
//    //        $"{laptop.Name} | Stock: {laptop.StockQuantity}");

//    //    Show.OutputMessage(
//    //        $"{mobile.Name} | Stock: {mobile.StockQuantity}");

//    //    Show.OutputMessage(
//    //        $"{mouse.Name} | Stock: {mouse.StockQuantity}");


//    //    // =========================
//    //    // 7. Invoice Details
//    //    // =========================

//    //    Show.OutputMessage("\n========== INVOICE DETAILS ==========");

//    //    PrintInvoice(purchaseInvoice);
//    //    PrintInvoice(saleInvoice1);
//    //    PrintInvoice(saleInvoice2);
//    //}


//    //static void PrintInvoice(Invoice invoice)
//    //{
//    //    Show.OutputMessage(
//    //        $"\nInvoice ID: {invoice.InvoiceId}");

//    //    Show.OutputMessage(
//    //        $"Party: {invoice.Party.Name}");

//    //    Show.OutputMessage(
//    //        $"Type: {invoice.Type}");

//    //    Show.OutputMessage(
//    //        $"Date: {invoice.Date}");

//    //    foreach (InvoiceItem item in invoice.Items)
//    //    {
//    //        Show.OutputMessage(
//    //            $"{item.Product.Name} | " +
//    //            $"Quantity: {item.Quantity} | " +
//    //            $"Unit Price: {item.UnitPrice} | " +
//    //            $"Total: {item.TotalPrice}");
//    //    }

//    //    Show.OutputMessage(
//    //        $"Invoice Total: {invoice.Total}");

//    //    Show.OutputMessage(
//    //        $"Confirmed: {invoice.IsConfirmed}");

//    }
//}
using ShopFirstConsole;

namespace ShopFirstConsole;

internal static class Program
{
    static void Main()
    {
        // =====================================================
        // 1. ساخت محصولات
        // =====================================================

        Product laptop = new(
            "Laptop",
            "Lenovo",
            1000,
            1500,
            5);

        Product mobile = new(
            "Mobile",
            "Samsung",
            500,
            900,
            10);

        Product mouse = new(
            "Mouse",
            "Logitech",
            50,
            150,
            10);


        // =====================================================
        // 2. ساخت طرف حساب‌ها
        // =====================================================

        Party ali = new(
            "Ali Rezaei",
            "09120000000",
            "1234567890");

        Party reza = new(
            "Reza Ahmadi",
            "09350000000",
            "9876543210");


        // =====================================================
        // 3. ساخت فاکتور خرید
        // =====================================================

        Invoice purchaseInvoice =
            new(ali, InvoiceType.Purchase);

        InvoiceItem purchaseLaptop =
            new(laptop, 5, 1000);

        InvoiceItem purchaseMobile =
            new(mobile, 10, 600);

        InvoiceItem purchaseMouse =
            new(mouse, 20, 100);

        Console.WriteLine("========== PURCHASE ==========");

        Console.WriteLine(
            $"Add Laptop: {purchaseInvoice.AddItem(purchaseLaptop)}");

        Console.WriteLine(
            $"Add Mobile: {purchaseInvoice.AddItem(purchaseMobile)}");

        Console.WriteLine(
            $"Add Mouse: {purchaseInvoice.AddItem(purchaseMouse)}");

        Console.WriteLine(
            $"Purchase Total: {purchaseInvoice.Total}");

        Console.WriteLine(
            $"Confirmed Before: {purchaseInvoice.IsConfirmed}");

        purchaseInvoice.ConfirmPurchase();

        Console.WriteLine(
            $"Confirmed After: {purchaseInvoice.IsConfirmed}");


        // =====================================================
        // 4. تست تأیید دوباره خرید
        // =====================================================

        Console.WriteLine("\n========== DUPLICATE PURCHASE CONFIRM ==========");

        purchaseInvoice.ConfirmPurchase();

        Console.WriteLine(
            $"Laptop Stock: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Mobile Stock: {mobile.StockQuantity}");

        Console.WriteLine(
            $"Mouse Stock: {mouse.StockQuantity}");


        // =====================================================
        // 5. تست AddItem(null)
        // =====================================================

        Console.WriteLine("\n========== INVALID ADD ==========");

        Invoice testInvoice =
            new(ali, InvoiceType.Sale);

        Console.WriteLine(
            $"Add null item: {testInvoice.AddItem(null)}");


        // =====================================================
        // 6. تست تغییر Quantity نامعتبر
        // =====================================================

        Console.WriteLine("\n========== INVALID QUANTITY ==========");

        InvoiceItem testItem =
            new(laptop, 2, 1500);

        Console.WriteLine(
            $"Original Quantity: {testItem.Quantity}");

        Console.WriteLine(
            $"Change Quantity to -10: " +
            $"{testItem.ChangeQuantity(-10)}");

        Console.WriteLine(
            $"Quantity After: {testItem.Quantity}");

        Console.WriteLine(
            $"Change Quantity to 5: " +
            $"{testItem.ChangeQuantity(5)}");

        Console.WriteLine(
            $"Quantity After: {testItem.Quantity}");


        // =====================================================
        // 7. تست تغییر قیمت نامعتبر
        // =====================================================

        Console.WriteLine("\n========== INVALID PRICE ==========");

        Console.WriteLine(
            $"Original UnitPrice: {testItem.UnitPrice}");

        Console.WriteLine(
            $"Change Price to -100: " +
            $"{testItem.ChangeUnitPrice(-100)}");

        Console.WriteLine(
            $"UnitPrice After: {testItem.UnitPrice}");

        Console.WriteLine(
            $"Change Price to 1600: " +
            $"{testItem.ChangeUnitPrice(1600)}");

        Console.WriteLine(
            $"UnitPrice After: {testItem.UnitPrice}");


        // =====================================================
        // 8. ساخت فاکتور فروش
        // =====================================================

        Invoice saleInvoice =
            new(ali, InvoiceType.Sale);

        InvoiceItem saleLaptop =
            new(laptop, 2, 1600);

        InvoiceItem saleMouse =
            new(mouse, 3, 150);

        saleInvoice.AddItem(saleLaptop);
        saleInvoice.AddItem(saleMouse);

        Console.WriteLine("\n========== SALE ==========");

        Console.WriteLine(
            $"Sale Total: {saleInvoice.Total}");

        Console.WriteLine(
            $"Confirm Sale: {saleInvoice.IsConfirmed}");

        saleInvoice.ConfirmSale();

        Console.WriteLine(
            $"Confirmed After: {saleInvoice.IsConfirmed}");

        Console.WriteLine(
            $"Laptop Stock: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Mouse Stock: {mouse.StockQuantity}");


        // =====================================================
        // 9. تست تأیید دوباره فروش
        // =====================================================

        Console.WriteLine("\n========== DUPLICATE SALE CONFIRM ==========");

        saleInvoice.ConfirmSale();

        Console.WriteLine(
            $"Laptop Stock: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Mouse Stock: {mouse.StockQuantity}");


        // =====================================================
        // 10. تست تغییر Quantity بعد از Confirm
        // =====================================================

        Console.WriteLine("\n========== EDIT CONFIRMED INVOICE ==========");

        Console.WriteLine(
            $"Change Quantity After Confirm: " +
            $"{saleInvoice.ChangeItemQuantity(saleLaptop, 10)}");

        Console.WriteLine(
            $"Quantity: {saleLaptop.Quantity}");


        // =====================================================
        // 11. تست تغییر قیمت بعد از Confirm
        // =====================================================

        Console.WriteLine(
            $"Change Price After Confirm: " +
            $"{saleInvoice.ChangeItemUnitPrice(saleLaptop, 2000)}");

        Console.WriteLine(
            $"UnitPrice: {saleLaptop.UnitPrice}");


        // =====================================================
        // 12. تست AddItem بعد از Confirm
        // =====================================================

        InvoiceItem newItem =
            new(mobile, 1, 900);

        Console.WriteLine(
            $"Add Item After Confirm: " +
            $"{saleInvoice.AddItem(newItem)}");


        // =====================================================
        // 13. تست RemoveItem بعد از Confirm
        // =====================================================

        Console.WriteLine(
            $"Remove Item After Confirm: " +
            $"{saleInvoice.RemoveItem(saleLaptop)}");


        // =====================================================
        // 14. فروش با موجودی ناکافی
        // =====================================================

        Console.WriteLine("\n========== INSUFFICIENT STOCK SALE ==========");

        Invoice insufficientSale =
            new(reza, InvoiceType.Sale);

        InvoiceItem tooManyLaptops =
            new(laptop, 100, 1600);

        insufficientSale.AddItem(tooManyLaptops);

        Console.WriteLine(
            $"Requested Quantity: {tooManyLaptops.Quantity}");

        Console.WriteLine(
            $"Stock Before: {laptop.StockQuantity}");

        insufficientSale.ConfirmSale();

        Console.WriteLine(
            $"Quantity After Check: {tooManyLaptops.Quantity}");

        Console.WriteLine(
            $"Stock After First Confirm: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Confirmed: {insufficientSale.IsConfirmed}");


        // =====================================================
        // 15. تأیید مجدد فاکتور اصلاح‌شده
        // =====================================================

        Console.WriteLine("\n========== RECONFIRM CORRECTED SALE ==========");

        insufficientSale.ConfirmSale();

        Console.WriteLine(
            $"Stock After Second Confirm: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Confirmed: {insufficientSale.IsConfirmed}");


        // =====================================================
        // 16. تست RemoveItem قبل از Confirm
        // =====================================================

        Console.WriteLine("\n========== REMOVE BEFORE CONFIRM ==========");

        Invoice removeTest =
            new(ali, InvoiceType.Sale);

        InvoiceItem removeItem =
            new(mouse, 2, 150);

        removeTest.AddItem(removeItem);

        Console.WriteLine(
            $"Items Before Remove: {removeTest.Items.Count}");

        Console.WriteLine(
            $"Remove Result: {removeTest.RemoveItem(removeItem)}");

        Console.WriteLine(
            $"Items After Remove: {removeTest.Items.Count}");


        // =====================================================
        // 17. تست TotalPrice
        // =====================================================

        Console.WriteLine("\n========== TOTAL PRICE ==========");

        InvoiceItem totalTest =
            new(mobile, 3, 900);

        Console.WriteLine(
            $"Quantity: {totalTest.Quantity}");

        Console.WriteLine(
            $"UnitPrice: {totalTest.UnitPrice}");

        Console.WriteLine(
            $"TotalPrice: {totalTest.TotalPrice}");


        // =====================================================
        // 18. تست تغییر Quantity و محاسبه مجدد TotalPrice
        // =====================================================

        Console.WriteLine("\n========== TOTAL PRICE AFTER QUANTITY CHANGE ==========");

        totalTest.ChangeQuantity(5);

        Console.WriteLine(
            $"Quantity: {totalTest.Quantity}");

        Console.WriteLine(
            $"TotalPrice: {totalTest.TotalPrice}");


        // =====================================================
        // 19. موجودی نهایی
        // =====================================================

        Console.WriteLine("\n========== FINAL STOCK ==========");

        Console.WriteLine(
            $"Laptop: {laptop.StockQuantity}");

        Console.WriteLine(
            $"Mobile: {mobile.StockQuantity}");

        Console.WriteLine(
            $"Mouse: {mouse.StockQuantity}");


        Console.WriteLine("\n========== TEST FINISHED ==========");
    }
}