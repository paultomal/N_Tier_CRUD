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
    
    public partial class manager
    {
        public manager()
        {
            this.drivers = new HashSet<driver>();
        }
    
        public int manager_id { get; set; }
        public string manager_name { get; set; }
        public string manager_address { get; set; }
        public int manager_phone { get; set; }
        public int user_id { get; set; }
    
        public virtual ICollection<driver> drivers { get; set; }
        public virtual user user { get; set; }
    }
}
