using DAL;
using BLL.Entities;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DriverServices
    {
         public static List<DriverModel> Get()
            {
                var data = DataAccessFactory.GetDriverAccess().Get();
                var d = new List<DriverModel>();
                foreach (var s in data)
                {
                    d.Add(new DriverModel()
                    {
                        driver_id = s.driver_id,
                        driver_name = s.driver_name,
                        license_no = s.license_no,
                        driver_nid = s.driver_nid,
                        vechile_no = s.vechile_no,
                        vechile_type = s.vechile_type,
                        driver_DOB = s.driver_DOB,
                        driver_phone = s.driver_phone,
                        user_id = s.user_id

                    });

                }
                return d;
          }

         public static DriverModel Get(int id)
         {
                var data = DataAccessFactory.GetDriverAccess().Get(id);
                var d = new DriverModel()
                {
                    driver_id = data.driver_id,
                    driver_name = data.driver_name,
                    license_no = data.license_no,
                    driver_nid = data.driver_nid,
                    vechile_no = data.vechile_no,
                    vechile_type = data.vechile_type,
                    driver_DOB = data.driver_DOB,
                    driver_phone = data.driver_phone,
                    user_id = data.user_id
                };
                return d;

         }
        //profile update
        public static bool Update(DriverModel obj)
         {
                var d = new driver()
                {
                    driver_id = obj.driver_id,
                    driver_name = obj.driver_name,
                    license_no = obj.license_no,
                    driver_nid = obj.driver_nid,
                    vechile_no = obj.vechile_no,
                    vechile_type = obj.vechile_type,
                    driver_DOB = obj.driver_DOB,
                    status = obj.status,
                    driver_phone = obj.driver_phone,
                    user_id = obj.user_id

                };
                return DataAccessFactory.GetDriverAccess().Update(d);

         }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetDriverAccess().Delete(id);

        }
        public static DriverModel Create(UserModel item)
        {
            //create user
            var u = new user()
            {
                email = item.email,
                password = item.password,
                user_type = "driver"
            };
            DataAccessFactory.GetUSerAccess().Create(u);
            var data = DataAccessFactory.GetUSerAccess().Get();
            var userData = (from p in data where p.email == item.email select p).FirstOrDefault();
            var c = new driver()
            {
                driver_name = "update name",
                driver_DOB = DateTime.Now,
                driver_phone = 01700000000,
                user_id = userData.user_id,
                license_no = "7467247",
                driver_nid ="76665",
                vechile_no =472792,
                vechile_type = "1 ton truck",
                status = "pending"
             };
            var retuntType = DataAccessFactory.GetDriverAccess().Create(c);
            var d = new DriverModel();
            if (retuntType == true)
            {
                var driverData = DataAccessFactory.GetDriverAccess().Get();
                var data2 = (from p in driverData where p.user_id == c.user_id select p).FirstOrDefault();


                d.driver_name = c.driver_name;
                d.license_no = c.license_no;
                d.driver_nid = c.driver_nid;
                d.vechile_no = c.vechile_no;
                d.vechile_type = c.vechile_type;
                d.driver_DOB = c.driver_DOB;
                d.driver_phone = c.driver_phone;
                d.user_id = c.user_id;
                d.status = c.status;
                d.driver_id = data2.driver_id;
                return d;
            }
            return d;
        }
        //trips confirmed bt driver
        public static List<TripeModel> GetMyTrips(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var Trip = (from p in data where id == p.driver_id select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in Trip)
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
        //available posts
        public static List<TripeModel> getalltrip()
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var Trip = (from p in data where (p.status.Equals("pending") )||( p.status.Equals("processing")) select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in Trip)
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

        //get a selecetd trip
        public static List<TripeModel> GetATrip(int id)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var DriverTrip = (from p in data where p.tripe_id == id select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in DriverTrip)
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

        public static bool ConfirmationTrip(TripeModel s)
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var d = new tripe()
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

            };
            return DataAccessFactory.GetTripeAccess().Update(d);

        }

    }
}
