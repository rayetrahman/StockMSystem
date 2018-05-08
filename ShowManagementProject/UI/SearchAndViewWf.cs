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


namespace ShockManagementProject
{
    public partial class SearchAndViewWf : Form
    {
        public SearchAndViewWf()
        {
            InitializeComponent();  
        }
          
        SearchAndViewManager asSearchAndViewManager=new SearchAndViewManager();

        private void SearchAndViewWf_Load(object sender, EventArgs e)
        {
            Category();
            Company();
            
        }

        public void Company()
        {
            //List<Search> CompanyView = asSearchAndViewManager.SearchAndViewItem();

            //Search defauCompanyView = new Search();

            List<Company> CompanyView = asSearchAndViewManager.GetAllCompany();
            Company defauCompanyView = new Company();
            defauCompanyView.CompanyId = -1;
            defauCompanyView.CompanyName = "--Select--";

            CompanyView.Insert(0, defauCompanyView);

            companyNameComboBox.DataSource = CompanyView;
            companyNameComboBox.DisplayMember = "CompanyName";
            companyNameComboBox.ValueMember = "CompanyId";
        }

        public void Category()
        {
           // List<Search> categoryView = asSearchAndViewManager.SearchAndViewItem();
           // Search defaultCategoryView = new Search();
            List<Category> categoryView = asSearchAndViewManager.GetAllCategories();
            Category defaultCategoryView = new Category();
            defaultCategoryView.CategoryId = -1;
            defaultCategoryView.CategoryName = "--Select--";

            categoryView.Insert(0, defaultCategoryView);

            categoryNameComboBox.DataSource = categoryView;
            categoryNameComboBox.DisplayMember = "CategoryName";
            categoryNameComboBox.ValueMember = "CategoryId";
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
                 Search aSearch = new Search();
                aSearch.CategoryId = (int) categoryNameComboBox.SelectedValue;
                aSearch.CompanyId = (int) companyNameComboBox.SelectedValue;

                List<Search> ViewAllItem = asSearchAndViewManager.ViewItem(aSearch);
            if (ViewAllItem == null)
            {
                MessageBox.Show("please select  Item");
            }
            else
            {
                searchItemListView.Items.Clear();
                int count = 0;
                foreach (Search search in ViewAllItem)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = (++count).ToString();
                    item.SubItems.Add(search.ItemName);
                    item.SubItems.Add(search.CompanyName);
                    item.SubItems.Add(search.CategoryName);
                    item.SubItems.Add(search.AvailableQuentity);
                    item.SubItems.Add(search.Reorderlevel);

                    searchItemListView.Items.Add(item);
                }
            }
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;



        private void printButton_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();  ///printPreviewDialog1 name
        }

       
    }
}
