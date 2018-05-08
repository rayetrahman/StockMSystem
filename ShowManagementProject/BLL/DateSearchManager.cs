using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockManagementProject.DAL;
using ShockManagementProject.Model;

namespace ShockManagementProject.BLL
{
    class DateSearchManager
    {
        private DateSearchGateway aDateSearchGateway = new DateSearchGateway();

        public List<DateSearch> searchDate(DateSearch aDateSearch)
        {
             
            return aDateSearchGateway.searchDate(aDateSearch);
        }
    }
}
