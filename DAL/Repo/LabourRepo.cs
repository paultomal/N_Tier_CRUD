using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class LabourRepo : IRepo<labour, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public LabourRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(labour obj)
        {
            db.labours.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
            db.labours.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public List<labour> Get()
        {
            return db.labours.ToList();
        }

        public labour Get(int id)
        {
            return db.labours.Find(id);
        }

        public bool Update(labour obj)
        {
            var data = (from p in db.labours where p.labour_id == obj.labour_id select p).FirstOrDefault();
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
