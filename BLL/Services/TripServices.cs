using BLL.Entities;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TripServices
    {
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get(id);
            if(data.status == "pending" || data.status == "pocessing")
            {
                return DataAccessFactory.GetTripeAccess().Delete(id);
            }
            else
            {
                return false;
            }

        }   
    }
}
