using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class AdminRepo : IRepo<admin, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public AdminRepo(BagAndBaggageTransportEntities db)

        {
            this.db = db;
        }
        public bool Create(admin obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<admin> Get()
        {
            return db.admins.ToList();
        }

        public admin Get(int id)
        {
            return db.admins.Find(id);
        }

        public bool Update(admin obj)
        {
            var data = (from p in db.admins where p.admin_id == obj.admin_id select p).FirstOrDefault();
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
