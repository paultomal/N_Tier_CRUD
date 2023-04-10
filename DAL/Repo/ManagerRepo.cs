using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ManagerRepo : IRepo<manager, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public ManagerRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(manager obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<manager> Get()
        {
            return db.managers.ToList();
        }

        public manager Get(int id)
        {
            return db.managers.Find(id);
        }

        public bool Update(manager obj)
        {
            var data = (from p in db.managers where p.manager_id == obj.manager_id select p).FirstOrDefault();
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
