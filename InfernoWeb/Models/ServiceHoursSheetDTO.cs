using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfernoWeb.Models
{
    public class ServiceHoursSheetDTO
    {
        public long ID { get; set; }
        public string ProviderID { get; set; }
        public DateTime Date_Time { get; set; }
        public float HoursProvided { get; set; }
        public float HoursOrdered { get; set; }
        public float Overage { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string AgencyID { get; set; }
    }
}