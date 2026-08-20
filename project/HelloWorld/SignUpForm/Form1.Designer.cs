namespace SignUpForm
{
    partial class Form1
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
            signUpbotton = new Button();
            label1 = new Label();
            femaleRadio = new RadioButton();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lastNameTextBox = new TextBox();
            ageTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            maleRadio = new RadioButton();
            emailRadio = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // signUpbotton
            // 
            signUpbotton.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpbotton.Location = new Point(169, 269);
            signUpbotton.Margin = new Padding(2, 1, 2, 1);
            signUpbotton.Name = "signUpbotton";
            signUpbotton.Size = new Size(275, 43);
            signUpbotton.TabIndex = 4;
            signUpbotton.Text = "Sign Up";
            signUpbotton.UseVisualStyleBackColor = true;
            signUpbotton.Click += signUpbotton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 37);
            label1.TabIndex = 0;
            label1.Text = "please enter your information";
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Font = new Font("Segoe UI", 13.875F);
            femaleRadio.Location = new Point(404, 197);
            femaleRadio.Margin = new Padding(2, 1, 2, 1);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(87, 29);
            femaleRadio.TabIndex = 6;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "female";
            femaleRadio.UseVisualStyleBackColor = true;
            femaleRadio.CheckedChanged += GenderRadio_CheckedChanged;
            femaleRadio.KeyDown += MoveToNextControl;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(159, 55);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(396, 36);
            nameTextBox.TabIndex = 0;
            nameTextBox.KeyDown += MoveToNextControl;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 4;
            label3.Text = "Lastname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 190);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 37);
            label4.TabIndex = 4;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 145);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 37);
            label5.TabIndex = 4;
            label5.Text = "Phone number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(190, 193);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 37);
            label6.TabIndex = 9;
            label6.Text = "Gender:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(159, 101);
            lastNameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(396, 36);
            lastNameTextBox.TabIndex = 1;
            lastNameTextBox.KeyDown += MoveToNextControl;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTextBox.Location = new Point(93, 193);
            ageTextBox.Margin = new Padding(2, 1, 2, 1);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(76, 36);
            ageTextBox.TabIndex = 3;
            ageTextBox.KeyDown += MoveToNextControl;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberTextBox.Location = new Point(230, 148);
            phoneNumberTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(325, 36);
            phoneNumberTextBox.TabIndex = 2;
            phoneNumberTextBox.TextChanged += textBox4_TextChanged;
            phoneNumberTextBox.KeyDown += MoveToNextControl;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Font = new Font("Segoe UI", 13.875F);
            maleRadio.Location = new Point(313, 197);
            maleRadio.Margin = new Padding(2, 1, 2, 1);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(71, 29);
            maleRadio.TabIndex = 5;
            maleRadio.TabStop = true;
            maleRadio.Text = "male";
            maleRadio.UseVisualStyleBackColor = true;
            maleRadio.CheckedChanged += GenderRadio_CheckedChanged;
            maleRadio.KeyDown += MoveToNextControl;
            // 
            // emailRadio
            // 
            emailRadio.AutoSize = true;
            emailRadio.Font = new Font("Segoe UI", 13.875F);
            emailRadio.Location = new Point(517, 197);
            emailRadio.Margin = new Padding(2, 1, 2, 1);
            emailRadio.Name = "emailRadio";
            emailRadio.Size = new Size(76, 29);
            emailRadio.TabIndex = 7;
            emailRadio.TabStop = true;
            emailRadio.Text = "email";
            emailRadio.UseVisualStyleBackColor = true;
            emailRadio.CheckedChanged += GenderRadio_CheckedChanged;
            emailRadio.KeyDown += MoveToNextControl;
            // 
            // button1
            // 
            button1.Location = new Point(480, 230);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 10;
            button1.Text = "clear gender";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 317);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(maleRadio);
            Controls.Add(emailRadio);
            Controls.Add(femaleRadio);
            Controls.Add(label1);
            Controls.Add(signUpbotton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUpbotton;
        private Label label1;
        private RadioButton femaleRadio;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox lastNameTextBox;
        private TextBox ageTextBox;
        private TextBox phoneNumberTextBox;
        private RadioButton maleRadio;
        private RadioButton emailRadio;
        private Button button1;
    }
}