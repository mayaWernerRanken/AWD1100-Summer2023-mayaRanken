namespace HOT3GUILists
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
            btnFirstName = new Button();
            btnLastName = new Button();
            btnSalary = new Button();
            txtInput = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSalary = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFirstName
            // 
            btnFirstName.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirstName.Location = new Point(404, 95);
            btnFirstName.Name = "btnFirstName";
            btnFirstName.Size = new Size(223, 64);
            btnFirstName.TabIndex = 0;
            btnFirstName.Text = "Search First Name";
            btnFirstName.UseVisualStyleBackColor = true;
            btnFirstName.Click += button1_Click;
            // 
            // btnLastName
            // 
            btnLastName.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLastName.Location = new Point(404, 165);
            btnLastName.Name = "btnLastName";
            btnLastName.Size = new Size(223, 64);
            btnLastName.TabIndex = 1;
            btnLastName.Text = "Search Last Name";
            btnLastName.UseVisualStyleBackColor = true;
            btnLastName.Click += btnLastName_Click;
            // 
            // btnSalary
            // 
            btnSalary.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalary.Location = new Point(404, 235);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(223, 64);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Search Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(52, 57);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(346, 38);
            txtInput.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(52, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 64);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(228, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 64);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(52, 125);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(346, 34);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(52, 195);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(346, 34);
            txtLastName.TabIndex = 7;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(52, 265);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(346, 34);
            txtSalary.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(372, 31);
            label1.TabIndex = 9;
            label1.Text = "Enter first name, last name, or salary";
            // 
            // Form1
            // 
            AcceptButton = btnClear;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(678, 407);
            Controls.Add(label1);
            Controls.Add(txtSalary);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtInput);
            Controls.Add(btnSalary);
            Controls.Add(btnLastName);
            Controls.Add(btnFirstName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Address Book 1 - Arrays";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFirstName;
        private Button btnLastName;
        private Button btnSalary;
        private TextBox txtInput;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSalary;
        private Label label1;
    }
}