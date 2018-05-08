using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class CompanyGateway:Gateway
    {
        public string Save(Company aCompany)
        {
            Query = "INSERT INTO tblCompany (CompanyName) VALUES(@CompanyName)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("CompanyName", aCompany.CompanyName);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            if (rowAffected > 0)
            {
                return "Saved Company Successfully";
            }
            else
            {
                return "Failed ";
            }
        }




        public bool IsCompanyNoExist(Company aCompany)
        {
            Query = "SELECT * FROM tblCompany WHERE CompanyName=@CompanyName";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("CompanyName", aCompany.CompanyName);
            Reader = Command.ExecuteReader();
            Reader.Read();
            bool isExist = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return isExist;
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
    }
}
