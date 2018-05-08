using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockManagementProject.ViewModel
{
    class StockinView
    {
        public int CompanyId { set; get; }
        public int ItemId { set; get; }
        public string CompanyName{ set; get; }
        public string ItemName { set; get; }
        public int ReorderLavel { set; get; }
        public int AvailableQuentity { set; get; }
    }
}
