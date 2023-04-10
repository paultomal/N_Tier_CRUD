using DAL;
using BLL.Entities;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LabourServices
    {
        public static List<LabourModel> Get()
        {
            var data = DataAccessFactory.GetLabourAccess().Get();
            var d = new List<LabourModel>();
            foreach (var s in data)
            {
                d.Add(new LabourModel()
                {
                    labour_id = s.labour_id,
                    labour_name = s.labour_name,
                    labour_phone = s.labour_phone,
                    labour_address = s.labour_address,
                    user_id = s.user_id

                });
            }
            return d;
        }

        public static LabourModel Get(int id)
        {
            var data = DataAccessFactory.GetLabourAccess().Get(id);
            var d = new LabourModel()
            {
                labour_id = data.labour_id,
                labour_name = data.labour_name,
                labour_phone = data.labour_phone,
                labour_address = data.labour_address,    
                user_id = data.user_id
            };
            return d;

        }
        public static bool Update(LabourModel obj)
        {
            var d = new labour()
            {
                labour_id = obj.labour_id,
                labour_name = obj.labour_name,
                labour_phone = obj.labour_phone,
                labour_address = obj.labour_address,
                user_id = obj.user_id

            };
            return DataAccessFactory.GetLabourAccess().Update(d);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetLabourAccess().Delete(id);

        }
        public static bool Create(LabourModel obj)
        {
            var c = new labour()
            {
                labour_id = obj.labour_id,
                labour_name = obj.labour_name,
                labour_phone = obj.labour_phone,
                labour_address = obj.labour_address,
                user_id = obj.user_id

            };
            return DataAccessFactory.GetLabourAccess().Create(c);
        }

    }
}
