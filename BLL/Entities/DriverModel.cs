namespace BLL.Services
{
    public class DriverModel
    {
        public int driver_id { get; set; }
        public string driver_name { get; set; }
        public System.DateTime driver_DOB { get; set; }
        public int driver_phone { get; set; }
        public string license_no { get; set; }
        public string driver_nid { get; set; }
        public int vechile_no { get; set; }
        public string vechile_type { get; set; }
        public string status { get; set; }
        public int user_id { get; set; }
        //public System.Nullable<int> manager_id { get; set; }


    }
}