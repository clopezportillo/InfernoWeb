//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfernoWeb.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceHoursSheet
    {
        public long ID { get; set; }
        public string ProviderID { get; set; }
        public Nullable<System.DateTime> Date_Time { get; set; }
        public Nullable<double> HoursProvided { get; set; }
        public Nullable<double> HoursOrdered { get; set; }
        public Nullable<double> Overage { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string AgencyID { get; set; }
    
        public virtual Agency Agency { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
