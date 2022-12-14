namespace ZH_A22D5D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Closing", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void stocksButton_Click(object sender, EventArgs e)
        {
            StockDiagramUserControl stockDiagramUserControl = new StockDiagramUserControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(stockDiagramUserControl);
            stockDiagramUserControl.Dock = DockStyle.Fill;
        }

        private void addstocksButton_Click(object sender, EventArgs e)
        {
            AddStocksUserControl addStocksUserControl = new AddStocksUserControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(addStocksUserControl);
            addStocksUserControl.Dock = DockStyle.Fill;
        }

        private void portfolioButton_Click(object sender, EventArgs e)
        {
            PortfolioManagerUserControl portfolioManagerUserControl = new PortfolioManagerUserControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(portfolioManagerUserControl);
            portfolioManagerUserControl.Dock = DockStyle.Fill;
        }
    }
}