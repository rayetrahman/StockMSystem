using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class SearchAndViewManager
    {
        SearchAndViewGateway asAndViewGateway=new SearchAndViewGateway();

        //public List<Search> SearchAndViewItem()
        //{
        //   return asAndViewGateway.SearchAndViewItem();
        //}

        public List<Company> GetAllCompany()
        {
            return asAndViewGateway.GetAllCompany();
        }

        public List<Category> GetAllCategories()
        {
            return asAndViewGateway.GetAllCategories();
        }

        public List<Search> ViewItem(Search aSearch)
        {
            List<Search> searchresult = null;
            if (aSearch.CategoryId != -1 && aSearch.CompanyId == -1)
            {
                 searchresult=  asAndViewGateway.ViewCategoryItem(aSearch);
            }
            else if (aSearch.CompanyId != -1 && aSearch.CategoryId == -1)
            {
                searchresult = asAndViewGateway.ViewCompanyItem(aSearch);
            }
            else if (aSearch.CategoryId != -1 && aSearch.CompanyId != -1)
            {
                searchresult = asAndViewGateway.ViewItem(aSearch);
            }
         
            return searchresult;
        }
    }
}
