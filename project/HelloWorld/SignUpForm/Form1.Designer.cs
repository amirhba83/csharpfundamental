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
            SuspendLayout();
            // 
            // signUpbotton
            // 
            signUpbotton.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpbotton.Location = new Point(314, 573);
            signUpbotton.Name = "signUpbotton";
            signUpbotton.Size = new Size(510, 91);
            signUpbotton.TabIndex = 0;
            signUpbotton.Text = "Sign Up";
            signUpbotton.UseVisualStyleBackColor = true;
            signUpbotton.Click += signUpbotton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(725, 71);
            label1.TabIndex = 1;
            label1.Text = "please enter your information";
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Font = new Font("Segoe UI", 13.875F);
            femaleRadio.Location = new Point(751, 420);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(163, 54);
            femaleRadio.TabIndex = 2;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "female";
            femaleRadio.UseVisualStyleBackColor = true;
            femaleRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(295, 117);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(732, 65);
            nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(182, 71);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(264, 71);
            label3.TabIndex = 4;
            label3.Text = "Lastname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 405);
            label4.Name = "label4";
            label4.Size = new Size(134, 71);
            label4.TabIndex = 4;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(388, 71);
            label5.TabIndex = 4;
            label5.Text = "Phone number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 411);
            label6.Name = "label6";
            label6.Size = new Size(212, 71);
            label6.TabIndex = 4;
            label6.Text = "Gender:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(295, 215);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(732, 65);
            lastNameTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTextBox.Location = new Point(173, 411);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(137, 65);
            ageTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberTextBox.Location = new Point(427, 316);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(600, 65);
            phoneNumberTextBox.TabIndex = 3;
            phoneNumberTextBox.TextChanged += textBox4_TextChanged;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Font = new Font("Segoe UI", 13.875F);
            maleRadio.Location = new Point(581, 420);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(132, 54);
            maleRadio.TabIndex = 2;
            maleRadio.TabStop = true;
            maleRadio.Text = "male";
            maleRadio.UseVisualStyleBackColor = true;
            maleRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // emailRadio
            // 
            emailRadio.AutoSize = true;
            emailRadio.Font = new Font("Segoe UI", 13.875F);
            emailRadio.Location = new Point(961, 420);
            emailRadio.Name = "emailRadio";
            emailRadio.Size = new Size(141, 54);
            emailRadio.TabIndex = 2;
            emailRadio.TabStop = true;
            emailRadio.Text = "email";
            emailRadio.UseVisualStyleBackColor = true;
            emailRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 676);
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
    }
}