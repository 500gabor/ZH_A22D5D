using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_A22D5D.Models;

namespace ZH_A22D5D
{
    public partial class AddStocksUserControl : UserControl
    {
        FuraadatbazisContext furaadatbazisContext = new FuraadatbazisContext();
        public AddStocksUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listBox1.DataSource = furaadatbazisContext.Stocks.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string datatype = @"[A-Z]";
            Regex regex = new Regex(datatype);

            if (nameTextBox.Text.IsNullOrEmpty() || !regex.IsMatch(nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nameTextBox, "Can't be empty, must contain uppercase character");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nameTextBox, null);
            }
        }
        private void tickerTextBox_Validating(object sender, CancelEventArgs e)
        {
            string datatype = @"[A-Z]";
            Regex regex = new Regex(datatype);
            if (tickerTextBox.Text.IsNullOrEmpty() || !regex.IsMatch(tickerTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tickerTextBox, "Can't be empty, must contain uppercase character");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tickerTextBox, null);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Saving", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (this.ValidateChildren())
                {
                    Stocks current_stock = new Stocks();
                    current_stock.Name = nameTextBox.Text;
                    current_stock.Ticker = tickerTextBox.Text;
                    current_stock.Market = marketTextBox.Text;
                    current_stock.Price = (double)numericUpDown1.Value;

                    furaadatbazisContext.Stocks.Add(current_stock);
                    try
                    {
                        furaadatbazisContext.SaveChanges();
                        MessageBox.Show("Saved");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                LoadData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting", "Sure", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var temp = from x in furaadatbazisContext.Stocks
                           where (Stocks)x == (Stocks)listBox1.SelectedItem
                           select x;

                furaadatbazisContext.Stocks.Remove(temp.FirstOrDefault());
                try
                {
                    furaadatbazisContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                MessageBox.Show("Deleted");
                LoadData();
            }
        }
    }
}
