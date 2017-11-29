using System;
using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetcore203.Repository {
    public class CampaignaignRepository : ICampaignaignRepository {
        private readonly AspNetcore203DbContext _ctx;

        public CampaignaignRepository (AspNetcore203DbContext ctx) {
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore203.Repository {
    public class CampaignaignRepository : ICampaignaignRepository {
        private readonly AspNetCore203DbContext _ctx;

        public CampaignaignRepository (AspNetCore203DbContext ctx) {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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