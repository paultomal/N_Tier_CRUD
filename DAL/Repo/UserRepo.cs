using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<user, int, bool>,IAuth<user>
    {
        BagAndBaggageTransportEntities db;
        public UserRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }

        public user Authenticate(string email, string password)
        {
            return db.users.FirstOrDefault(u => u.email.Equals(email)
            && u.password.Equals(password));
        }

        public bool Create(user obj)
        {
            db.users.Add(obj);
            var rs = db.SaveChanges();

            return rs > 0;
            
            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }

        public user Get(int id)
        {
            return db.users.Find(id);
        }

        public bool Update(user obj)
        {
            var data = (from p in db.users where p.user_id == obj.user_id select p).FirstOrDefault();
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
