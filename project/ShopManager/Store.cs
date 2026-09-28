namespace ShopManager;

public class Store
{
    readonly List<Product> _products = new();
    readonly List<Party> _parties = new();
    readonly List<Invoice> _invoices = new();
    readonly List<Transaction> _transactions = new();

    public IReadOnlyList<Product> Products => _products;
    public IReadOnlyList<Party> Parties => _parties;
    public IReadOnlyList<Invoice> Invoices => _invoices;

    public Product AddProduct(string name, decimal buy, decimal sell, int stock = 0)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("نام کالا را وارد کنید");
        var p = new Product(name.Trim(), buy, sell);
        if (stock > 0) p.Increase(stock);
        _products.Add(p);
        return p;
    }

    public Party AddParty(string name, string phone)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("نام را وارد کنید");
        var p = new Party(name.Trim(), phone?.Trim() ?? "");
        _parties.Add(p);
        return p;
    }

    public SaleInvoice Sell(Party party, IEnumerable<InvoiceItem> lines, decimal paid)
    {
        var items = Validate(party, lines, paid);
        foreach (var g in items.GroupBy(i => i.Product))
            if (g.Sum(i => i.Quantity) > g.Key.Stock)
                throw new InvalidOperationException($"موجودی «{g.Key.Name}» کافی نیست (موجود: {g.Key.Stock})");
        foreach (var i in items) i.Product.Decrease(i.Quantity);
        var inv = new SaleInvoice(party, items);
        _invoices.Add(inv);
        if (paid > 0) _transactions.Add(new Receipt(party, paid));
        return inv;
    }

    public PurchaseInvoice Buy(Party party, IEnumerable<InvoiceItem> lines, decimal paid)
    {
        var items = Validate(party, lines, paid);
        foreach (var i in items) i.Product.Increase(i.Quantity);
        var inv = new PurchaseInvoice(party, items);
        _invoices.Add(inv);
        if (paid > 0) _transactions.Add(new Payment(party, paid));
        return inv;
    }

    public void Receive(Party party, decimal amount)
    {
        if (party == null) throw new ArgumentException("طرف‌حساب را انتخاب کنید");
        _transactions.Add(new Receipt(party, amount));
    }

    public void Pay(Party party, decimal amount)
    {
        if (party == null) throw new ArgumentException("طرف‌حساب را انتخاب کنید");
        _transactions.Add(new Payment(party, amount));
    }

    // مثبت = طرف‌حساب به ما بدهکار است ، منفی = ما به او بدهکاریم
    public decimal GetBalance(Party p) =>
        _invoices.OfType<SaleInvoice>().Where(i => i.Party == p).Sum(i => i.Total)
      - _invoices.OfType<PurchaseInvoice>().Where(i => i.Party == p).Sum(i => i.Total)
      - _transactions.OfType<Receipt>().Where(t => t.Party == p).Sum(t => t.Amount)
      + _transactions.OfType<Payment>().Where(t => t.Party == p).Sum(t => t.Amount);

    public decimal TotalSales => _invoices.OfType<SaleInvoice>().Sum(i => i.Total);
    public decimal TotalPurchases => _invoices.OfType<PurchaseInvoice>().Sum(i => i.Total);
    public decimal StockValue => _products.Sum(p => p.Stock * p.BuyPrice);
    public decimal Receivables => _parties.Select(GetBalance).Where(b => b > 0).Sum();
    public decimal Payables => -_parties.Select(GetBalance).Where(b => b < 0).Sum();

    static List<InvoiceItem> Validate(Party party, IEnumerable<InvoiceItem> lines, decimal paid)
    {
        if (party == null) throw new ArgumentException("طرف‌حساب را انتخاب کنید");
        var items = lines.ToList();
        if (items.Count == 0) throw new ArgumentException("فاکتور هیچ ردیفی ندارد");
        var total = items.Sum(i => i.Total);
        if (paid < 0 || paid > total) throw new ArgumentException("مبلغ پرداختی باید بین صفر و جمع فاکتور باشد");
        return items;
    }
}
