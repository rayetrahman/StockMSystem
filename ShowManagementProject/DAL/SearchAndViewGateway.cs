using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class SearchAndViewGateway:Gateway
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
        public List<Category> GetAllCategories()
        {
            Query = "SELECT * FROM tblCategory";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Reader = Command.ExecuteReader();
            List<Category> categoryList = new List<Category>();
            while (Reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)Reader["CategoryID"];
                category.CategoryName = Reader["CategoryName"].ToString();
                categoryList.Add(category);
            }
            Reader.Close();
            Connection.Close();
            return categoryList;

        }
        //public List<Search> SearchAndViewItem()
        //{
        //    Query = "SELECT * FROM CategoryCompanyItemInfo";
        //    Command = new SqlCommand(Query, Connection);
        //    Command.Connection.Open();
        //    Reader = Command.ExecuteReader();
        //    List<Search> searchItemList = new List<Search>();
        //    while (Reader.Read())
        //    {
        //        Search aSearch = new Search();
        //        aSearch.CompanyId = (int)Reader["CompanyId"];
        //        aSearch.CategoryId = (int)Reader["CategoryId"];
        //        aSearch.CompanyName = Reader["CompanyName"].ToString();
        //        aSearch.CategoryName = Reader["CategoryName"].ToString();
        //        searchItemList.Add(aSearch);
        //    }
        //    Reader.Close();
        //    Connection.Close();
        //    return searchItemList;
        //}

        public List<Search> ViewItem(Search aSearch)
        {
            Query = "SELECT * FROM CategoryCompanyItemInfo where CategoryId=@CategoryId and CompanyId=@CompanyId";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CategoryId", aSearch.CategoryId);
            Command.Parameters.AddWithValue("CompanyId", aSearch.CompanyId);
            Reader = Command.ExecuteReader();
            List<Search> searchItem = new List<Search>();
            while (Reader.Read())
            {
                Search Search = new Search();
                Search.CategoryName = Reader["CategoryName"].ToString();
                Search.CompanyName = Reader["CompanyName"].ToString();
                Search.Reorderlevel = Reader["ReorderLavel"].ToString();
                Search.AvailableQuentity = Reader["AvailableQuentity"].ToString();
                Search.ItemName = Reader["ItemName"].ToString();
                searchItem.Add(Search);
            }
            Reader.Close();
            Connection.Close();
            return searchItem;
        }

        public List<Search> ViewCategoryItem(Search aSearch)
        {
            Query = "SELECT * FROM CategoryCompanyItemInfo where CategoryId=@CategoryId";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CategoryId", aSearch.CategoryId);
            Reader = Command.ExecuteReader();
            List<Search> searchItem = new List<Search>();
            while (Reader.Read())
            {
                Search Search = new Search();
                Search.CategoryName = Reader["CategoryName"].ToString();
                Search.CompanyName = Reader["CompanyName"].ToString();
                Search.Reorderlevel = Reader["ReorderLavel"].ToString();
                Search.AvailableQuentity = Reader["AvailableQuentity"].ToString();
                Search.ItemName = Reader["ItemName"].ToString();
                searchItem.Add(Search);
            }
            Reader.Close();
            Connection.Close();
            return searchItem;
        }

        public List<Search> ViewCompanyItem(Search aSearch)
        {
            Query = "SELECT * FROM CategoryCompanyItemInfo where CompanyId=@CompanyId";
            Command = new SqlCommand(Query, Connection);
            Command.Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CompanyId", aSearch.CompanyId);
            Reader = Command.ExecuteReader();
            List<Search> searchItem = new List<Search>();
            while (Reader.Read())
            {
                Search Search = new Search();
                Search.CategoryName = Reader["CategoryName"].ToString();
                Search.CompanyName = Reader["CompanyName"].ToString();
                Search.Reorderlevel = Reader["ReorderLavel"].ToString();
                Search.AvailableQuentity = Reader["AvailableQuentity"].ToString();
                Search.ItemName = Reader["ItemName"].ToString();
                searchItem.Add(Search);
            }
            Reader.Close();
            Connection.Close();
            return searchItem;
        }
    }
}
