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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ZH_A22D5D
{
    public partial class StockDiagramUserControl : UserControl
    {
        FuraadatbazisContext furaadatbazisContext = new FuraadatbazisContext();
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        public StockDiagramUserControl()
        {
            InitializeComponent();
            stocksBindingSource.DataSource = furaadatbazisContext.Stocks.ToList();
        }
        private void CreateExcel()
        {
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Add(Missing.Value);
            xlWorksheet = xlWorkbook.ActiveSheet;

            CreateTable();

            xlApp.Visible = true;
            xlApp.UserControl = true;
        }

        private void CreateTable()
        {
            string[] header = new string[]
            {
                "Name",
                "Ticker",
                "Market",
                "Price"
            };

            for (int i = 0; i < header.Length; i++)
            {
                xlWorksheet.Cells[1 , i + 1] = header[i];
                xlWorksheet.Cells[1, i + 1].Font.Bold = true;
            };

            int current_id = 1;
            foreach (var item in furaadatbazisContext.Stocks.ToList())
            {
                current_id++;
                xlWorksheet.Cells[current_id, 1] = item.Name;
                xlWorksheet.Cells[current_id, 2] = item.Ticker;
                xlWorksheet.Cells[current_id, 3] = item.Market;
                xlWorksheet.Cells[current_id, 4] = item.Price;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
    }
}
