using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using ShockManagementProject.UI;

namespace ShockManagementProject
{
    public partial class Main : Form
    {
         public Main()
        {   
            InitializeComponent();      
         }

        private void setupCategoryButton1_Click(object sender, EventArgs e)
        {
         
           SetupCategoryW aSetupCategory=new SetupCategoryW();
           aSetupCategory.MdiParent = this;
           aSetupCategory.Show();
           if (this.MdiChildren.Count() > 1)
           {
               foreach (Form childForm in this.MdiChildren)
               {
                   if (childForm != this.ActiveMdiChild)
                   {
                       childForm.Close();
                       return;
                   }
               }
           }
        }

        private void setupCompanyButton_Click(object sender, EventArgs e)
        {
            SetupCompanyW aSetupCompanyW=new SetupCompanyW();
            aSetupCompanyW.MdiParent = this;
            aSetupCompanyW.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void setupItemButton_Click(object sender, EventArgs e)
        {  
            SetupItemW aSetupItemW=new SetupItemW();
            aSetupItemW.MdiParent = this;
            aSetupItemW.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
           
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInW aStockInW = new StockInW();
            aStockInW.MdiParent = this;
            aStockInW.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            StockOutwf aStockOut = new StockOutwf();
            aStockOut.MdiParent = this;
            aStockOut.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void searchViewButton_Click(object sender, EventArgs e)
        {
            SearchAndViewWf search = new SearchAndViewWf();
            search.MdiParent = this;
            search.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void viewSalesButton_Click(object sender, EventArgs e)
        {
            Report aReport = new Report();
            aReport.MdiParent = this;
            aReport.Show();
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
          
            login log=new login();
            this.Close();     //close all page
            log.Show();

        }



    }
}
