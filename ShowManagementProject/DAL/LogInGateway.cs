using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.Model;

namespace ShockManagementProject.DAL
{
    class LogInGateway:Gateway
    {
        public string login(Login Login)
        {
            Query = "Select Count(*) From Login where UserName='" + Login.UserName + "' and Password='" + Login.Password + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            string count=dt.Rows[0][0].ToString();
            Connection.Close();
            return count;
        }

      

    }
}
