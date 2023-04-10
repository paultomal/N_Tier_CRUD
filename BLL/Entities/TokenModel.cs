using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class TokenModel
    {
        public int token_id { get; set; }
        public string token_key { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
        public int user_id { get; set; }
    }
}
