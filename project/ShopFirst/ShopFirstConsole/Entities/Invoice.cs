namespace ShopFirstConsole;

internal class Invoice
{
    private static int _nextId = 1;
    public int InvoiceId { get; private set; }
    public DateTime Date { get; private set; }
    public List<InvoiceItem> Items { get; private set; }
    // عملا چون پابلیک است از بیرون دسترسی های روی لیست قابل دسترسی است و خطرناک است و encapsulasion رعایت نشده .
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
    public bool AddItem(InvoiceItem item)
    {
        if (item != null && !IsConfirmed)
        {
            Items.Add(item);
            return true;
        }
        else
            return false;
    }
    public bool RemoveItem(InvoiceItem item)
    {
        if (item != null && !IsConfirmed)
        {
            return Items.Remove(item);
            // این متد در صورتی که آیتم وجود نداشته باشد false برمیگرداند و اگر آیتم وجود داشته باشد و حذف شود true برمیگرداند
        }

        return false;
    }
    public void ConfirmSale()
    {
        if (Type == InvoiceType.Sale)
        {
            if (!IsConfirmed)
            {
                if(CheckAndCorrectStockForSale())
                {
                    foreach(var item in Items)
                    {
                        item.Product.DecreaseStockQuantity(item.Quantity);
                    }

                    IsConfirmed = true;

                    Show.OutputMessage(
                        "registered successfully");
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
    private bool CheckAndCorrectStockForSale()
    {
        bool stockIsEnough = true;
        foreach (var item in Items)
        {
            if (item.Quantity > item.Product.StockQuantity)
            {
                stockIsEnough = false;
                ChangeItemQuantity(item,item.Product.StockQuantity);
            }
        }
        return stockIsEnough;
    }
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
    public bool ChangeItemQuantity(InvoiceItem item, int quantity)
    {
        if (item == null || IsConfirmed)
            return false;

        return item.ChangeQuantity(quantity);
    }
    public bool ChangeItemUnitPrice(InvoiceItem item, decimal unitPrice)
    {
        if (item == null || IsConfirmed)
            return false;

        return item.ChangeUnitPrice(unitPrice);
    }
}
