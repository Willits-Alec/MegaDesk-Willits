namespace MegaDesk_Willits
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addWidth = new System.Windows.Forms.NumericUpDown();
            this.GetQuote = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ServiceMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.shippingType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addDepth = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // addWidth
            // 
            this.addWidth.Location = new System.Drawing.Point(177, 141);
            this.addWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.addWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.addWidth.Name = "addWidth";
            this.addWidth.Size = new System.Drawing.Size(137, 26);
            this.addWidth.TabIndex = 1;
            this.addWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // GetQuote
            // 
            this.GetQuote.Location = new System.Drawing.Point(88, 340);
            this.GetQuote.Name = "GetQuote";
            this.GetQuote.Size = new System.Drawing.Size(246, 76);
            this.GetQuote.TabIndex = 2;
            this.GetQuote.Text = "Get Quote";
            this.GetQuote.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(464, 340);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(246, 76);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ServiceMaterial
            // 
            this.ServiceMaterial.FormattingEnabled = true;
            this.ServiceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.ServiceMaterial.Location = new System.Drawing.Point(589, 184);
            this.ServiceMaterial.Name = "ServiceMaterial";
            this.ServiceMaterial.Size = new System.Drawing.Size(125, 28);
            this.ServiceMaterial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Quote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of drawers";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(589, 141);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // shippingType
            // 
            this.shippingType.FormattingEnabled = true;
            this.shippingType.Location = new System.Drawing.Point(589, 229);
            this.shippingType.Name = "shippingType";
            this.shippingType.Size = new System.Drawing.Size(125, 28);
            this.shippingType.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delivery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Depth";
            // 
            // addDepth
            // 
            this.addDepth.Location = new System.Drawing.Point(177, 194);
            this.addDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.addDepth.Name = "addDepth";
            this.addDepth.Size = new System.Drawing.Size(137, 26);
            this.addDepth.TabIndex = 13;
            this.addDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 26);
            this.textBox1.TabIndex = 14;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addDepth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shippingType);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServiceMaterial);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.GetQuote);
            this.Controls.Add(this.addWidth);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown addWidth;
        private System.Windows.Forms.Button GetQuote;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox ServiceMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox shippingType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown addDepth;
        private System.Windows.Forms.TextBox textBox1;
    }
}