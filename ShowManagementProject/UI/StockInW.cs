using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockManagementProject.BLL;
using ShockManagementProject.Model;
using ShockManagementProject.ViewModel;

namespace ShockManagementProject.UI
{
    public partial class StockInW : Form
    {
        public StockInW()
        {
            InitializeComponent();
        }

        StockInManager aStockInManager = new StockInManager();

        private void StockInW_Load(object sender, EventArgs e)
        {
            Company();
            item();
        }

        public void Company()
        {
            // List<StockinView> stockinViews = aStockInManager.StockWithCompany();
            List<Company> stockinViews = aStockInManager.GetAllCompany();
            // StockinView defauStockinView = new StockinView();
            Company defauStockinView = new Company();
            defauStockinView.CompanyId = -1;
            defauStockinView.CompanyName = "--Select--";

            stockinViews.Insert(0, defauStockinView);

            companyComboBox.DataSource = stockinViews;
            companyComboBox.DisplayMember = "CompanyName";
            companyComboBox.ValueMember = "CompanyId";
        }

        public void item()
        {
            List<StockinView> stockinViews = aStockInManager.StockWithCompany();

            StockinView defauStockinView = new StockinView();
            defauStockinView.ItemId = -1;
            defauStockinView.ItemName = "--Select--";

            stockinViews.Insert(0, defauStockinView);

            itemNameComboBox.DataSource = stockinViews;
            itemNameComboBox.DisplayMember = "ItemName";
            itemNameComboBox.ValueMember = "ItemId";
        }

        private void clear()
        {
            companyComboBox.SelectedValue = -1;
            itemNameComboBox.SelectedValue = -1;
            reorderLevelTextBox.Clear();
            availableQuentityTb.Clear();
            stockInTextBox.Clear();
        }


        private void saveStockInButton_Click(object sender, EventArgs e)
        {
            DateTime theDate = DateTime.UtcNow;
            StockIn aStockIn = new StockIn();

            if (stockInTextBox.Text != "")
            {
                aStockIn.AvailableQuentity = Convert.ToInt32(availableQuentityTb.Text);
                aStockIn.StockInQuentity = Convert.ToInt32(stockInTextBox.Text);
                aStockIn.ItemId = (int)itemNameComboBox.SelectedValue;
                aStockIn.CompanyId = (int)companyComboBox.SelectedValue;
                aStockIn.date = theDate.ToString("d");

                string message = aStockInManager.UpdateItem(aStockIn);
                MessageBox.Show(message);
                clear();
            }
            else
            {
                MessageBox.Show("Please Fill Up All Field");
            }
        }

        private void itemNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StockIn aStockIn = new StockIn();
            aStockIn.ItemId = (int)itemNameComboBox.SelectedValue;
            aStockIn.CompanyId = (int)companyComboBox.SelectedValue;

            StockIn info = aStockInManager.stockInSelectInfo(aStockIn);

            reorderLevelTextBox.Text = info.ReorderLavel.ToString();
            availableQuentityTb.Text = info.AvailableQuentity.ToString();
        }
    }
}
