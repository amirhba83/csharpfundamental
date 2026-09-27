#nullable disable
namespace ShopFirstConsole;

internal class InvoiceItem
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal TotalPrice
    {
        get { return Quantity * UnitPrice; }
    }
    public InvoiceItem(Product product, int quantity, decimal unitPrice)
    {
        if (IsValidData(product, quantity, unitPrice))
        {
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
    private bool IsValidData(Product product, int quantity, decimal unitPrice)
    {
        if (product == null ||
            quantity < 1 ||
            unitPrice < 0)
        {
            return false;
        }
        else
            return true;
    }
    public bool ChangeQuantity(int quantity)
    {
        if (quantity < 1)
            return false;

        Quantity = quantity;
        return true;
    }
    public bool ChangeUnitPrice(decimal unitPrice)
    {
        if (unitPrice < 0)
            return false;

        UnitPrice = unitPrice;
        return true;
    }    //public bool EditInvoiceItemInfo(int quantity, decimal unitPrice)
    //{
    //    if (quantity < 1 || unitPrice < 0)
    //        return false;

    //    Quantity = quantity;
    //    UnitPrice = unitPrice;
    //    return true;
    //}
}
