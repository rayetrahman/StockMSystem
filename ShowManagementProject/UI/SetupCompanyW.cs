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
    public partial class SetupCompanyW : Form
    {
        public SetupCompanyW()
        {
            InitializeComponent();
        }
        CompanyManager aCompanyManager = new CompanyManager();
        private void saveCompanyButton_Click(object sender, EventArgs e)
        {
            Company aCompany = new Company();
            aCompany.CompanyName = companyNameTextBox.Text;
            if (companyNameTextBox.Text != "")
            {
                string message = aCompanyManager.Save(aCompany);
                MessageBox.Show(message);

                LoadAllCompanies();
                clear();
            }
            else
            {
                MessageBox.Show("Please Fill Up All Field");
            }
        }

        private void SetupCompanyW_Load(object sender, EventArgs e)
        {
            LoadAllCompanies();
        }

        private void clear()
        {
            companyNameTextBox.Text = "";
        }

        private void LoadAllCompanies()
        {
            companylistView.Items.Clear();
            List<Company> companies = aCompanyManager.GetAllCompany();
            int count = 0;
            foreach (Company company in companies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (++count).ToString();
                item.SubItems.Add(company.CompanyName);
                item.Tag = company;

                companylistView.Items.Add(item);
            }
        }

    }
}
