using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class CompanyManager
    {

        CompanyGateway aCompanyGateway = new CompanyGateway();


        public string Save(Company aCompany)
        {
            if (!aCompanyGateway.IsCompanyNoExist(aCompany))
            {
                string message = aCompanyGateway.Save(aCompany);
                return message;
            }
            return " This Company Name Already Exist.";
        }


        public List<Company> GetAllCompany()
        {
            return aCompanyGateway.GetAllCompany();
        }
 
    }
}
