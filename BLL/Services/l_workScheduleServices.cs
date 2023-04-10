using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using BLL.Entities;
using DAL;

namespace BLL.Services
{
    public class l_workScheduleServices
    {
        public static List<l_workScheduleModel> Get()
        {
            var data = DataAccessFactory.GetLabourWorkAccess().Get();
            var d = new List<l_workScheduleModel>();
            foreach (var s in data)
            {
                d.Add(new l_workScheduleModel()
                {
                  labour_work_id = s.labour_work_id,
                  status = s.status

                });

            }
            return d;

        }

        public static l_workScheduleModel Get(int id)
        {
            var s = DataAccessFactory.GetLabourWorkAccess().Get(id);
            var d = new l_workScheduleModel()
            {
                labour_work_id = s.labour_work_id,
                status = s.status
            };
            return d;

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetLabourWorkAccess().Delete(id);

        }
        public static bool Create(l_workScheduleModel s)
        {
            var c = new labourwork()
            {
                labour_work_id = s.labour_work_id,
                status = s.status

            };
            return DataAccessFactory.GetLabourWorkAccess().Create(c);
        }
        public static bool Update(l_workScheduleModel s)
        {

            var d = new labourwork()
            {
                labour_work_id = s.labour_work_id,
                status = s.status

            };
            return DataAccessFactory.GetLabourWorkAccess().Update(d);

        }
    }
}
