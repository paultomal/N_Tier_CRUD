using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ActivityLogModel
    {
        public int activity_log_id { get; set; }
        public string activity_type { get; set; }
        public System.DateTime date { get; set; }
        public int id { get; set; }
    }
}
