using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class LabourWorkRepo : IRepo<labourwork, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public LabourWorkRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(labourwork obj)
        {
            db.labourworks.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
            db.labourworks.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public List<labourwork> Get()
        {
            return db.labourworks.ToList();
        }

        public labourwork Get(int id)
        {
            return db.labourworks.Find(id);
        }

        public bool Update(labourwork obj)
        {
            var data = (from p in db.labourworks where p.labour_work_id == obj.labour_work_id select p).FirstOrDefault();
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
