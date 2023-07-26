namespace HOT6_EX1
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
            groupBox1 = new GroupBox();
            btnCreate = new Button();
            rdoLongLoan = new RadioButton();
            rdoShortLoan = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            txtName = new TextBox();
            groupBox2 = new GroupBox();
            lblInterestResult = new Label();
            btnExit = new Button();
            btnClear = new Button();
            lblPayment = new Label();
            btnPay = new Button();
            lblAmount = new Label();
            lblName = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(rdoLongLoan);
            groupBox1.Controls.Add(rdoShortLoan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtName);
            groupBox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(332, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Loan";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(6, 194);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Loan";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // rdoLongLoan
            // 
            rdoLongLoan.AutoSize = true;
            rdoLongLoan.Location = new Point(68, 154);
            rdoLongLoan.Margin = new Padding(3, 4, 3, 4);
            rdoLongLoan.Name = "rdoLongLoan";
            rdoLongLoan.Size = new Size(137, 24);
            rdoLongLoan.TabIndex = 6;
            rdoLongLoan.TabStop = true;
            rdoLongLoan.Text = "Long-Term Loan";
            rdoLongLoan.UseVisualStyleBackColor = true;
            // 
            // rdoShortLoan
            // 
            rdoShortLoan.AutoSize = true;
            rdoShortLoan.Location = new Point(68, 124);
            rdoShortLoan.Margin = new Padding(3, 4, 3, 4);
            rdoShortLoan.Name = "rdoShortLoan";
            rdoShortLoan.Size = new Size(138, 24);
            rdoShortLoan.TabIndex = 5;
            rdoShortLoan.TabStop = true;
            rdoShortLoan.Text = "Short-Term Loan";
            rdoShortLoan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 126);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 76);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(68, 74);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(257, 27);
            txtAmount.TabIndex = 3;
            txtAmount.Tag = "Loan amount";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(68, 41);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 27);
            txtName.TabIndex = 1;
            txtName.Tag = "Loan name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblInterestResult);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(lblPayment);
            groupBox2.Controls.Add(btnPay);
            groupBox2.Controls.Add(lblAmount);
            groupBox2.Controls.Add(lblName);
            groupBox2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(17, 249);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(332, 244);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage Loan";
            // 
            // lblInterestResult
            // 
            lblInterestResult.AutoSize = true;
            lblInterestResult.Location = new Point(5, 159);
            lblInterestResult.Name = "lblInterestResult";
            lblInterestResult.Size = new Size(0, 20);
            lblInterestResult.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(231, 89);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(131, 89);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(5, 139);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(0, 20);
            lblPayment.TabIndex = 5;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(5, 89);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(108, 29);
            btnPay.TabIndex = 2;
            btnPay.Text = "Make Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(5, 56);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(0, 20);
            lblAmount.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(5, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 31);
            lblName.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(364, 505);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Loan";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCreate;
        private RadioButton rdoLongLoan;
        private RadioButton rdoShortLoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAmount;
        private TextBox txtName;
        private GroupBox groupBox2;
        private Label lblName;
        private Button btnPay;
        private Label lblAmount;
        private Label lblPayment;
        private Button btnExit;
        private Button btnClear;
        private Label lblInterestResult;
    }
}