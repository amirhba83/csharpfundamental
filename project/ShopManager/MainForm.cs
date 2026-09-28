namespace ShopManager;

public class MainForm : Form
{
    readonly Store _store = new();
    readonly DataGridView _gProducts = UI.Grid(), _gParties = UI.Grid(), _gInvoices = UI.Grid();
    readonly Label _report = new() { AutoSize = true, Padding = new Padding(16), Font = new Font("Tahoma", 12) };
    readonly ComboBox _accParty = UI.Combo();
    readonly NumericUpDown _accAmount = UI.Num(0, 0);
    readonly InvoicePanel _sale, _buy;

    public MainForm()
    {
        Text = "مدیریت فروشگاه";
        Font = new Font("Tahoma", 10);
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        Width = 1000; Height = 650;
        StartPosition = FormStartPosition.CenterScreen;

        _sale = new InvoicePanel(_store, true, RefreshAll);
        _buy = new InvoicePanel(_store, false, RefreshAll);

        var tabs = new TabControl { Dock = DockStyle.Fill, RightToLeftLayout = true };
        tabs.TabPages.Add(ProductsTab());
        tabs.TabPages.Add(PartiesTab());
        tabs.TabPages.Add(Page("فروش", _sale));
        tabs.TabPages.Add(Page("خرید", _buy));
        tabs.TabPages.Add(Page("فاکتورها", _gInvoices));
        tabs.TabPages.Add(AccountsTab());
        tabs.TabPages.Add(Page("گزارش", _report));
        Controls.Add(tabs);

        Seed();
        RefreshAll();
    }

    static TabPage Page(string title, Control c)
    {
        var p = new TabPage(title);
        p.Controls.Add(c);
        return p;
    }

    TabPage ProductsTab()
    {
        var name = new TextBox { Width = 150 };
        var buy = UI.Num(0, 0); var sell = UI.Num(0, 0); var stock = UI.Num(0, 0);
        var top = UI.Flow();
        UI.Add(top, "نام کالا", name);
        UI.Add(top, "قیمت خرید", buy);
        UI.Add(top, "قیمت فروش", sell);
        UI.Add(top, "موجودی اولیه", stock);
        top.Controls.Add(UI.Button("افزودن کالا", (s, e) => UI.Try(() =>
        {
            _store.AddProduct(name.Text, buy.Value, sell.Value, (int)stock.Value);
            name.Clear(); RefreshAll();
        })));
        var page = new TabPage("کالاها");
        page.Controls.Add(_gProducts);
        page.Controls.Add(top);
        return page;
    }

    TabPage PartiesTab()
    {
        var name = new TextBox { Width = 150 }; var phone = new TextBox { Width = 120 };
        var top = UI.Flow();
        UI.Add(top, "نام", name);
        UI.Add(top, "تلفن", phone);
        top.Controls.Add(UI.Button("افزودن طرف‌حساب", (s, e) => UI.Try(() =>
        {
            _store.AddParty(name.Text, phone.Text);
            name.Clear(); phone.Clear(); RefreshAll();
        })));
        var page = new TabPage("مشتری / تامین‌کننده");
        page.Controls.Add(_gParties);
        page.Controls.Add(top);
        return page;
    }

    TabPage AccountsTab()
    {
        var top = UI.Flow();
        UI.Add(top, "طرف‌حساب", _accParty);
        UI.Add(top, "مبلغ", _accAmount);
        top.Controls.Add(UI.Button("دریافت وجه", (s, e) => UI.Try(() =>
        { _store.Receive(_accParty.SelectedItem as Party, _accAmount.Value); _accAmount.Value = 0; RefreshAll(); })));
        top.Controls.Add(UI.Button("پرداخت وجه", (s, e) => UI.Try(() =>
        { _store.Pay(_accParty.SelectedItem as Party, _accAmount.Value); _accAmount.Value = 0; RefreshAll(); })));
        var hint = new Label
        {
            AutoSize = true, Padding = new Padding(12),
            Text = "دریافت وجه: بابت تسویه بدهی مشتری   |   پرداخت وجه: بابت تسویه بدهی ما به تامین‌کننده\nمانده‌ها در تب مشتری / تامین‌کننده دیده می‌شود."
        };
        var page = new TabPage("دریافت و پرداخت");
        page.Controls.Add(hint);
        page.Controls.Add(top);
        return page;
    }

    void RefreshAll()
    {
        _gProducts.DataSource = _store.Products.Select(p => new
        {
            شماره = p.Id, نام = p.Name,
            قیمت_خرید = p.BuyPrice.ToString("N0"), قیمت_فروش = p.SellPrice.ToString("N0"), موجودی = p.Stock
        }).ToList();

        _gParties.DataSource = _store.Parties.Select(p =>
        {
            var b = _store.GetBalance(p);
            return new
            {
                شماره = p.Id, نام = p.Name, تلفن = p.Phone, مانده = Math.Abs(b).ToString("N0"),
                وضعیت = b > 0 ? "بدهکار به ما" : b < 0 ? "طلبکار از ما" : "تسویه"
            };
        }).ToList();

        _gInvoices.DataSource = _store.Invoices.Select(i => new
        {
            شماره = i.Id, نوع = i.TypeName, تاریخ = i.Date.ToString("yyyy/MM/dd HH:mm"),
            طرف_حساب = i.Party.Name, تعداد_ردیف = i.Items.Count, جمع = i.Total.ToString("N0")
        }).ToList();

        var sel = _accParty.SelectedItem;
        _accParty.DataSource = _store.Parties.ToList();
        if (sel != null) _accParty.SelectedItem = sel;

        _sale.Reload();
        _buy.Reload();

        _report.Text =
            $"جمع فروش: {_store.TotalSales:N0}\n" +
            $"جمع خرید: {_store.TotalPurchases:N0}\n" +
            $"ارزش موجودی انبار (به قیمت خرید): {_store.StockValue:N0}\n" +
            $"مطالبات از مشتریان: {_store.Receivables:N0}\n" +
            $"بدهی به تامین‌کنندگان: {_store.Payables:N0}";
    }

    void Seed() // داده‌ی نمونه برای تست سریع
    {
        _store.AddProduct("برنج ۱۰ کیلویی", 450_000, 520_000, 20);
        _store.AddProduct("روغن مایع", 180_000, 210_000, 15);
        _store.AddProduct("چای", 90_000, 110_000, 30);
        _store.AddParty("علی رضایی (مشتری)", "09120000001");
        _store.AddParty("شرکت پخش نمونه (تامین‌کننده)", "02100000000");
    }
}
