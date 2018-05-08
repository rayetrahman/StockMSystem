using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockManagementProject.Model
{
    class Item
    {
        public int CategoryId { set; get; }
        public int CompanyId { set; get; }
        public string ItemName { set; get; }
        public int ReorderLavel { set; get; }
    }
}
