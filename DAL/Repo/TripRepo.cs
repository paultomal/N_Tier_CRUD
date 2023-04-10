using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TripRepo : IRepo<tripe, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public TripRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(tripe obj)
        {
            db.tripes.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
            db.tripes.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public List<tripe> Get()
        {
            return db.tripes.ToList();
        }

        public tripe Get(int id)
        {
            return db.tripes.Find(id);
        }

        public bool Update(tripe obj)
        {
            var data = (from p in db.tripes where p.tripe_id == obj.tripe_id select p).FirstOrDefault();
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
