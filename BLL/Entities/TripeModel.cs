using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class TripeModel
    {
        public int tripe_id { get; set; }
        public string end_location { get; set; }
        public string start_location { get; set; }
        public string vechile_type { get; set; }
        public int price { get; set; }
        public Nullable<int> labour_number { get; set; }
        public System.DateTime dateandtime { get; set; }
        public string product_discription { get; set; }
        public string status { get; set; }
        public int customer_id { get; set; }
        public Nullable<int> driver_id { get; set; }
        public string labour_id { get; set; }
    }
}
