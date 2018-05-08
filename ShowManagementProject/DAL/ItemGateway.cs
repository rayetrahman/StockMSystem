using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class ItemGateway:Gateway
    {


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




        public string Save(Item aItem)
        {
            Query = "INSERT INTO tblItem (CategoryId,CompanyId,ItemName,ReorderLavel) VALUES(@CategoryId,@CompanyId,@ItemName,@ReorderLavel)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CategoryId", aItem.CategoryId);
            Command.Parameters.AddWithValue("CompanyId", aItem.CompanyId);
            Command.Parameters.AddWithValue("ItemName", aItem.ItemName);
            Command.Parameters.AddWithValue("ReorderLavel", aItem.ReorderLavel);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            if (rowAffected > 0)
            {
                return "Saved Item Successfully";
            }
            else
            {
                return "Failed";
            }
        }

        public bool IsItemExist(Item aItem)
        {
            Query = "SELECT * FROM tblItem WHERE ItemName=@ItemName";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("ItemName", aItem.ItemName);
            Reader = Command.ExecuteReader();
            Reader.Read();
            bool isExist = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return isExist;
        }
    }
}
