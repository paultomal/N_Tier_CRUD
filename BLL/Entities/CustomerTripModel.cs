using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

namespace BLL.Entities
{
    public class CustomerTripModel : CustomerModel
    {
        public List<TripeModel> tripes { get; set; }
        public CustomerTripModel()
        {
            tripes = new List<TripeModel>();
        }
    }
}
