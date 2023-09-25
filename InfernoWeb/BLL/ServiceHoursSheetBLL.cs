using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfernoWeb.Repository;
using InfernoWeb.Models;
using InfernoWeb.Data;
using Mapster;

namespace InfernoWeb.BLL
{
    public class ServiceHoursSheetBLL
    {
        private UnitOfWork _unitWork = new UnitOfWork();

        public IEnumerable<ServiceHoursSheetDTO> getAll()
        {
            var results = _unitWork.ServiceHoursRepo.getAll().ToList();
            return results.Adapt<List<ServiceHoursSheetDTO>>();
        }

        public IEnumerable<ServiceHoursSheetDTO> getByID(long ID)
        {
            var results = _unitWork.ServiceHoursRepo.getByID(ID).ToList();
            return results.Adapt<List<ServiceHoursSheetDTO>>();
        }

        public long Add(string providerID, string agencyID, float hoursProvided, float hoursOrdered, float overage, string userName, string description)
        {
            var repo = _unitWork.ServiceHoursRepo;
            var id = repo.Add(providerID, agencyID, hoursProvided, hoursOrdered, overage, userName, description);
            return id;            
        }

        public void Delete(long ID)
        {
            var repo = _unitWork.ServiceHoursRepo;
            repo.Delete(ID);
            _unitWork.Save();
        }

        public void Update(ServiceHoursSheetDTO record)
        {
            var recordEF = record.Adapt<ServiceHoursSheet>();
            _unitWork.ServiceHoursRepo.Update(recordEF);
            _unitWork.Save();
        }

        public void Update(long ID, string providerID, string agencyID, float hoursProvided, float hoursOrdered, float overage, string userName, string description)
        {
            var recordEF = new ServiceHoursSheet();
            recordEF.ID = ID;
            recordEF.ProviderID = providerID;
            recordEF.AgencyID = agencyID;
            recordEF.HoursProvided = hoursProvided;
            recordEF.HoursOrdered = hoursOrdered;
            recordEF.Overage = overage;
            recordEF.UserName = userName;
            recordEF.Description = description;

            _unitWork.ServiceHoursRepo.Update(recordEF);
            _unitWork.Save();
        }
    }
}