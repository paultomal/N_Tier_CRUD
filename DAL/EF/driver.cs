//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class driver
    {
        public driver()
        {
            this.tripes = new HashSet<tripe>();
        }
    
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
        public Nullable<int> manager_id { get; set; }
    
        public virtual manager manager { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<tripe> tripes { get; set; }
    }
}
