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
    public class ActivityLogServices
    {
        public static List<ActivityLogModel> Get()
        {
            var data = DataAccessFactory.GetActivityLogrAccess().Get();
            var d = new List<ActivityLogModel>();
            foreach (var s in data)
            {
                d.Add(new ActivityLogModel()
                {
                    activity_log_id = s.activity_log_id,
                    activity_type = s.activity_type,
                    date = s.date,
                    id = s.id
                });

            }
            return d;

        }
        public static List<ActivityLogModel> Getbyuser(int id)
        {
            var data = DataAccessFactory.GetActivityLogrAccess().Get();
            var data2 = (from p in data where p.id == id select p).ToList();
            var d = new List<ActivityLogModel>();
            foreach (var s in data2)
            {
                d.Add(new ActivityLogModel()
                {
                    activity_log_id = s.activity_log_id,
                    activity_type = s.activity_type,
                    date = s.date,
                    id = s.id
                });

            }
            return d;

        }

        //public static ActivityLogModel GetByuseer(int id)
        //{
        //    var data = DataAccessFactory.GetActivityLogrAccess().Get();
        //    var data2 = (from p in data where p.id == id select p).ToList();
        //    var d = new ActivityLogModel()
        //    {
        //        activity_log_id = data.activity_log_id,
        //        activity_type = data.activity_type,
        //        date = data.date,
        //        id = data.id

        //    };
        //    return d;

        //}
        public static bool Update(ActivityLogModel obj)
        {

            var d = new activitylog()
            {
                activity_log_id = obj.activity_log_id,
                activity_type = obj.activity_type,
                date = obj.date,
                id = obj.id

            };
            return DataAccessFactory.GetActivityLogrAccess().Update(d);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetActivityLogrAccess().Delete(id);

        }
        public static bool Create(ActivityLogModel obj)
        {
            var c = new activitylog()
            {
                //activity_log_id = obj.activity_log_id,
                activity_type = obj.activity_type,
                date = DateTime.Now,
                id = obj.id
            };
            return DataAccessFactory.GetActivityLogrAccess().Create(c);
        }

    }
}
