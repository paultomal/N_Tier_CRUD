using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EF;

namespace BLL.Services
{
    public class CustomerServices
    {
        public static List<CustomerModel> Get()
        {
            var data = DataAccessFactory.GetCustomerAccess().Get();
            var d = new List<CustomerModel>();
            foreach (var s in data)
            {
                d.Add(new CustomerModel()
                {
                    customer_name = s.customer_name,
                    customer_address = s.customer_address,
                    customer_DOB = s.customer_DOB,
                    customer_id = s.customer_id,
                    customer_phone = s.customer_phone,
                    user_id = s.user_id

                });

            }
            return d;

        }
        //-------------------------------------------------Registretion customer and user both at the same time------------------------------
        public static CustomerModel Create(UserModel item)
        {
            //create user
            var u = new user()
            {
                email = item.email,
                password = item.password,
                user_type = "customer"
            };
            DataAccessFactory.GetUSerAccess().Create(u);
            //geting all users
            var data = DataAccessFactory.GetUSerAccess().Get();
            //geting new created user for user id
            var userData = (from p in data where p.email == item.email select p).FirstOrDefault();
            //create customer empty profile
            var c = new customer()
            {
                customer_name = "update name",
                customer_address = "update address",
                customer_DOB = DateTime.Now,
                customer_phone = 01700000000,
                user_id = userData.user_id

            };
            var retuntType = DataAccessFactory.GetCustomerAccess().Create(c);
            //if customer created than getting all customers for finding customer id of new customer
            var d = new CustomerModel();
            if (retuntType == true)
            {
                var CustomerData = DataAccessFactory.GetCustomerAccess().Get();
                var data2 = (from p in CustomerData where p.user_id == c.user_id select p).FirstOrDefault();


                d.customer_name = c.customer_name;
                d.customer_address = c.customer_address;
                d.customer_DOB = c.customer_DOB;
                d.customer_id = c.customer_id;
                d.customer_phone = c.customer_phone;
                d.user_id = c.user_id;
                d.customer_id = data2.customer_id;


                return d;

            }
            return d;
        }

