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
    
    public partial class ServiceHourseSheetAudit
    {
        public long ID { get; set; }
        public Nullable<long> ServiceHoursSheetID { get; set; }
        public string ServiceHoursSheetProviderID { get; set; }
        public string ServiceHoursSheetAgencyID { get; set; }
        public Nullable<System.DateTime> ServiceHoursSheetDateTime { get; set; }
        public Nullable<double> ServiceHoursSheetHoursProvided { get; set; }
        public Nullable<double> ServiceHoursSheetHoursOrdered { get; set; }
        public Nullable<double> ServiceHoursSheetOverage { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
    }
}
