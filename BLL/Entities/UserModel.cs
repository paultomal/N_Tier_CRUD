using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class UserModel
    {
        public int user_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
    }
}
