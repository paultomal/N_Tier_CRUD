using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ReviewRepo : IRepo<review, int, bool>
    {
        BagAndBaggageTransportEntities db;
        public ReviewRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }
        public bool Create(review obj)
        {
            db.reviews.Add(obj);
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public bool Delete(int id)
        {
           
            db.reviews.Remove(Get(id));
            var rs = db.SaveChanges();
            return rs > 0;
        }

        public List<review> Get()
        {
            return db.reviews.ToList();
        }

        public review Get(int id)
        {
            return db.reviews.Find(id);
        }

        public bool Update(review obj)
        {
            var data = (from p in db.reviews where p.customer_id == obj.customer_id select p).FirstOrDefault();
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
