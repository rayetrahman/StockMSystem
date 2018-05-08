using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockManagementProject.Model
{
    class StockOut
    {

        public int ItemId { set; get; }
        public int CompanyId { set; get; }
        public int ReorderLavel { set; get; }
        public int AvailableQuentity { set; get; }
        public int StockOutQuentity { set; get; }
        public string date;
        public int TotalQuentity { set; get; }
        public string CompanyName { set; get; }
        public string ItemName { set; get; }
    }
}
