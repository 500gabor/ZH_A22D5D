namespace ZH_A22D5D
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stocksButton = new System.Windows.Forms.Button();
            this.addstocksButton = new System.Windows.Forms.Button();
            this.portfolioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(154, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 454);
            this.panel1.TabIndex = 0;
            // 
            // stocksButton
            // 
            this.stocksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stocksButton.Location = new System.Drawing.Point(12, 40);
            this.stocksButton.Name = "stocksButton";
            this.stocksButton.Size = new System.Drawing.Size(108, 23);
            this.stocksButton.TabIndex = 0;
            this.stocksButton.Text = "Available Stocks";
            this.stocksButton.UseVisualStyleBackColor = true;
            this.stocksButton.Click += new System.EventHandler(this.stocksButton_Click);
            // 
            // addstocksButton
            // 
            this.addstocksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addstocksButton.Location = new System.Drawing.Point(12, 228);
            this.addstocksButton.Name = "addstocksButton";
            this.addstocksButton.Size = new System.Drawing.Size(108, 23);
            this.addstocksButton.TabIndex = 1;
            this.addstocksButton.Text = "Stock Manager";
            this.addstocksButton.UseVisualStyleBackColor = true;
            this.addstocksButton.Click += new System.EventHandler(this.addstocksButton_Click);
            // 
            // portfolioButton
            // 
            this.portfolioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.portfolioButton.Location = new System.Drawing.Point(12, 404);
            this.portfolioButton.Name = "portfolioButton";
            this.portfolioButton.Size = new System.Drawing.Size(108, 23);
            this.portfolioButton.TabIndex = 2;
            this.portfolioButton.Text = "Portfolios";
            this.portfolioButton.UseVisualStyleBackColor = true;
            this.portfolioButton.Click += new System.EventHandler(this.portfolioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 478);
            this.Controls.Add(this.portfolioButton);
            this.Controls.Add(this.addstocksButton);
            this.Controls.Add(this.stocksButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button stocksButton;
        private Button addstocksButton;
        private Button portfolioButton;
    }
}