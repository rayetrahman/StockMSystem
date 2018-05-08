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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
    
        DateSearchManager aDateSearchManager=new DateSearchManager();

        private void searchButton_Click(object sender, EventArgs e)
        {
           DateSearch aDateSearch=new DateSearch();
           DateTime from=fromDateTimePicker.Value;
           DateTime to = todateTimePicker.Value;

            if (from > to)
            {
                MessageBox.Show("From date is greater then To date");
            }
            else
            {
                aDateSearch.FromDate = fromDateTimePicker.Text;
                aDateSearch.ToDate = todateTimePicker.Text;
                List<DateSearch> dateSearchResult = aDateSearchManager.searchDate(aDateSearch);

                serchByDatelistView.Items.Clear();
                int counter = 0;
                foreach (DateSearch date in dateSearchResult)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = (++counter).ToString();
                    item.SubItems.Add(date.ItemName);
                    item.SubItems.Add(date.Sell.ToString());

                    serchByDatelistView.Items.Add(item);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
        Bitmap bmp;

        private void printButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();  ///printPreviewDialog1 name
        }
    }
}
