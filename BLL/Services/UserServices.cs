using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EF;

namespace BLL.Services
{
    public class UserServices
    {
        public static List<UserModel> Get()
        {
            var data = DataAccessFactory.GetUSerAccess().Get();
            var d = new List<UserModel>();
            foreach (var s in data)
            {
                d.Add(new UserModel()
                {
                    user_id = s.user_id,
                    email = s.email,
                    password = s.password,
                    user_type = s.user_type,

                });

            }
            return d;

        }
        public static UserModel Get(int id)
        {
            var data = DataAccessFactory.GetUSerAccess().Get(id);
            var d = new UserModel()
            {
                user_id = data.user_id,
                email=data.email,
                password=data.password,
                user_type=data.user_type,
            };
            return d;

        }

        public static bool Update(UserModel obj)
        {

            var d = new user()
            {
                user_id = obj.user_id,
                email = obj.email,
                password = obj.password,
                user_type = obj.user_type,

            };
            return DataAccessFactory.GetUSerAccess().Update(d);

        }
    }
}
