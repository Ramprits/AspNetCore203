using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Models;

namespace AspNet_core_203.Repository {
    public interface ICampRepository {
        Task<IEnumerable<Camp>> CampsAsync ();
        Task<Camp> CampAsync (Guid campId);
        Task<Camp> InsertCampAsync (Camp camp);
        Task<bool> UpdateCampAsync (Guid campId);
        Task<bool> DeleteCampAsync (Guid campId);
        Task<bool> CampExistAsync (Guid campId);
        Task<bool> SaveCampAsync ();
    }
}