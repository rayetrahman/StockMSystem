using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShockManagementProject.BLL;
using ShockManagementProject.Model;
using ShockManagementProject.ViewModel;


namespace ShockManagementProject
{
    public partial class StockOutwf: Form
    {
        StockInManager aStockInManager = new StockInManager();
        StockOutManager aStockOutManager=new StockOutManager();
        public StockOutwf()
        {
            InitializeComponent(); 
        }
     
        private void StockOutwf_Load(object sender, EventArgs e)
        {
          Company();
          item();
        }


        public void Company()
        {
           // List<StockinView> stockinViews = aStockInManager.StockWithCompany();
            List<Company> stockinViews = aStockInManager.GetAllCompany();
          ///  StockinView defauStockinView = new StockinView();
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

        private void itemNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StockIn aStockIn = new StockIn();
            aStockIn.ItemId = (int)itemNameComboBox.SelectedValue;
            aStockIn.CompanyId = (int)companyComboBox.SelectedValue;

            StockIn info = aStockInManager.stockInSelectInfo(aStockIn);

            reorderLevelTextBox.Text = info.ReorderLavel.ToString();
            availableQuentityTb.Text = info.AvailableQuentity.ToString();
        }

        public void clear()
        {
            companyComboBox.Text = "";
            itemNameComboBox.Text = "";
            reorderLevelTextBox.Clear();
            availableQuentityTb.Clear();
            quentityTextBox.Clear();

        }

      
      
        List<StockOut> aStockOutList = new List<StockOut>();
        private void addStockOutBtn_Click(object sender, EventArgs e)
        {
            Model.StockOut aStockOut = new Model.StockOut();
            DateTime theDate = DateTime.UtcNow; 
            int count = 0;

            if (quentityTextBox.Text != "")
            {
                aStockOut.CompanyId=(int)companyComboBox.SelectedValue;
                aStockOut.ItemId=(int)itemNameComboBox.SelectedValue;
                aStockOut.AvailableQuentity=Convert.ToInt32(availableQuentityTb.Text);
                aStockOut.ReorderLavel = Convert.ToInt32(reorderLevelTextBox.Text);
                aStockOut.StockOutQuentity = Convert.ToInt32(quentityTextBox.Text);
                aStockOut.date = theDate.ToString("d");
                aStockOut.CompanyName = companyComboBox.Text;
                aStockOut.ItemName = itemNameComboBox.Text;

                aStockOutList.Add(aStockOut);
                clear();
                showListView.Items.Clear();


                foreach (StockOut Stock in aStockOutList)
                {
                    ListViewItem view = new ListViewItem();

                    view.Text = (++count).ToString();
                    view.SubItems.Add(Stock.ItemName);
                    view.SubItems.Add(Stock.CompanyName);
                    view.SubItems.Add(Stock.StockOutQuentity.ToString());
                    view.SubItems.Add(aStockOut.AvailableQuentity.ToString());
                    view.SubItems.Add(aStockOut.ItemId.ToString());
                    view.SubItems.Add(aStockOut.CompanyId.ToString());
                    view.SubItems.Add(aStockOut.date);
                    showListView.Items.Add(view);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Up All Field");
            }
        }



        Model.StockOut aStockOut = new Model.StockOut();
        private void showListView_MouseClick(object sender, MouseEventArgs e)
        {

                aStockOut.StockOutQuentity = Convert.ToInt16(showListView.SelectedItems[0].SubItems[3].Text);
                aStockOut.AvailableQuentity = Convert.ToInt16(showListView.SelectedItems[0].SubItems[4].Text);
                aStockOut.ItemId = Convert.ToInt16(showListView.SelectedItems[0].SubItems[5].Text);
                aStockOut.CompanyId = Convert.ToInt16(showListView.SelectedItems[0].SubItems[6].Text);
                aStockOut.date = showListView.SelectedItems[0].SubItems[7].Text;

        }


        private void sellButton_Click(object sender, EventArgs e)
        {
           // Model.StockOut aStockOut = new Model.StockOut();
            string message = aStockOutManager.SaveSellItem(aStockOut);
            MessageBox.Show(message);
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
           // Model.StockOut aStockOut = new Model.StockOut();
            string message = aStockOutManager.SaveDamageItem(aStockOut);
            MessageBox.Show(message);
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
           // Model.StockOut aStockOut = new Model.StockOut();
            string message = aStockOutManager.SaveLostItem(aStockOut);
            MessageBox.Show(message);
        }
    }
}
