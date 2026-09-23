namespace ShopFirstConsole;

internal class Invoice
{
    private static int _nextId = 1;
    public int InvoiceId { get; private set; }
    public DateTime Date { get; private set; }
    public List<InvoiceItem> Items { get; private set; }
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
    public Invoice(Party party, InvoiceType type)
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
    public void RemoveItem(InvoiceItem item)
    {
        Items.Remove(item);
    }
    public void ConfirmSale()
    {
        if (Type == InvoiceType.Sale)
        {
            if (!IsConfirmed)
            {
                bool flag = true;
                foreach (var item in Items)
                {
                    flag = flag && item.Quantity <= item.Product.StockQuantity;
                    if (item.Quantity > item.Product.StockQuantity)
                        item.ChangeQuantity(item.Product.StockQuantity);
                }
                if (flag)
                {
                    foreach (var item in Items)
                    {
                        item.Product.DecreaseStockQuantity(item.Quantity);
                    }
                    IsConfirmed = true;
                    Show.OutputMessage("registerd suceesfully");
                }
                else
                {
                    Show.OutputMessage("some quantities are replaced \n" +
                        "plesae recheck and then confirm");
                }
            }
            else
            {
                Show.OutputMessage("this invoice was already confirmed please use edit menue to change");
                return;
            }
        }
        else
        {
            Show.OutputMessage("not registerd pay attention to the invoice type and operation");
            return;
        }

    }
    //----
    public void ConfirmPurchase()
    {
        if (Type == InvoiceType.Purchase)
        {
            if (!IsConfirmed)
            {

                foreach (var item in Items)
                {
                    item.Product.IncreaseStockQuantity(item.Quantity);
                }
                IsConfirmed = true;
                Show.OutputMessage("registerd successfully");
            }
            else
            {
                Show.OutputMessage("this invoice was already confirmed please use edit menue to change");
                return;
            }
        }
        else
        {
            Show.OutputMessage("not registerd pay attention to the invoice type and operation");
            return;
        }

    }
    private bool CheckAndCorrectStock()
    {
        bool stockIsEnough = true;

        foreach (var item in Items)
        {
            if (item.Quantity > item.Product.StockQuantity)
            {
                stockIsEnough = false;
                item.ChangeQuantity(item.Product.StockQuantity);
            }
        }

        return stockIsEnough;
    }

}
