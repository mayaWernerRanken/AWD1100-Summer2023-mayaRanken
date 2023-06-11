namespace Factorial
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
            txtNum = new TextBox();
            txtFact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(139, 34);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(75, 27);
            txtNum.TabIndex = 0;
            // 
            // txtFact
            // 
            txtFact.Location = new Point(139, 67);
            txtFact.Name = "txtFact";
            txtFact.Size = new Size(194, 27);
            txtFact.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Factorial:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(139, 112);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(239, 112);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(381, 170);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFact);
            Controls.Add(txtNum);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private TextBox txtFact;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Button btnExit;
    }
}