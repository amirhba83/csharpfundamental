namespace SignUpForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLable = new Label();
            nameTextBox = new TextBox();
            LastNameLable = new Label();
            lastNameTextBox = new TextBox();
            PhoneNumberLable = new Label();
            phoneTextBox = new TextBox();
            AdressLable = new Label();
            adressTextBox = new TextBox();
            rgisterButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Location = new Point(23, 26);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(78, 32);
            NameLable.TabIndex = 0;
            NameLable.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(154, 23);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(855, 39);
            nameTextBox.TabIndex = 1;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(23, 71);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(119, 32);
            LastNameLable.TabIndex = 0;
            LastNameLable.Text = "LastName";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(154, 68);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(855, 39);
            lastNameTextBox.TabIndex = 1;
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.Location = new Point(23, 116);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(170, 32);
            PhoneNumberLable.TabIndex = 0;
            PhoneNumberLable.Text = "PhoneNumber";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(199, 113);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(810, 39);
            phoneTextBox.TabIndex = 1;
            // 
            // AdressLable
            // 
            AdressLable.AutoSize = true;
            AdressLable.Location = new Point(23, 161);
            AdressLable.Name = "AdressLable";
            AdressLable.Size = new Size(84, 32);
            AdressLable.TabIndex = 0;
            AdressLable.Text = "Adress";
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(154, 158);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(855, 39);
            adressTextBox.TabIndex = 1;
            // 
            // rgisterButton
            // 
            rgisterButton.Location = new Point(154, 222);
            rgisterButton.Name = "rgisterButton";
            rgisterButton.Size = new Size(751, 79);
            rgisterButton.TabIndex = 2;
            rgisterButton.Text = "register";
            rgisterButton.UseVisualStyleBackColor = true;
            rgisterButton.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1004, 624);
            dataGridView1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 985);
            Controls.Add(dataGridView1);
            Controls.Add(rgisterButton);
            Controls.Add(adressTextBox);
            Controls.Add(AdressLable);
            Controls.Add(phoneTextBox);
            Controls.Add(PhoneNumberLable);
            Controls.Add(lastNameTextBox);
            Controls.Add(LastNameLable);
            Controls.Add(nameTextBox);
            Controls.Add(NameLable);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLable;
        private TextBox nameTextBox;
        private Label LastNameLable;
        private TextBox lastNameTextBox;
        private Label PhoneNumberLable;
        private TextBox phoneTextBox;
        private Label AdressLable;
        private TextBox adressTextBox;
        private Button rgisterButton;
        private DataGridView dataGridView1;
    }
}