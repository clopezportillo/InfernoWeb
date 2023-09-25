using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfernoWeb.Data;

namespace InfernoWeb.Repository
{
    public class ServiceHoursSheetRepository
    {
        private InfernoEntities _db;

        public ServiceHoursSheetRepository()
        {
            _db = new InfernoEntities();
        }

        public ServiceHoursSheetRepository(InfernoEntities db)
        {
            _db = db;
        }

        public IQueryable<ServiceHoursSheet> getAll()
        {
            return _db.ServiceHoursSheets;
        }

        public IQueryable<ServiceHoursSheet> getByID(long ID)
        {
            return _db.ServiceHoursSheets.Where(p => p.ID == ID);
        }

        public long Add(string providerID, string agencyID, float hoursProvided, float hoursOrdered, float overage, string userName, string description)
        {
            var record = new ServiceHoursSheet();
            record.AgencyID = agencyID;
            record.ProviderID = providerID;
            record.HoursOrdered = hoursOrdered;
            record.HoursProvided = hoursProvided;
            record.Overage = overage;
            record.UserName = userName;
            record.Description = description;

            _db.ServiceHoursSheets.Add(record);
            _db.SaveChanges();
            return record.ID;
        }


        public void Delete(long ID)
        {
            var record = _db.ServiceHoursSheets.FirstOrDefault(p => p.ID == ID);
            if(record != null)
            {
                _db.ServiceHoursSheets.Remove(record);
            }
        }

        public void Update(ServiceHoursSheet record)
        {
            var oldRecord = _db.ServiceHoursSheets.FirstOrDefault(p => p.ID == record.ID);
            if (record != null)
                _db.Entry(oldRecord).CurrentValues.SetValues(record);
        }

    }
}