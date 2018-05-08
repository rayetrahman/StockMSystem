using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockManagementProject.Model
{
    class StockIn
    {
        public int ReorderLavel { set; get; }
        public int AvailableQuentity { set; get; }
        public int ItemId { set; get; }
        public int CompanyId { set; get; }

        public string ItemName { set; get; }
        public string CompanyName { set; get; }

        public int StockInQuentity { set; get; }
        public string date;
        public int TotalQuentity { set; get; }
    }
}
