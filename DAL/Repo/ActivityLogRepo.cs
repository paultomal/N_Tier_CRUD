using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ActivityLogRepo : IRepo<activitylog, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public ActivityLogRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(activitylog obj)
        {
            db.activitylogs.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
            db.activitylogs.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public List<activitylog> Get()
        {
            return db.activitylogs.ToList();
        }

        public activitylog Get(int id)
        {

            return db.activitylogs.Find(id);
        }

        public bool Update(activitylog obj)
        {
            var data = (from p in db.activitylogs where p.activity_log_id == obj.activity_log_id select p).FirstOrDefault();
            if (data != null)
            {
                db.Entry(data).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;

            }
            return false;
        }
    }
}
