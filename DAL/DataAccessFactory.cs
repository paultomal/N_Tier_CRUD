using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.interfaces;
using DAL.Repo;

namespace DAL
{
    public class DataAccessFactory
    {
        public static BagAndBaggageTransportEntities  db = new BagAndBaggageTransportEntities();
        public static IRepo<customer, int, bool> GetCustomerAccess()
        {
            return new CustomerRepo(db);

        }
        public static IRepo<driver, int, bool> GetDriverAccess()
        {
            return new DriverRepo(db);

        }
        public static IRepo<manager, int, bool> GetManagerAccess()
        {
            return new ManagerRepo(db);

        }
        public static IRepo<admin, int, bool> GetAdminAccess()
        {
            return new AdminRepo(db);

        }
        public static IRepo<user, int, bool> GetUSerAccess()
        {
            return new UserRepo(db);

        }
        public static IRepo<labour, int, bool> GetLabourAccess()
        {
            return new LabourRepo(db);

        }
        public static IRepo<labourwork, int, bool> GetLabourWorkAccess()
        {
            return new LabourWorkRepo(db);

        }
        public static IRepo<tripe, int, bool> GetTripeAccess()
        {
            return new TripRepo(db);

        }
        public static IRepo<activitylog, int, bool> GetActivityLogrAccess()
        {
            return new ActivityLogRepo(db);

        }
        public static IRepo<review, int, bool> GetReviewAccess()
        {
            return new ReviewRepo(db);

        }
        public static IAuth<user> GetAuthDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepo<token, string, token> GetTokenDataAccess()
        {
            return new TokenRepo(db);
        }


    }
}
