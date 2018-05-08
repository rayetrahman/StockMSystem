using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class ItemManager
    {

        ItemGateway aItemGateway=new ItemGateway();

        public List<Category> GetAllCategories()
        {
            return aItemGateway.GetAllCategories();
        }

        public List<Company> GetAllCompany()
        {
            return aItemGateway.GetAllCompany();
        }
        

        public string Save(Item aItem)
        {
            if (aItem.CategoryId != -1 && aItem.CompanyId != -1 && aItem.ItemName != "")
            {
                if (!aItemGateway.IsItemExist(aItem))
                {
                    string message = aItemGateway.Save(aItem);
                    return message;
                }
                return "This Item Already Exist.";
            }
            return "Please Fill Up All Field";
        }
         
    }
}
