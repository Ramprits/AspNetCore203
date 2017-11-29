using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
    public class CampRepository : ICampRepository {
        private readonly AspNetcore203DbContext _ctx;

        public CampRepository (AspNetcore203DbContext ctx) {
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;

namespace AspNetCore203.Repository {
    public class CampRepository : ICampRepository {
        private readonly AspNetCore203DbContext _ctx;

        public CampRepository (AspNetCore203DbContext ctx) {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
            _ctx = ctx;
        }
        public async Task<Camp> CampAsync (Guid campId) {
            return await _ctx.Camps.FirstOrDefaultAsync (c => c.CampId == campId);
        }
        public async Task<bool> CampExistAsync (Guid campId) {
            return await _ctx.Camps.AnyAsync (c => c.CampId == campId);
        }
        public async Task<IEnumerable<Camp>> CampsAsync () {
            return await _ctx.Camps.OrderByDescending (c => c.CampId).ToListAsync ();
        }
        public async Task<bool> DeleteCampAsync (Guid campId) {
            var deleteCamp = await _ctx.Camps.FirstOrDefaultAsync (c => c.CampId == campId);
            _ctx.Remove (deleteCamp);
            try {
                return await _ctx.SaveChangesAsync () > 0 ? true : false;
            } catch (System.Exception ex) {

                throw new Exception ($"{ex.Message}");
            }
        }
        public async Task<Camp> InsertCampAsync (Camp camp) {

            await _ctx.Camps.AddAsync (camp);
            try {
                await _ctx.SaveChangesAsync ();
            } catch (System.Exception ex) {

                throw new Exception ($"{ex.Message}");
            }
            return camp;
        }
        public async Task<bool> SaveCampAsync () {
            return (await _ctx.SaveChangesAsync () >= 0);
        }

        public Task<bool> UpdateCampAsync (Guid campId) {
            throw new NotImplementedException ();
        }
    }
}