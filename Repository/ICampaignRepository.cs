using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
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