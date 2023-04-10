using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL.interfaces
{
    public interface IAuth<CLASS>
    {
        CLASS Authenticate(string email, string password);

    }
}
