using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_core_203.Repository {
    public class ClientRepository : IClientRepository {
        private readonly AspNet_core_203DbContext _ctx;

        public ClientRepository (AspNet_core_203DbContext ctx) {
            _ctx = ctx;
        }
        public async Task<Client> ClientAsync (Guid clientId) {
            return await _ctx.Clients.FirstOrDefaultAsync (c => c.ClientId == clientId);
        }

        public async Task<bool> ClientExistAsync (Guid clientId) {
            return await _ctx.Clients.AnyAsync (c => c.ClientId == clientId);
        }

        public async Task<IEnumerable<Client>> ClientsAsync () {
            return await _ctx.Clients.ToListAsync ();
        }

        public async Task<bool> DeleteClientAsync (Guid clientId) {
            var deleteClient = await _ctx.Clients.FirstOrDefaultAsync (c => c.ClientId == clientId);
            _ctx.Remove (deleteClient);
            try {
                return await _ctx.SaveChangesAsync () > 0 ? true : false;
            } catch (System.Exception ex) {

                throw new Exception ($"There are problem. Please contact admin {ex.Message}");
            }
        }

        public async Task<Client> InsertClientAsync (Client client) {
            client.ClientId = Guid.NewGuid ();
            await _ctx.AddAsync (client);
            try {
                await _ctx.SaveChangesAsync ();
            } catch (System.Exception ex) {

                throw new Exception ($"There are problem. Please contact admin {ex.Message}");
            }
            return client;
        }

        public async Task<bool> SaveClientAsync () {
            return (await _ctx.SaveChangesAsync () >= 0);
        }
        public Task<bool> UpdateClientAsync (Guid clientId) {
            throw new NotImplementedException ();
        }
    }
}