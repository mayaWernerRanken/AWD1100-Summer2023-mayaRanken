namespace HOT6_EX2
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
            txtIP = new TextBox();
            btnScan = new Button();
            label1 = new Label();
            lblCompName = new Label();
            lblIP = new Label();
            label4 = new Label();
            lblServices = new Label();
            SuspendLayout();
            // 
            // txtIP
            // 
            txtIP.Location = new Point(30, 35);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(318, 27);
            txtIP.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(354, 34);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(94, 29);
            btnScan.TabIndex = 1;
            btnScan.Text = "button1";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // lblCompName
            // 
            lblCompName.AutoSize = true;
            lblCompName.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompName.Location = new Point(30, 84);
            lblCompName.Name = "lblCompName";
            lblCompName.Size = new Size(102, 38);
            lblCompName.TabIndex = 3;
            lblCompName.Text = "label2";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(30, 122);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(51, 20);
            lblIP.TabIndex = 4;
            lblIP.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 177);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Location = new Point(30, 202);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(51, 20);
            lblServices.TabIndex = 6;
            lblServices.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 471);
            Controls.Add(lblServices);
            Controls.Add(label4);
            Controls.Add(lblIP);
            Controls.Add(lblCompName);
            Controls.Add(label1);
            Controls.Add(btnScan);
            Controls.Add(txtIP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIP;
        private Button btnScan;
        private Label label1;
        private Label lblCompName;
        private Label lblIP;
        private Label label4;
        private Label lblServices;
    }
}