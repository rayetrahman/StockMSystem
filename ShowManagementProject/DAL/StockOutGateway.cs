using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;
using ShockManagementProject.ViewModel;

namespace ShockManagementProject.DAL
{
    class StockOutGateway:StockinGateway
    {
        public int UpdateItem(StockOut aStockOut)
        {
            Query = "UPDATE tblItem SET AvailableQuentity =@TotalQuentity  WHERE ItemId =@ItemId and CompanyId=@CompanyId ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("TotalQuentity", aStockOut.TotalQuentity);
            Command.Parameters.AddWithValue("ItemId", aStockOut.ItemId);
            Command.Parameters.AddWithValue("CompanyId", aStockOut.CompanyId);
            int rowAffected = Command.ExecuteNonQuery();
            Command.Connection.Close();
            return rowAffected;
        }


        public int SaveSellItem(StockOut aStockOut)
        {
            Query = "INSERT INTO StockInfo (CompanyId, ItemId, Sell, Date) VALUES(@CompanyId,@ItemId,@StockOut,@Date)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CompanyId", aStockOut.CompanyId);
            Command.Parameters.AddWithValue("ItemId", aStockOut.ItemId);
            Command.Parameters.AddWithValue("StockOut", aStockOut.StockOutQuentity);
            Command.Parameters.AddWithValue("Date", aStockOut.date);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public int SaveDamageItem(StockOut aStockOut)
        {
            Query = "INSERT INTO StockInfo (CompanyId, ItemId, Damage, Date) VALUES(@CompanyId,@ItemId,@StockOut,@Date)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CompanyId", aStockOut.CompanyId);
            Command.Parameters.AddWithValue("ItemId", aStockOut.ItemId);
            Command.Parameters.AddWithValue("StockOut", aStockOut.StockOutQuentity);
            Command.Parameters.AddWithValue("Date", aStockOut.date);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int SaveLostItem(StockOut aStockOut)
        {
            Query = "INSERT INTO StockInfo (CompanyId, ItemId, lost, Date) VALUES(@CompanyId,@ItemId,@StockOut,@Date)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CompanyId", aStockOut.CompanyId);
            Command.Parameters.AddWithValue("ItemId", aStockOut.ItemId);
            Command.Parameters.AddWithValue("StockOut", aStockOut.StockOutQuentity);
            Command.Parameters.AddWithValue("Date", aStockOut.date);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
