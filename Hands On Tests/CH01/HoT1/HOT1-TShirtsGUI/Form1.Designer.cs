namespace HOT1_TShirtsGUI
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
            txtName = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtState = new TextBox();
            label4 = new Label();
            txtZip = new TextBox();
            label5 = new Label();
            txtShirtNum = new TextBox();
            label6 = new Label();
            txtSubTotal = new TextBox();
            label7 = new Label();
            txtTaxTotal = new TextBox();
            label8 = new Label();
            txtGrandTotal = new TextBox();
            label9 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(343, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 39);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(343, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 39);
            txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtCity.Location = new Point(343, 154);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(204, 39);
            txtCity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 157);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 4;
            label3.Text = "City:";
            // 
            // txtState
            // 
            txtState.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtState.Location = new Point(343, 215);
            txtState.Name = "txtState";
            txtState.Size = new Size(204, 39);
            txtState.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 218);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 6;
            label4.Text = "State:";
            // 
            // txtZip
            // 
            txtZip.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtZip.Location = new Point(343, 276);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(204, 39);
            txtZip.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 279);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 8;
            label5.Text = "Zip Code:";
            // 
            // txtShirtNum
            // 
            txtShirtNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtShirtNum.Location = new Point(343, 337);
            txtShirtNum.Name = "txtShirtNum";
            txtShirtNum.Size = new Size(204, 39);
            txtShirtNum.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 340);
            label6.Name = "label6";
            label6.Size = new Size(242, 32);
            label6.TabIndex = 10;
            label6.Text = "Number of T-Shirts:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(343, 398);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(204, 39);
            txtSubTotal.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(89, 401);
            label7.Name = "label7";
            label7.Size = new Size(117, 32);
            label7.TabIndex = 12;
            label7.Text = "Subtotal:";
            // 
            // txtTaxTotal
            // 
            txtTaxTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTaxTotal.Location = new Point(343, 459);
            txtTaxTotal.Name = "txtTaxTotal";
            txtTaxTotal.ReadOnly = true;
            txtTaxTotal.Size = new Size(204, 39);
            txtTaxTotal.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(89, 462);
            label8.Name = "label8";
            label8.Size = new Size(170, 32);
            label8.TabIndex = 14;
            label8.Text = "Taxable Total:";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtGrandTotal.Location = new Point(343, 520);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(204, 39);
            txtGrandTotal.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(89, 523);
            label9.Name = "label9";
            label9.Size = new Size(154, 32);
            label9.TabIndex = 16;
            label9.Text = "Grand Total:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(88, 603);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 36);
            btnCalculate.TabIndex = 18;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(257, 603);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 36);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(426, 603);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 36);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(636, 676);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtGrandTotal);
            Controls.Add(label9);
            Controls.Add(txtTaxTotal);
            Controls.Add(label8);
            Controls.Add(txtSubTotal);
            Controls.Add(label7);
            Controls.Add(txtShirtNum);
            Controls.Add(label6);
            Controls.Add(txtZip);
            Controls.Add(label5);
            Controls.Add(txtState);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "T-Shirt GUI C# Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtState;
        private Label label4;
        private TextBox txtZip;
        private Label label5;
        private TextBox txtShirtNum;
        private Label label6;
        private TextBox txtSubTotal;
        private Label label7;
        private TextBox txtTaxTotal;
        private Label label8;
        private TextBox txtGrandTotal;
        private Label label9;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}