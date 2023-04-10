using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CustomerModel
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public System.DateTime customer_DOB { get; set; }
        public string customer_address { get; set; }
        public int customer_phone { get; set; }
        public int user_id { get; set; }
    }
}
