using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;
using ShockManagementProject.ViewModel;

namespace ShockManagementProject.BLL
{
    class StockInManager
    {
        StockinGateway aStockinGateway=new StockinGateway();

        public List<Company> GetAllCompany()
        {
            return aStockinGateway.GetAllCompany();
        }

        public List<StockinView> StockWithCompany()
        {
            return aStockinGateway.StockWithCompany();
        }

        public StockIn stockInSelectInfo(StockIn aStockIn)
        {
            return aStockinGateway.stockInSelectInfo(aStockIn);
        }


        public string UpdateItem(StockIn aStockIn)
        {
          aStockIn.TotalQuentity = aStockIn.AvailableQuentity + aStockIn.StockInQuentity;
            string Message="";
          
                int row = aStockinGateway.UpdateItem(aStockIn);
                int row1 = aStockinGateway.SaveItem(aStockIn);

                if (row > 0 && row1 > 0)
                {
                    Message= "Stock In Successfully.";
                }
                else
                {
                    Message = " failed.";
                }
            return Message;
        }
    }
}
