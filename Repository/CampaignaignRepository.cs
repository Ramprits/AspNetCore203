using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_core_203.Repository {
    public class CampaignaignRepository : ICampaignaignRepository {
        private readonly AspNet_core_203DbContext _ctx;

        public CampaignaignRepository (AspNet_core_203DbContext ctx) {
            _ctx = ctx;
        }
        public async Task<Campaign> CampaignAsync (Guid CampaignId) {
            return await _ctx.Campaign.FirstOrDefaultAsync (c => c.CampaignId == CampaignId);
        }

        public async Task<bool> CampaignExistAsync (Guid CampaignId) {
            return await _ctx.Campaign.AnyAsync (c => c.CampaignId == CampaignId);
        }

        public async Task<IEnumerable<Campaign>> CampaignsAsync () {
            return await _ctx.Campaign.ToListAsync ();
        }

        public Task<bool> DeleteCampaignAsync (Guid CampaignId) {
            throw new NotImplementedException ();
        }

        public async Task<Campaign> InsertCampaignAsync (Campaign Campaign) {
            Campaign.CampaignId = Guid.NewGuid ();
            await _ctx.AddAsync (Campaign);
            try {
                await _ctx.SaveChangesAsync ();
            } catch (System.Exception ex) {

                throw new Exception ($"{ex.Message}");
            }
            return Campaign;
        }

        public async Task<bool> SaveCampaignAsync () {
            return await _ctx.SaveChangesAsync () >= 0;
        }

        public Task<bool> UpdateCampaignAsync (Guid CampaignId) {
            throw new NotImplementedException ();
        }
    }
}