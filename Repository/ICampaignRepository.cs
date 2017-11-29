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
    public interface ICampaignaignRepository {
        Task<IEnumerable<Campaign>> CampaignsAsync ();
        Task<Campaign> CampaignAsync (Guid CampaignId);
        Task<Campaign> InsertCampaignAsync (Campaign Campaign);
        Task<bool> UpdateCampaignAsync (Guid CampaignId);
        Task<bool> DeleteCampaignAsync (Guid CampaignId);
        Task<bool> CampaignExistAsync (Guid CampaignId);
        Task<bool> SaveCampaignAsync ();
    }
}