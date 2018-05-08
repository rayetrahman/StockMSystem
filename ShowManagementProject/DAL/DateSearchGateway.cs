using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class DateSearchGateway :Gateway
    {
        public List<DateSearch> searchDate(DateSearch aDateSearch)
        {
            Query = "SELECT * FROM DateSearch Where Date BETWEEN @from and @to";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Command.Parameters.AddWithValue("from", aDateSearch.FromDate);
            Command.Parameters.AddWithValue("to", aDateSearch.ToDate);
            Reader = Command.ExecuteReader();

            List<DateSearch> DateSearchList = new List<DateSearch>();
            while (Reader.Read())
            {
                DateSearch DateSearch = new DateSearch();
                DateSearch.ItemName = Reader["ItemName"].ToString();
                DateSearch.Sell = (int)Reader["Sell"];
                DateSearchList.Add(DateSearch);
            }
            Reader.Close();
            Connection.Close();
            return DateSearchList;
        }
    }
}
