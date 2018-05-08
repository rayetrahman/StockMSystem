using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;
using ShockManagementProject.ViewModel;

namespace ShockManagementProject.BLL
{
    class StockOutManager
    {
        StockinGateway aStockinGateway = new StockinGateway();
        StockOutGateway aStockOutGateway = new StockOutGateway();

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



        public string SaveSellItem(StockOut aStockOut)
        {
            string Message = "";
            if (aStockOut.AvailableQuentity > aStockOut.StockOutQuentity)
            {
                aStockOut.TotalQuentity = aStockOut.AvailableQuentity - aStockOut.StockOutQuentity;

                int row = aStockOutGateway.UpdateItem(aStockOut);
                int row1 = aStockOutGateway.SaveSellItem(aStockOut);

                if (row > 0 && row1 > 0)
                {
                    Message = "Product Stock Out .";
                }
                else
                {
                    Message = " failed.";
                }
            }
            else
            {
                Message = "Item Not Available";
            }
            
            return Message;       
        }


        public string SaveDamageItem(StockOut aStockOut)
        {
            string Message = "";
            if (aStockOut.AvailableQuentity > aStockOut.StockOutQuentity)
            {
                aStockOut.TotalQuentity = aStockOut.AvailableQuentity - aStockOut.StockOutQuentity;

                int row = aStockOutGateway.UpdateItem(aStockOut);
                int row1 = aStockOutGateway.SaveDamageItem(aStockOut);

                if (row > 0 && row1 > 0)
                {
                    Message = "Product Stock Out Successfully.";
                }
                else
                {
                    Message = " failed.";
                }
            }
            else
            {
                Message = "Item Not available";
            }

            return Message;
        }

          public string SaveLostItem(StockOut aStockOut)
        {
            string Message = "";
            if (aStockOut.AvailableQuentity > aStockOut.StockOutQuentity)
            {
                aStockOut.TotalQuentity = aStockOut.AvailableQuentity - aStockOut.StockOutQuentity;

                int row = aStockOutGateway.UpdateItem(aStockOut);
                int row1 = aStockOutGateway.SaveLostItem(aStockOut);

                if (row > 0 && row1 > 0)
                {
                    Message = "Product Stock Out Successfully.";
                }
                else
                {
                    Message = " failed.";
                }
            }
            else
            {
                Message = "Item Not available";
            }

            return Message;
        }
    }
}
