namespace ZH_A22D5D
{
    partial class PortfolioManagerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.portfoliosFilterTextBox = new System.Windows.Forms.TextBox();
            this.stockfilterTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.portfoliosListBox = new System.Windows.Forms.ListBox();
            this.connectionsListBox = new System.Windows.Forms.ListBox();
            this.stocksListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.portfoliosFilterTextBox);
            this.panel1.Controls.Add(this.stockfilterTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.portfoliosListBox);
            this.panel1.Controls.Add(this.connectionsListBox);
            this.panel1.Controls.Add(this.stocksListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 388);
            this.panel1.TabIndex = 0;
            // 
            // portfoliosFilterTextBox
            // 
            this.portfoliosFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.portfoliosFilterTextBox.Location = new System.Drawing.Point(509, 296);
            this.portfoliosFilterTextBox.Name = "portfoliosFilterTextBox";
            this.portfoliosFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.portfoliosFilterTextBox.TabIndex = 5;
            this.portfoliosFilterTextBox.TextChanged += new System.EventHandler(this.portfoliosFilterTextBox_TextChanged);
            // 
            // stockfilterTextBox
            // 
            this.stockfilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockfilterTextBox.Location = new System.Drawing.Point(42, 296);
            this.stockfilterTextBox.Name = "stockfilterTextBox";
            this.stockfilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.stockfilterTextBox.TabIndex = 4;
            this.stockfilterTextBox.TextChanged += new System.EventHandler(this.stockfilterTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(177, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // portfoliosListBox
            // 
            this.portfoliosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portfoliosListBox.FormattingEnabled = true;
            this.portfoliosListBox.ItemHeight = 15;
            this.portfoliosListBox.Location = new System.Drawing.Point(489, 58);
            this.portfoliosListBox.Name = "portfoliosListBox";
            this.portfoliosListBox.Size = new System.Drawing.Size(120, 199);
            this.portfoliosListBox.TabIndex = 2;
            this.portfoliosListBox.SelectedIndexChanged += new System.EventHandler(this.portfoliosListBox_SelectedIndexChanged);
            // 
            // connectionsListBox
            // 
            this.connectionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsListBox.FormattingEnabled = true;
            this.connectionsListBox.ItemHeight = 15;
            this.connectionsListBox.Location = new System.Drawing.Point(272, 58);
            this.connectionsListBox.Name = "connectionsListBox";
            this.connectionsListBox.Size = new System.Drawing.Size(120, 199);
            this.connectionsListBox.TabIndex = 1;
            // 
            // stocksListBox
            // 
            this.stocksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stocksListBox.FormattingEnabled = true;
            this.stocksListBox.ItemHeight = 15;
            this.stocksListBox.Location = new System.Drawing.Point(42, 58);
            this.stocksListBox.Name = "stocksListBox";
            this.stocksListBox.Size = new System.Drawing.Size(120, 199);
            this.stocksListBox.TabIndex = 0;
            // 
            // PortfolioManagerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PortfolioManagerUserControl";
            this.Size = new System.Drawing.Size(687, 388);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox portfoliosListBox;
        private ListBox connectionsListBox;
        private ListBox stocksListBox;
        private TextBox stockfilterTextBox;
        private Button button1;
        private TextBox portfoliosFilterTextBox;
    }
}
