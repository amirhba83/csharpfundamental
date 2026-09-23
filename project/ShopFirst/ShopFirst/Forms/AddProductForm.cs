using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopFirst.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            productIdLable.Text = Product._nextId.ToString();

        }

        private void productIdLable_Click(object sender, EventArgs e)
        {

        }
    }
}
