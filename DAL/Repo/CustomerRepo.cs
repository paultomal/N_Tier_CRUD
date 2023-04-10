using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CustomerRepo : IRepo<customer, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public CustomerRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(customer obj)
        {
            db.customers.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {

            var data = (from p in db.tripes where p.customer_id == id select p).ToList();
            if (data != null)
            {
                foreach (var p in data)
                {
                    db.tripes.Remove(p);

                }

            }
            
            db.customers.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;

        }

        public List<customer> Get()
        {
            return db.customers.ToList();
            
        }
       
        public customer Get(int id)
        {
            return db.customers.Find(id);
        }

        public bool Update(customer obj)
        {
            var data = (from p in db.customers where p.customer_id == obj.customer_id select p).FirstOrDefault();
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
