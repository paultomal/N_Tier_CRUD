using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ReviewModel
    {
        public int review_id { get; set; }
        public string comment { get; set; }
        public System.DateTime review_date { get; set; }
        public int customer_id { get; set; }
    }
}
