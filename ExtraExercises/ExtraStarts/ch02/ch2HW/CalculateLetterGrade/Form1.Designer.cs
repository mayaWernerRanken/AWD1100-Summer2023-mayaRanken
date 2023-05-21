namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            btnExit = new Button();
            label1 = new Label();
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(69, 120);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 35);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(282, 120);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 35);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "&Number Grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(228, 38);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(168, 27);
            txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(228, 71);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(168, 27);
            txtLetterGrade.TabIndex = 5;
            txtLetterGrade.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Letter Grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCalculateGrade
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(465, 180);
            Controls.Add(label2);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "frmCalculateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label label1;
        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Label label2;
    }
}