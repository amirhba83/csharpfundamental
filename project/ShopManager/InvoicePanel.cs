namespace ShopManager;

// یک پنل مشترک برای فاکتور خرید و فاکتور فروش
public class InvoicePanel : UserControl
{
    readonly Store _store;
    readonly bool _isSale;
    readonly Action _onSaved;
    readonly ComboBox _party = UI.Combo(), _product = UI.Combo();
    readonly NumericUpDown _qty = UI.Num(1, 1), _price = UI.Num(0, 0), _paid = UI.Num(0, 0);
    readonly ListBox _lines = new() { Dock = DockStyle.Fill };
    readonly Label _total = new() { AutoSize = true, Margin = new Padding(6, 8, 12, 0), Text = "جمع کل: 0" };
    readonly List<InvoiceItem> _items = new();

    public InvoicePanel(Store store, bool isSale, Action onSaved)
    {
        _store = store; _isSale = isSale; _onSaved = onSaved;
        Dock = DockStyle.Fill;

        var top = UI.Flow();
        UI.Add(top, isSale ? "مشتری" : "تامین‌کننده", _party);
        UI.Add(top, "کالا", _product);
        UI.Add(top, "تعداد", _qty);
        UI.Add(top, "قیمت واحد", _price);
        top.Controls.Add(UI.Button("افزودن ردیف", (s, e) => UI.Try(AddLine)));

        var bottom = UI.Flow(DockStyle.Bottom);
        bottom.Controls.Add(_total);
        UI.Add(bottom, isSale ? "مبلغ دریافتی" : "مبلغ پرداختی", _paid);
        bottom.Controls.Add(UI.Button("پاک کردن ردیف‌ها", (s, e) => ClearLines()));
        bottom.Controls.Add(UI.Button(isSale ? "ثبت فاکتور فروش" : "ثبت فاکتور خرید", (s, e) => UI.Try(Save)));

        _product.SelectedIndexChanged += (s, e) =>
        {
            if (_product.SelectedItem is Product p)
                _price.Value = _isSale ? p.SellPrice : p.BuyPrice;
        };

        Controls.Add(_lines);
        Controls.Add(bottom);
        Controls.Add(top);
    }

    public void Reload()
    {
        var party = _party.SelectedItem; var product = _product.SelectedItem;
        _party.DataSource = _store.Parties.ToList();
        _product.DataSource = _store.Products.ToList();
        if (party != null) _party.SelectedItem = party;
        if (product != null) _product.SelectedItem = product;
    }

    void AddLine()
    {
        if (_product.SelectedItem is not Product p) throw new ArgumentException("کالا را انتخاب کنید");
        var item = new InvoiceItem(p, (int)_qty.Value, _price.Value);
        _items.Add(item);
        _lines.Items.Add(item.ToString());
        _total.Text = $"جمع کل: {_items.Sum(i => i.Total):N0}";
        _paid.Value = 0;
    }

    void ClearLines()
    {
        _items.Clear(); _lines.Items.Clear(); _total.Text = "جمع کل: 0"; _paid.Value = 0;
    }

    void Save()
    {
        var party = _party.SelectedItem as Party;
        if (_isSale) _store.Sell(party, _items, _paid.Value);
        else _store.Buy(party, _items, _paid.Value);
        ClearLines();
        _onSaved();
        MessageBox.Show("فاکتور ثبت شد", "موفق");
    }
}
