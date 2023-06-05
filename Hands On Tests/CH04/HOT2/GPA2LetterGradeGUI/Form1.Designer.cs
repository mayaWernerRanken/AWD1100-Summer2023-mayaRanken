namespace GPA2LetterGradeGUI
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
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResult = new Label();
            txtNumGrade = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(137, 285);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(194, 78);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(417, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(194, 78);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(697, 285);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 78);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(404, 425);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 31);
            lblResult.TabIndex = 3;
            // 
            // txtNumGrade
            // 
            txtNumGrade.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumGrade.Location = new Point(410, 53);
            txtNumGrade.Name = "txtNumGrade";
            txtNumGrade.Size = new Size(209, 38);
            txtNumGrade.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 56);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 5;
            label1.Text = "Numeric Grade:";
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            CancelButton = btnClear;
            ClientSize = new Size(1029, 488);
            Controls.Add(label1);
            Controls.Add(txtNumGrade);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblResult;
        private TextBox txtNumGrade;
        private Label label1;
    }
}