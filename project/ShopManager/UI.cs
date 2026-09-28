namespace ShopManager;

static class UI
{
    public static ComboBox Combo() => new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 160, DisplayMember = "Name" };

    public static NumericUpDown Num(int value, int min) => new()
    { Minimum = min, Maximum = 1_000_000_000, Value = value, ThousandsSeparator = true, Width = 110 };

    public static DataGridView Grid() => new()
    {
        Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, RowHeadersVisible = false,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, SelectionMode = DataGridViewSelectionMode.FullRowSelect
    };

    public static FlowLayoutPanel Flow(DockStyle dock = DockStyle.Top) => new()
    { Dock = dock, AutoSize = true, WrapContents = true, Padding = new Padding(6) };

    public static void Add(FlowLayoutPanel f, string label, Control c)
    {
        f.Controls.Add(new Label { Text = label, AutoSize = true, Margin = new Padding(6, 8, 2, 0) });
        f.Controls.Add(c);
    }

    public static Button Button(string text, EventHandler onClick)
    {
        var b = new Button { Text = text, AutoSize = true, Margin = new Padding(8, 3, 3, 3) };
        b.Click += onClick;
        return b;
    }

    public static void Try(Action action)
    {
        try { action(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
}
