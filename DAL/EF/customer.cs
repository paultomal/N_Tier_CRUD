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
    
    public partial class customer
    {
        public customer()
        {
            this.reviews = new HashSet<review>();
            this.tripes = new HashSet<tripe>();
        }
    
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public System.DateTime customer_DOB { get; set; }
        public string customer_address { get; set; }
        public int customer_phone { get; set; }
        public int user_id { get; set; }
    
        public virtual user user { get; set; }
        public virtual ICollection<review> reviews { get; set; }
        public virtual ICollection<tripe> tripes { get; set; }
    }
}
