namespace ShopFirst; 

internal class Invoice
{
    private static int _nextId = 1;
    public int InvoiceId { get; private set; }
    public DateTime Date { get; private set; }
    public List<InvoiceItem>   Items { get; private set; }
    public Party Party { get; private set; }
    public InvoiceType Type { get; private set; }
    public bool IsConfirmed { get; private set; }
    public decimal Total 
    {
        get
        {
            decimal sum = 0;
            foreach (var item in Items) 
            {
                sum += item.TotalPrice;
            }
            return sum;
        }
    }
    //---
    public Invoice (Party party, InvoiceType type)
    {
        InvoiceId = _nextId++;
        Date = DateTime.Now;
        IsConfirmed = false;
        Type = type;
        Party = party;
        Items = new List<InvoiceItem>();
    }
    public void AddItem(InvoiceItem item)
    {
        Items.Add(item);
    }
    public void ConfirmSale()
    {   

        if (IsConfirmed == false)
        {
            bool flag= true;
            foreach (var item in Items)
            {
                flag = flag && item.Quantity <= item.Product.StockQuantity;
                if (item.Quantity > item.Product.StockQuantity)
                    item.ChangeQuantity(item.Product.StockQuantity);
            }
            if(flag)
            {
                foreach (var item in Items)
                {
                    item.Product.DecreaseStockQuantity(item.Quantity);
                }
                IsConfirmed = true;
            }
            else
            {
                Console.WriteLine(
                                     "تعداد برخی اقلام به دلیل کمبود موجودی اصلاح شد. " +
                                         "لطفاً فاکتور را بررسی و دوباره تأیید کنید."
                                 );
            }
        }
        else 
        {
            Console.WriteLine("این فاکتور قبلا ثبت شده است لطفا برای تغییر از مسیر تغییر استقاده کنید ");
            return;
        }
    }
    
}
