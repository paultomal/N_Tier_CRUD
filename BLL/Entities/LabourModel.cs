using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class LabourModel
    {
        public int labour_id { get; set; }
        public string labour_name { get; set; }
        public int labour_phone { get; set; }
        public string labour_address { get; set; }
        public int user_id { get; set; }

    }
}
