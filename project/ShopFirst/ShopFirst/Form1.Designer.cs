namespace ShopFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addProductButton = new Button();
            addPartyButton = new Button();
            productManagerButton = new Button();
            partyManagerButton = new Button();
            exitButton = new Button();
            addInvoiceButton = new Button();
            invoiceManagerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(883, 72);
            label1.TabIndex = 0;
            label1.Text = "عملیات مورد نظر خود را اننتخاب نمایید";
            label1.Click += label1_Click;
            // 
            // addProductButton
            // 
            addProductButton.Font = new Font("Segoe UI", 15F);
            addProductButton.Location = new Point(313, 147);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(281, 130);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "اضافه کردن کالا";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // addPartyButton
            // 
            addPartyButton.Font = new Font("Segoe UI", 15F);
            addPartyButton.Location = new Point(734, 147);
            addPartyButton.Name = "addPartyButton";
            addPartyButton.Size = new Size(281, 130);
            addPartyButton.TabIndex = 2;
            addPartyButton.Text = "اضافه کردن طرف حساب";
            addPartyButton.UseVisualStyleBackColor = true;
            // 
            // productManagerButton
            // 
            productManagerButton.Font = new Font("Segoe UI", 15F);
            productManagerButton.Location = new Point(313, 608);
            productManagerButton.Name = "productManagerButton";
            productManagerButton.Size = new Size(281, 130);
            productManagerButton.TabIndex = 3;
            productManagerButton.Text = "مشاهده محصولات";
            productManagerButton.UseVisualStyleBackColor = true;
            productManagerButton.Click += button3_Click;
            // 
            // partyManagerButton
            // 
            partyManagerButton.Font = new Font("Segoe UI", 15F);
            partyManagerButton.Location = new Point(734, 608);
            partyManagerButton.Name = "partyManagerButton";
            partyManagerButton.Size = new Size(281, 130);
            partyManagerButton.TabIndex = 4;
            partyManagerButton.Text = "طرف حساب ها ";
            partyManagerButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 15F);
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(8, 727);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 65);
            exitButton.TabIndex = 5;
            exitButton.Text = "خروج";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addInvoiceButton
            // 
            addInvoiceButton.Font = new Font("Segoe UI", 15F);
            addInvoiceButton.Location = new Point(313, 380);
            addInvoiceButton.Name = "addInvoiceButton";
            addInvoiceButton.Size = new Size(281, 130);
            addInvoiceButton.TabIndex = 3;
            addInvoiceButton.Text = "فاکتور";
            addInvoiceButton.UseVisualStyleBackColor = true;
            addInvoiceButton.Click += button3_Click;
            // 
            // invoiceManagerButton
            // 
            invoiceManagerButton.Font = new Font("Segoe UI", 15F);
            invoiceManagerButton.Location = new Point(734, 380);
            invoiceManagerButton.Name = "invoiceManagerButton";
            invoiceManagerButton.Size = new Size(281, 130);
            invoiceManagerButton.TabIndex = 4;
            invoiceManagerButton.Text = "مشاهده فاکتورها";
            invoiceManagerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 804);
            Controls.Add(exitButton);
            Controls.Add(invoiceManagerButton);
            Controls.Add(partyManagerButton);
            Controls.Add(addInvoiceButton);
            Controls.Add(productManagerButton);
            Controls.Add(addPartyButton);
            Controls.Add(addProductButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addProductButton;
        private Button addPartyButton;
        private Button productManagerButton;
        private Button partyManagerButton;
        private Button exitButton;
        private Button addInvoiceButton;
        private Button invoiceManagerButton;
    }
}
