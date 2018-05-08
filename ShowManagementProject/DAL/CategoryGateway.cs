using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class CategoryGateway: Gateway
    {
        public string Save(Category acCategory)
        {
            Query = "INSERT INTO tblCategory (CategoryName) VALUES(@CategoryName)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CategoryName", acCategory.CategoryName);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            if (rowAffected > 0)
            {
                return "Saved";
            }
            else
            {
                return "Failed";
            }
        }




        public bool IsCategoryNoExist(Category aCategory)
        {
            Query = "SELECT * FROM tblCategory WHERE CategoryName=@CategoryName";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CategoryName", aCategory.CategoryName);
            Reader = Command.ExecuteReader();
            Reader.Read();
            bool isExist = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return isExist;
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



        public int UpdateCategory(Category aCategory)
        {
            Query = "UPDATE tblCategory SET CategoryName =@CategoryName WHERE CategoryId =@id";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CategoryName", aCategory.CategoryName);
            Command.Parameters.AddWithValue("id", aCategory.CategoryId);

            int rowAffected = Command.ExecuteNonQuery();
            Command.Connection.Close();
            return rowAffected;
        }
    }
}
