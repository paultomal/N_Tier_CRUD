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
    
    public partial class user
    {
        public user()
        {
            this.admins = new HashSet<admin>();
            this.customers = new HashSet<customer>();
            this.drivers = new HashSet<driver>();
            this.labours = new HashSet<labour>();
            this.managers = new HashSet<manager>();
            this.tokens = new HashSet<token>();
        }
    
        public int user_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
    
        public virtual ICollection<admin> admins { get; set; }
        public virtual ICollection<customer> customers { get; set; }
        public virtual ICollection<driver> drivers { get; set; }
        public virtual ICollection<labour> labours { get; set; }
        public virtual ICollection<manager> managers { get; set; }
        public virtual ICollection<token> tokens { get; set; }
    }
}
