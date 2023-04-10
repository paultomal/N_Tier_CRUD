using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AdminModel
    {
        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public System.DateTime admin_DOB { get; set; }
        public string admin_address { get; set; }
        public int user_id { get; set; }
    }
}
