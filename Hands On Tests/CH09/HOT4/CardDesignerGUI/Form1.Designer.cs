namespace CardDesignerGUI
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
            cboOccasion = new ComboBox();
            cboStyle = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            chkEnvelope = new CheckBox();
            chkStamp = new CheckBox();
            chkCustom = new CheckBox();
            rtbCustom = new RichTextBox();
            lblCost = new Label();
            btnCalculate = new Button();
            grpOptions = new GroupBox();
            picOccasion = new PictureBox();
            btnHome = new Button();
            grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOccasion).BeginInit();
            SuspendLayout();
            // 
            // cboOccasion
            // 
            cboOccasion.FormattingEnabled = true;
            cboOccasion.Location = new Point(151, 37);
            cboOccasion.Name = "cboOccasion";
            cboOccasion.Size = new Size(152, 23);
            cboOccasion.TabIndex = 0;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(151, 77);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(152, 23);
            cboStyle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 2;
            label1.Text = "Occasion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 80);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 3;
            label2.Text = "Style:";
            // 
            // chkEnvelope
            // 
            chkEnvelope.AutoSize = true;
            chkEnvelope.Location = new Point(6, 22);
            chkEnvelope.Name = "chkEnvelope";
            chkEnvelope.Size = new Size(112, 19);
            chkEnvelope.TabIndex = 4;
            chkEnvelope.Text = "Envelope ($0.25)";
            chkEnvelope.UseVisualStyleBackColor = true;
            // 
            // chkStamp
            // 
            chkStamp.AutoSize = true;
            chkStamp.Location = new Point(6, 47);
            chkStamp.Name = "chkStamp";
            chkStamp.Size = new Size(98, 19);
            chkStamp.TabIndex = 5;
            chkStamp.Text = "Stamp ($0.50)";
            chkStamp.UseVisualStyleBackColor = true;
            // 
            // chkCustom
            // 
            chkCustom.AutoSize = true;
            chkCustom.Location = new Point(6, 72);
            chkCustom.Name = "chkCustom";
            chkCustom.Size = new Size(155, 19);
            chkCustom.TabIndex = 6;
            chkCustom.Text = "Custom Message ($0.30)";
            chkCustom.UseVisualStyleBackColor = true;
            // 
            // rtbCustom
            // 
            rtbCustom.Location = new Point(46, 218);
            rtbCustom.Name = "rtbCustom";
            rtbCustom.Size = new Size(257, 160);
            rtbCustom.TabIndex = 7;
            rtbCustom.Text = "";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.Location = new Point(46, 383);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(47, 21);
            lblCost.TabIndex = 8;
            lblCost.Text = "Cost:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(151, 384);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(chkEnvelope);
            grpOptions.Controls.Add(chkStamp);
            grpOptions.Controls.Add(chkCustom);
            grpOptions.Location = new Point(46, 100);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(257, 112);
            grpOptions.TabIndex = 10;
            grpOptions.TabStop = false;
            // 
            // picOccasion
            // 
            picOccasion.Location = new Point(309, 100);
            picOccasion.Name = "picOccasion";
            picOccasion.Size = new Size(318, 278);
            picOccasion.TabIndex = 11;
            picOccasion.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(228, 384);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 438);
            Controls.Add(btnHome);
            Controls.Add(picOccasion);
            Controls.Add(grpOptions);
            Controls.Add(btnCalculate);
            Controls.Add(lblCost);
            Controls.Add(rtbCustom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboStyle);
            Controls.Add(cboOccasion);
            Name = "Form1";
            Text = "Form1";
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOccasion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboOccasion;
        private ComboBox cboStyle;
        private Label label1;
        private Label label2;
        private CheckBox chkEnvelope;
        private CheckBox chkStamp;
        private CheckBox chkCustom;
        private RichTextBox rtbCustom;
        private Label lblCost;
        private Button btnCalculate;
        private GroupBox grpOptions;
        private PictureBox picOccasion;
        private Button btnHome;
    }
}