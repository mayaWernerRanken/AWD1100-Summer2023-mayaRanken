namespace HOT6_EX1
{
    partial class PasswordCracker
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
            btnCrack = new Button();
            txtHash = new TextBox();
            label1 = new Label();
            lblPassword = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCrack
            // 
            btnCrack.Location = new Point(447, 86);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(94, 29);
            btnCrack.TabIndex = 2;
            btnCrack.Text = "Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // txtHash
            // 
            txtHash.Location = new Point(92, 88);
            txtHash.Name = "txtHash";
            txtHash.Size = new Size(329, 27);
            txtHash.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 65);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "MD5 Hash";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(92, 143);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 20);
            lblPassword.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(447, 121);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PasswordCracker
            // 
            AcceptButton = btnCrack;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(632, 209);
            Controls.Add(btnExit);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(txtHash);
            Controls.Add(btnCrack);
            Name = "PasswordCracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrack;
        private TextBox txtHash;
        private Label label1;
        private Label lblPassword;
        private Button btnExit;
    }
}