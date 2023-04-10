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
    public class ManagerServices
    {
        public static List<ManagerModel> Get()
        {
            var data = DataAccessFactory.GetManagerAccess().Get();
            var d = new List<ManagerModel>();
            foreach (var s in data)
            {
                d.Add(new ManagerModel()
                {
                    manager_name = s.manager_name,
                    manager_address = s.manager_address,
                    manager_id = s.manager_id,
                    manager_phone = s.manager_phone,
                    user_id = s.user_id

                });

            }
            return d;

        }
        public static ManagerModel Get(int id)
        {
            var data = DataAccessFactory.GetManagerAccess().Get(id);
            var d = new ManagerModel()
            {
                manager_name = data.manager_name,
                manager_address = data.manager_address,
                manager_phone = data.manager_phone,
                manager_id = data.manager_id,
                user_id = data.user_id
            };
            return d;

        }

        public static bool Update(ManagerModel obj)
        {

            var d = new manager()
            {
                manager_id = obj.manager_id,
                manager_name = obj.manager_name,
                manager_address = obj.manager_address,
                manager_phone = obj.manager_phone,
                user_id = obj.user_id

            };
            return DataAccessFactory.GetManagerAccess().Update(d);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetManagerAccess().Delete(id);

        }
        public static List<TripeModel> GetPendingTrip()
        {
            var data = DataAccessFactory.GetTripeAccess().Get();
            var trip = (from p in data where p.status.Equals("pending") || p.status.Equals("processing") select p).ToList();
            var d = new List<TripeModel>();
            foreach (var s in trip)
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
        public static bool UpdateTrip(TripeModel t)
        {
            var d = new tripe()
            {
                start_location = t.start_location,
                end_location = t.end_location,
                customer_id = t.customer_id,
                driver_id = t.driver_id,
                labour_id = t.labour_id,
                labour_number = t.labour_number,
                price = t.price,
                vechile_type = t.vechile_type,
                status = t.status,
                product_discription = t.product_discription,
                tripe_id = t.tripe_id,
                dateandtime = t.dateandtime
            };
           
            return DataAccessFactory.GetTripeAccess().Update(d);
        }
        public static List<LabourModel> LabourList()
        {
            var data = DataAccessFactory.GetLabourAccess().Get();
            var d = new List<LabourModel>();
            foreach (var s in data)
            {
                d.Add(new LabourModel()
                {
                    labour_id=s.labour_id,
                    labour_name =s.labour_name,
                    labour_address =s.labour_address,
                    labour_phone =s.labour_phone,
                    user_id = s.user_id


                });

            }
            return d;
        }
        public static List<DriverModel> DriverPending()
        {
            var data = DataAccessFactory.GetDriverAccess().Get();
            var driver = (from p in data where p.status.Equals("pending") select p).ToList();
            var d = new List<DriverModel>();
            foreach (var s in driver)
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
        public static bool UpdateDriver(DriverModel t)
        {
            var d = new driver()
            {
                driver_id = t.driver_id,
                driver_name = t.driver_name,
                license_no = t.license_no,
                driver_nid = t.driver_nid,
                vechile_no = t.vechile_no,
                vechile_type = t.vechile_type,
                driver_DOB = t.driver_DOB,
                driver_phone = t.driver_phone,
                user_id = t.user_id
            };

            return DataAccessFactory.GetDriverAccess().Update(d);
        }
    }
}
