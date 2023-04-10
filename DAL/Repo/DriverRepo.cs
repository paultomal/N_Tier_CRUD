using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DriverRepo : IRepo<driver, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public DriverRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }     
        public List<driver> Get()
        {
            return db.drivers.ToList();
        }
        public driver Get(int id)
        {
            return db.drivers.Find(id);
        }
        public bool Update(driver obj)
        {
            var data = (from p in db.drivers where p.driver_id == obj.driver_id select p).FirstOrDefault();
            if (data != null)
            {
                db.Entry(data).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;

            }
            return false;
        }

        public bool Create(driver obj)
        {
            db.drivers.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
            db.drivers.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;

        }
    }
}
