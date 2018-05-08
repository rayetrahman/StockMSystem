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

namespace ShockManagementProject.UI
{
    public partial class SetupItemW : Form
    {
        public SetupItemW()
        {
            InitializeComponent();
        }
        ItemManager aItemManager = new ItemManager();
        private void saveItemButton_Click(object sender, EventArgs e)
        {
            Item aItem = new Item();
            aItem.CategoryId = (int)categoryComboBox.SelectedValue;
            aItem.CompanyId = (int)companyComboBox.SelectedValue;
            aItem.ReorderLavel = Convert.ToInt32(reorderLevelTextBox.Text);
            aItem.ItemName = itemNameTextBox.Text;

            string message = aItemManager.Save(aItem);
            MessageBox.Show(message);

            Clear();
        }

        private void SetupItemW_Load(object sender, EventArgs e)
        {
            allCompanies();
            allCategories();
            reorderLevelTextBox.Text = 0.ToString();
        }

        public void allCategories()
        {
            List<Category> categories = aItemManager.GetAllCategories();

            Category defaultCategory = new Category();
            defaultCategory.CategoryId = -1;
            defaultCategory.CategoryName = "--Select--";

            categories.Insert(0, defaultCategory);

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryID";
        }



        public void allCompanies()
        {
            List<Company> companies = aItemManager.GetAllCompany();

            Company defaultCompany = new Company();
            defaultCompany.CompanyId = -1;
            defaultCompany.CompanyName = "--Select--";

            companies.Insert(0, defaultCompany);

            companyComboBox.DataSource = companies;
            companyComboBox.DisplayMember = "CompanyName";
            companyComboBox.ValueMember = "CompanyID";
        }

        private void Clear()
        {
            categoryComboBox.SelectedValue = -1;
            companyComboBox.SelectedValue = -1;
            itemNameTextBox.Clear();
            reorderLevelTextBox.Text = 0.ToString();
        }

    }
}
