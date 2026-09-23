using ShopFirst.Forms;

namespace ShopFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm ProductForm = new AddProductForm();
            ProductForm.Show();
            this.Hide();
        }
    }
}
