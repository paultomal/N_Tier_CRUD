using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ManagerModel
    {
        public int manager_id { get; set; }
        public string manager_name { get; set; }
        public string manager_address { get; set; }
        public int manager_phone { get; set; }
        public int user_id { get; set; }
    }
}
