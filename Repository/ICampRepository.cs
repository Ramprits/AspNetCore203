using System;
using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
=======
using AspNetCore203.Models;

namespace AspNetCore203.Repository {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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