namespace InterfaceDemo
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
            btnDemoChamps = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnDemoChamps
            // 
            btnDemoChamps.Location = new Point(278, 120);
            btnDemoChamps.Name = "btnDemoChamps";
            btnDemoChamps.Size = new Size(224, 142);
            btnDemoChamps.TabIndex = 0;
            btnDemoChamps.Text = "Demo Champions";
            btnDemoChamps.UseVisualStyleBackColor = true;
            btnDemoChamps.Click += btnDemoChamps_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(167, 265);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnDemoChamps);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDemoChamps;
        private Label lblResult;
    }
}