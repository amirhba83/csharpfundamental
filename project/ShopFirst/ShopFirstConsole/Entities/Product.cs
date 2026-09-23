#nullable disable

namespace ShopFirstConsole;

internal class Product
{
    #region properties
    private static int _nextId = 1;
    public int ProductId { get; private set; }
    public string Name { get; private set; }
    public string Brand { get; private set; }
    public decimal PurchasePrice { get; private set; }
    public decimal SalePrice { get; private set; }
    public int StockQuantity { get; private set; }
    #endregion
    //--------------------------------------------
    #region constructor
    public Product(string name, string brand, decimal purchasePrice, decimal salePrice, int stockQuantity)
    {

        if (IsValidData(name, brand, purchasePrice, salePrice, stockQuantity))
        {
            Name = name;
            Brand = brand;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            StockQuantity = stockQuantity;
            ProductId = _nextId++;
        }
    }
    #endregion
    //----
    #region methods
    private bool IsValidData(string name, string brand, decimal purchasePrice, decimal salePrice, int stockQuantity)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(brand) ||
            purchasePrice < 0 ||
            salePrice < 0 ||
            stockQuantity < 0)
        {
            return false;
        }
        else
            return true;

    }
    //--
    public bool IncreaseStockQuantity(int quantity)
    {
        if (quantity > 0)
        {
            StockQuantity = StockQuantity + quantity;
            return true;
        }
        else
        { return false; }
    }
    //--
    public bool DecreaseStockQuantity(int quantity)
    {
        if (quantity > 0 && StockQuantity >= quantity)
        {
            StockQuantity = StockQuantity - quantity;
            return true;
        }
        else
        { return false; }
    }
    public void UpdateProductInfo(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }
    //--
    public void UpdatePurchasePrice(decimal purchasePrice)
    {
        PurchasePrice = purchasePrice;
    }
    //--
    public void UpdateSalePrice(decimal salePrice)
    {
        SalePrice = salePrice;
    }
    //---
    public void IncreaseSalePriceByPercent(int percent)
    {
        SalePrice += (SalePrice * percent) / 100;
    }
    #endregion
}
