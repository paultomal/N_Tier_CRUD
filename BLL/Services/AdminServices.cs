using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using DAL;
using DAL.EF;

namespace BLL.Services
{
    public class AdminServices
    {
        public static List<AdminModel> Get()
        {
            var data = DataAccessFactory.GetAdminAccess().Get();
            var d = new List<AdminModel>();
            foreach (var s in data)
            {
                d.Add(new AdminModel()
                {
                    admin_id = s.admin_id,
                    admin_name = s.admin_name,
                    admin_address = s.admin_address,
                    admin_DOB = s.admin_DOB,
                    user_id = s.user_id,

                });

            }
            return d;

        }
        public static AdminModel Get(int id)
        {
            var data = DataAccessFactory.GetAdminAccess().Get(id);
            var d = new AdminModel()
            {
                admin_name = data.admin_name,
                admin_address = data.admin_address,
                admin_DOB = data.admin_DOB,
                admin_id = data.admin_id,
                user_id = data.user_id
            };
            return d;

        }

        public static bool Update(AdminModel obj)
        {

            var d = new admin()
            {
                admin_id=obj.admin_id,
                admin_name = obj.admin_name,
                admin_address = obj.admin_address,
                admin_DOB = obj.admin_DOB,
                user_id = obj.user_id

            };
            return DataAccessFactory.GetAdminAccess().Update(d);

        }
    }
}
