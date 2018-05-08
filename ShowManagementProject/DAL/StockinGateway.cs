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
    class StockinGateway :Gateway
    {

        public List<Company> GetAllCompany()
        {
            Query = "SELECT * FROM tblCompany";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Reader = Command.ExecuteReader();
            List<Company> companyList = new List<Company>();
            while (Reader.Read())
            {
                Company company = new Company();
                company.CompanyId = (int)Reader["CompanyID"];
                company.CompanyName = Reader["CompanyName"].ToString();
                companyList.Add(company);
            }
            Reader.Close();
            Connection.Close();
            return companyList;

        }


        public List<StockinView> StockWithCompany()
        {
            Query = "SELECT * FROM StockWithCompany";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Reader = Command.ExecuteReader();
            List<StockinView> stockList = new List<StockinView>();
            while (Reader.Read())
            {
                StockinView aStockinView = new StockinView();
                aStockinView.CompanyId = (int)Reader["CompanyId"];
                aStockinView.ItemId = (int)Reader["ItemId"];
                aStockinView.CompanyName = Reader["CompanyName"].ToString();
                aStockinView.ItemName = Reader["ItemName"].ToString();
                stockList.Add(aStockinView);
            }
            Reader.Close();
            Connection.Close();
            return stockList;
        }


        public StockIn stockInSelectInfo(StockIn aStockIn)
        {
            Query = "SELECT * FROM tblItem where CompanyId=@CompanyId and ItemId=@ItemId";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CompanyId", aStockIn.CompanyId);
            Command.Parameters.AddWithValue("ItemId", aStockIn.ItemId);
            Reader = Command.ExecuteReader();
           
            while (Reader.Read())
            {
       
                aStockIn.ReorderLavel = (int)Reader["ReorderLavel"];
                aStockIn.AvailableQuentity = (int)Reader["AvailableQuentity"];

            }
            Reader.Close();
            Connection.Close();
           
            return aStockIn;
        }


        public int UpdateItem(StockIn aStockIn)
        {
            Query = "UPDATE tblItem SET AvailableQuentity =@TotalQuentity  WHERE ItemId =@ItemId and CompanyId=@CompanyId ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("TotalQuentity", aStockIn.TotalQuentity);
            Command.Parameters.AddWithValue("ItemId", aStockIn.ItemId);
            Command.Parameters.AddWithValue("CompanyId", aStockIn.CompanyId);
            int rowAffected = Command.ExecuteNonQuery();
            Command.Connection.Close();
            return rowAffected;
        }


        public int SaveItem(StockIn aStockIn)
        {
            Query = "INSERT INTO StockInfo (CompanyId, ItemId, StockIn, Date) VALUES(@CompanyId,@ItemId,@StockIn,@Date)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CompanyId", aStockIn.CompanyId);
            Command.Parameters.AddWithValue("ItemId", aStockIn.ItemId);
            Command.Parameters.AddWithValue("StockIn", aStockIn.StockInQuentity);
            Command.Parameters.AddWithValue("Date", aStockIn.date);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

    }
}
