using BLL.Entities;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthServices
    {
        public static RoleBasedToken Authenticate(string email, string pass)
        {
            var user = DataAccessFactory.GetAuthDataAccess().Authenticate(email, pass);
            //RoleBasedToken r = null;
            if(user == null)
            {
                var dd = new RoleBasedToken();
                dd.token_key = "user not found";
                return dd;
            }
            if (user != null)
            {
                var key = GenToken();
                token token1 = new token();
                token1.token_key = key;
                token1.user_id = user.user_id;
                token1.create_date = DateTime.Now;
                var created_token = DataAccessFactory.GetTokenDataAccess().Create(token1);

                if (user.user_type == "customer")
                {
                    var c = new RoleBasedToken();
                    var customerData = DataAccessFactory.GetCustomerAccess().Get();
                    var data = (from p in customerData where user.user_id == p.user_id select p).SingleOrDefault();

                    c.token_key = created_token.token_key;
                    c.user_id = created_token.user_id;
                    c.logedBased_id = data.customer_id;
                    c.user_role = user.user_type;
                    return c;


                }
                else if (user.user_type == "driver")
                {
                    var d = new RoleBasedToken();
                    var customerData = DataAccessFactory.GetDriverAccess().Get();
                    var data = (from p in customerData where user.user_id == p.user_id select p).SingleOrDefault();

                    d.token_key = created_token.token_key;
                    d.user_id = created_token.user_id;
                    d.logedBased_id = data.driver_id;
                    d.user_role = user.user_type;
                    return d;

                }
                else if (user.user_type == "maanager")
                {
                    var m = new RoleBasedToken();
                    var customerData = DataAccessFactory.GetManagerAccess().Get();
                    var data = (from p in customerData where user.user_id == p.user_id select p).SingleOrDefault();

                    m.token_key = created_token.token_key;
                    m.user_id = created_token.user_id;
                    m.logedBased_id = data.manager_id;
                    m.user_role = user.user_type;
                    return m;

                }
                


                
            }
            
                
                return null;
            

        }
        public static string GenToken()
        {
            Random res = new Random();

            // String of alphabets 
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 40;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(26);

                // Appending the character at the 
                // index to the random string.
                ran = ran + str[x];
            }
            return ran;
        }
        public static bool TokenValidity(string token)
        {
            var tk = DataAccessFactory.GetTokenDataAccess().Get(token);
            if (tk != null && tk.expire_date == null)
            {
                return true;
            }
            return false;

        }
        public static bool Logout(TokenModel tk)
        {
            var d_tk = DataAccessFactory.GetTokenDataAccess().Get(tk.token_key);
            d_tk.expire_date = DateTime.Now;
            return DataAccessFactory.GetTokenDataAccess().Update(d_tk);

        }
    
}
}
