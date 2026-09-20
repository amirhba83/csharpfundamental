#nullable disable
namespace ShopFirstConsole;

internal class InvoiceItem
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal TotalPrice
    {
        get { return  Quantity * UnitPrice; } 
    }
    public InvoiceItem(Product product, int quantity , decimal unitPrice)
    {
        if (IsValidData(product, quantity, unitPrice))
        {
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
    private bool IsValidData (Product product, int quantity, decimal unitPrice)
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
    public void ChangeQuantity(int quantity)
    {
        Quantity = quantity;
    }
    public void ChangeUnitPrice(decimal  unitPrice)
    {
        UnitPrice = unitPrice;
    }
    public void EditInvoiceItemInfo(int quantity, decimal unitPrice)
    {
        ChangeQuantity(quantity);
        ChangeUnitPrice(unitPrice);
    }
}
