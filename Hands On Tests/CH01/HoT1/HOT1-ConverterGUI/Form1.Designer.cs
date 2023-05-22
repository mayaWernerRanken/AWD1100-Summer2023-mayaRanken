namespace HOT1_ConverterGUI
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
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtInches = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(21, 96);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(87, 27);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(118, 96);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 27);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(215, 96);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 27);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtInches
            // 
            txtInches.Location = new Point(21, 48);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(135, 23);
            txtInches.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Distance in inches";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(21, 149);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 173);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtInches);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtInches;
        private Label label1;
        private Label lblResult;
    }
}