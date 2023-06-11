namespace HOT3GUIArray
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
            txtSalary = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            txtInput = new TextBox();
            btnSalary = new Button();
            btnLastName = new Button();
            btnFirstName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 46);
            label1.Name = "label1";
            label1.Size = new Size(372, 31);
            label1.TabIndex = 19;
            label1.Text = "Enter first name, last name, or salary";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(66, 288);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(346, 34);
            txtSalary.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(66, 218);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(346, 34);
            txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(66, 148);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(346, 34);
            txtFirstName.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(242, 328);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 64);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(66, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 64);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(66, 80);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(346, 38);
            txtInput.TabIndex = 13;
            // 
            // btnSalary
            // 
            btnSalary.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalary.Location = new Point(418, 258);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(223, 64);
            btnSalary.TabIndex = 12;
            btnSalary.Text = "Search Salary";
            btnSalary.UseVisualStyleBackColor = true;
            // 
            // btnLastName
            // 
            btnLastName.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLastName.Location = new Point(418, 188);
            btnLastName.Name = "btnLastName";
            btnLastName.Size = new Size(223, 64);
            btnLastName.TabIndex = 11;
            btnLastName.Text = "Search Last Name";
            btnLastName.UseVisualStyleBackColor = true;
            // 
            // btnFirstName
            // 
            btnFirstName.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirstName.Location = new Point(418, 118);
            btnFirstName.Name = "btnFirstName";
            btnFirstName.Size = new Size(223, 64);
            btnFirstName.TabIndex = 10;
            btnFirstName.Text = "Search First Name";
            btnFirstName.UseVisualStyleBackColor = true;
            btnFirstName.Click += btnFirstName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 439);
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalary;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtInput;
        private Button btnSalary;
        private Button btnLastName;
        private Button btnFirstName;
    }
}