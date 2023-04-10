using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo : IRepo<token, string, token>
    {
        BagAndBaggageTransportEntities db;
        public TokenRepo(BagAndBaggageTransportEntities db)
        {
            this.db = db;
        }

        public token Create(token obj)
        {
            db.tokens.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<token> Get()
        {
            throw new NotImplementedException();
        }

        public token Get(string token)
        {
            return db.tokens.FirstOrDefault(t => t.token_key.Equals(token));
        }

        public bool Update(token obj)
        {
            var exst = db.tokens.FirstOrDefault(x => x.token_key.Equals(obj.token_key));
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