        //get customer profile
        public static CustomerModel Get( int id)
        {
            var data = DataAccessFactory.GetCustomerAccess().Get(id);
            var d = new CustomerModel()
            {   customer_name = data.customer_name,
                customer_address = data.customer_address,
                customer_DOB = data.customer_DOB,
                customer_id = data.customer_id,
                customer_phone = data.customer_phone,
                user_id = data.user_id
            };
            return d;
            
        }
        //delet customer (Before delete customer delete forenKey of customer)
        public static bool Delete(int id)
        {
            
            return DataAccessFactory.GetCustomerAccess().Delete(id);

        }
        //-----------------------------------------------update customer database-----------------------------------------------------------
        public static bool Update(CustomerModel obj)
        {

            var d = new customer()
            {
                customer_id = obj.customer_id,
                customer_name = obj.customer_name,
                customer_address = obj.customer_address,
                customer_DOB = obj.customer_DOB,
                customer_phone = obj.customer_phone,
                user_id = obj.user_id

            };
            var c = new activitylog()
            {
                //activity_log_id = obj.activity_log_id,
                activity_type = "update profile",
                date = DateTime.Now,
                id = obj.user_id
            };
            DataAccessFactory.GetActivityLogrAccess().Create(c);
            return DataAccessFactory.GetCustomerAccess().Update(d);

        }
        //---------------------------------------------get all trip oparetion about logged customer--------------------------------------
        public static List<TripeModel> GetAllTripOparetion(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var customerTrip = (from p in data where id == p.customer_id select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in customerTrip)
            {
                d.Add(new TripeModel()
                {
                    start_location = s.start_location,
                    end_location = s.end_location,
                    customer_id = s.customer_id,
                    driver_id = s.driver_id,
                    labour_id = s.labour_id,
                    labour_number = s.labour_number,
                    price = s.price,
                    vechile_type = s.vechile_type,
                    status = s.status,
                    product_discription = s.product_discription,
                    tripe_id = s.tripe_id,
                    dateandtime = s.dateandtime


                });

            }
            return d;

        }
        //---------------------------------------------get pending and processing trip oparetion about logged customer--------------------------------------
        public static List<TripeModel> GetPendingTrip(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var customerTrip = (from p in data where p.customer_id == id && (p.status.Equals("pending") || p.status.Equals("processing")) select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in customerTrip)
            {
                d.Add(new TripeModel()
                {
                    start_location = s.start_location,
                    end_location = s.end_location,
                    customer_id = s.customer_id,
                    driver_id = s.driver_id,
                    labour_id = s.labour_id,
                    labour_number = s.labour_number,
                    price = s.price,
                    vechile_type = s.vechile_type,
                    status = s.status,
                    product_discription = s.product_discription,
                    tripe_id = s.tripe_id,
                    dateandtime = s.dateandtime


                });

            }
            return d;

        }
        //---------------------------------------------get confirmed trip oparetion about logged customer--------------------------------------
        public static List<TripeModel> GetConfirmedTrip(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var customerTrip = (from p in data where p.customer_id == id && p.status.Equals("confirmed") select p).ToList();
            var confimer = new List<TripeModel>();
            foreach (var s in customerTrip)
            {
                confimer.Add(new TripeModel()
                {
                    start_location = s.start_location,
                    end_location = s.end_location,
                    customer_id = s.customer_id,
                    driver_id = s.driver_id,
                    labour_id = s.labour_id,
                    labour_number = s.labour_number,
                    price = s.price,
                    vechile_type = s.vechile_type,
                    status = s.status,
                    product_discription = s.product_discription,
                    tripe_id = s.tripe_id,
                    dateandtime = s.dateandtime


                });

            }
            return confimer;

        }
        //---------------------------------------------get finished trip oparetion about logged customer--------------------------------------
        public static List<TripeModel> GetFinishedTrip(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var customerTrip = (from p in data where p.customer_id == id && p.status.Equals("finished") select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in customerTrip)
            {
                d.Add(new TripeModel()
                {
                    start_location = s.start_location,
                    end_location = s.end_location,
                    customer_id = s.customer_id,
                    driver_id = s.driver_id,
                    labour_id = s.labour_id,
                    labour_number = s.labour_number,
                    price = s.price,
                    vechile_type = s.vechile_type,
                    status = s.status,
                    product_discription = s.product_discription,
                    tripe_id = s.tripe_id,
                    dateandtime = s.dateandtime


                });

            }
            return d;

        }
        //----------------------------------delete trip by customer--------------------------------------
        public static bool DeleteTrip(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get(id);
            if (data.status == "pending" || data.status == "pocessing")
            {
                return DataAccessFactory.GetTripeAccess().Delete(id);
            }
            else
            {
                return false;
            }


        }
        //--------------------------------------------create trip by customer---------------------------------------------------------
        public static bool createTrip(TripeModel obj)
        {
            //create trip
            var u = new tripe()
            {

                end_location = obj.end_location,
                start_location = obj.start_location,
                vechile_type = obj.vechile_type,
                price = 800,
                labour_number = obj.labour_number,
                dateandtime = obj.dateandtime,
                product_discription = obj.product_discription,
                status = "pending",
                customer_id = obj.customer_id
            };
            
            return DataAccessFactory.GetTripeAccess().Create(u);
        }
        public static List<TripeModel> getalltrip()
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            //var customerTrip = (from p in data where id == p.customer_id select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in data)
            {
                d.Add(new TripeModel()
                {
                    start_location = s.start_location,
                    end_location = s.end_location,
                    customer_id = s.customer_id,
                    driver_id = s.driver_id,
                    labour_id = s.labour_id,
                    labour_number = s.labour_number,
                    price = s.price,
                    vechile_type = s.vechile_type,
                    status = s.status,
                    product_discription = s.product_discription,
                    tripe_id = s.tripe_id,
                    dateandtime = s.dateandtime


                });

            }
            return d;

        }


    }
}
