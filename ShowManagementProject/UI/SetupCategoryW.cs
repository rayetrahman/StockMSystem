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
    public partial class SetupCategoryW : Form
    {
        public SetupCategoryW()
        {
            InitializeComponent();
        }
        CategoryManager aCategoryManager = new CategoryManager();
        private void saveCategoryBtn_Click(object sender, EventArgs e)
        {
            Category aCategory = new Category();
            aCategory.CategoryName = categoryNameTextBox.Text;
            if (categoryNameTextBox.Text != "")
            {
                if (saveCategoryBtn.Text == "Save")
                {
                    string message = aCategoryManager.Save(aCategory);
                    MessageBox.Show(message);
                }
                else
                {
                    aCategory.CategoryId = Convert.ToInt32(hiddenIdLabel.Text);
                    string message = aCategoryManager.UpdateCategory(aCategory);
                    MessageBox.Show(message);

                }


                LoadAllCategories();
                clear();
            }
            else
            {
                MessageBox.Show("Please Fill Up All Field");
            }
        }

        private void clear()
        {
            categoryNameTextBox.Text = "";
            saveCategoryBtn.Text = "Save";
        }

        private void SetupCategoryW_Load(object sender, EventArgs e)
        {
            LoadAllCategories();
        }

        private void LoadAllCategories()
        {
            categoryListView.Items.Clear();
            List<Category> categories = aCategoryManager.GetAllCategories();
            int count = 0;
            foreach (Category category in categories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (++count).ToString();
                item.SubItems.Add(category.CategoryName);
                item.Tag = category;

                categoryListView.Items.Add(item);
            }
        }



        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = categoryListView.SelectedItems[0];

            Category category = (Category)selectedItem.Tag;

            hiddenIdLabel.Text = category.CategoryId.ToString();
            categoryNameTextBox.Text = category.CategoryName;


            saveCategoryBtn.Text = "Update";
        }
    }
}
