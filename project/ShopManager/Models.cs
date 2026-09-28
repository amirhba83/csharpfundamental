namespace ShopManager;

public class Product
{
    static int _next = 1;
    public int Id { get; } = _next++;
    public string Name { get; }
    public decimal BuyPrice { get; private set; }
    public decimal SellPrice { get; private set; }
    public int Stock { get; private set; }

    public Product(string name, decimal buyPrice, decimal sellPrice)
    { Name = name; BuyPrice = buyPrice; SellPrice = sellPrice; }

    public void Increase(int qty)
    {
        if (qty <= 0) throw new ArgumentException("تعداد باید بیشتر از صفر باشد");
        Stock += qty;
    }

    public void Decrease(int qty)
    {
        if (qty <= 0) throw new ArgumentException("تعداد باید بیشتر از صفر باشد");
        if (qty > Stock) throw new InvalidOperationException($"موجودی «{Name}» کافی نیست (موجود: {Stock})");
        Stock -= qty;
    }

    public override string ToString() => Name;
}

public class Party // هم مشتری هم تامین‌کننده
{
    static int _next = 1;
    public int Id { get; } = _next++;
    public string Name { get; }
    public string Phone { get; }
    public Party(string name, string phone) { Name = name; Phone = phone; }
    public override string ToString() => Name;
}

public class InvoiceItem
{
    public Product Product { get; }
    public int Quantity { get; }
    public decimal UnitPrice { get; }
    public InvoiceItem(Product product, int quantity, decimal unitPrice)
    {
        if (quantity <= 0) throw new ArgumentException("تعداد باید بیشتر از صفر باشد");
        if (unitPrice < 0) throw new ArgumentException("قیمت نامعتبر است");
        Product = product; Quantity = quantity; UnitPrice = unitPrice;
    }
    public decimal Total => Quantity * UnitPrice;
    public override string ToString() => $"{Product.Name} × {Quantity} @ {UnitPrice:N0} = {Total:N0}";
}

public abstract class Invoice
{
    static int _next = 1;
    readonly List<InvoiceItem> _items;
    public int Id { get; } = _next++;
    public DateTime Date { get; } = DateTime.Now;
    public Party Party { get; }
    public IReadOnlyList<InvoiceItem> Items => _items;
    public abstract string TypeName { get; }
    protected Invoice(Party party, IEnumerable<InvoiceItem> items) { Party = party; _items = items.ToList(); }
    public decimal Total => _items.Sum(i => i.Total);
}

public class SaleInvoice : Invoice
{
    public SaleInvoice(Party p, IEnumerable<InvoiceItem> items) : base(p, items) { }
    public override string TypeName => "فروش";
}

public class PurchaseInvoice : Invoice
{
    public PurchaseInvoice(Party p, IEnumerable<InvoiceItem> items) : base(p, items) { }
    public override string TypeName => "خرید";
}

public abstract class Transaction
{
    static int _next = 1;
    public int Id { get; } = _next++;
    public DateTime Date { get; } = DateTime.Now;
    public Party Party { get; }
    public decimal Amount { get; }
    protected Transaction(Party party, decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("مبلغ باید بیشتر از صفر باشد");
        Party = party; Amount = amount;
    }
}

public class Receipt : Transaction { public Receipt(Party p, decimal a) : base(p, a) { } }  // دریافت از طرف‌حساب
public class Payment : Transaction { public Payment(Party p, decimal a) : base(p, a) { } }  // پرداخت به طرف‌حساب
