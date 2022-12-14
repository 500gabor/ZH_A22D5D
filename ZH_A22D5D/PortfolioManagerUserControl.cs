using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_A22D5D.Models;

namespace ZH_A22D5D
{
    public partial class PortfolioManagerUserControl : UserControl
    {
        FuraadatbazisContext furaadatbazisContext = new FuraadatbazisContext();
        public PortfolioManagerUserControl()
        {
            InitializeComponent();
            LoadPortfolios();
            LoadStocks();
            LoadInventory();
        }
        private void LoadInventory()
        {
            Portfolio portfolio = (Portfolio)portfoliosListBox.SelectedItem;

            var data = from x in furaadatbazisContext.Connection
                       where x.PortfolioFk == portfolio.PortfolioSk
                       select new
                       {
                           x.PortfolioFk,
                           x.StocksFk,
                           x.StocksFkNavigation.Name
                       };
            connectionsListBox.DataSource = data.ToList();
            connectionsListBox.DisplayMember = "Name";

        }
        private void LoadPortfolios()
        {
            var data = from x in furaadatbazisContext.Portfolio
                       where x.PortfolioName.Contains(portfoliosFilterTextBox.Text)
                       select x;
            portfoliosListBox.DataSource = data.ToList();
            portfoliosListBox.DisplayMember = "PortfolioName";
        }

        private void LoadStocks()
        {
            var data = from x in furaadatbazisContext.Stocks
                       where x.Name.Contains(stockfilterTextBox.Text)
                       select x;
            stocksListBox.DataSource = data.ToList();
            stocksListBox.DisplayMember = "Name";
        }

        private void portfoliosFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadPortfolios();
        }

        private void stockfilterTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private void portfoliosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stocks stocks = (Stocks)stocksListBox.SelectedItem;
            Portfolio portfolio = (Portfolio)portfoliosListBox.SelectedItem;

            Connection connection = new();
            connection.PortfolioFk = portfolio.PortfolioSk;
            connection.StocksFk = stocks.StockSk;

            furaadatbazisContext.Add(connection);
            try
            {
                furaadatbazisContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            LoadInventory();
        }
    }
}
