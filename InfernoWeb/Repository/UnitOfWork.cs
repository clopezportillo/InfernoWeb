using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfernoWeb.Data;

namespace InfernoWeb.Repository
{
    public class UnitOfWork
    {
        private InfernoEntities _db;
        private ServiceHoursSheetRepository _serviceHoursRepo;
        public ServiceHoursSheetRepository ServiceHoursRepo
        {
            get
            {
                if (_serviceHoursRepo == null)
                    _serviceHoursRepo = new ServiceHoursSheetRepository(_db);
                return _serviceHoursRepo;
            }
        }

        public UnitOfWork()
        {
            _db = new InfernoEntities();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}