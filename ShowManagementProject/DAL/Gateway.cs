using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockManagementProject.DAL
{
    class Gateway
    {
        private string connectionString =
         ConfigurationManager.ConnectionStrings["stockManagement"].ConnectionString;

        public SqlConnection Connection { get; private set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
