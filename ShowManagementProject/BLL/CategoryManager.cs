using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class CategoryManager
    {
        CategoryGateway aCategoryGateway = new CategoryGateway();


        public string Save(Category aCategory)
        {
            if (!aCategoryGateway.IsCategoryNoExist(aCategory))
            {
                string message = aCategoryGateway.Save(aCategory);
                return message;
            }
            return " This Category Name Already Exist.";
        }


        public List<Category> GetAllCategories()
        {
            return aCategoryGateway.GetAllCategories();
        }





        public string UpdateCategory(Category aCategory)
        {
            if (aCategoryGateway.IsCategoryNoExist(aCategory))
            {
                return "This Category Name already exist.";
            }
            int rowAffected = aCategoryGateway.UpdateCategory(aCategory);
            if (rowAffected > 0)
            {
                return "Updated successfully.";
            }
            return "Update failed.";
        }
    }
}
