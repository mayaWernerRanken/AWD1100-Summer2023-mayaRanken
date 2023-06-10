namespace ScoreCalculator
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
            txtScore = new TextBox();
            txtScoreTotal = new TextBox();
            txtScoreNum = new TextBox();
            txtAverage = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.Location = new Point(125, 23);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(57, 23);
            txtScore.TabIndex = 0;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(125, 52);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(57, 23);
            txtScoreTotal.TabIndex = 1;
            // 
            // txtScoreNum
            // 
            txtScoreNum.Location = new Point(125, 81);
            txtScoreNum.Name = "txtScoreNum";
            txtScoreNum.ReadOnly = true;
            txtScoreNum.Size = new Size(57, 23);
            txtScoreNum.TabIndex = 2;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(125, 110);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(57, 23);
            txtAverage.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(198, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(107, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(198, 146);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 55);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Score total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 84);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "Score count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 113);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Average:";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(304, 199);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreNum);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore;
        private TextBox txtScoreTotal;
        private TextBox txtScoreNum;
        private TextBox txtAverage;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}