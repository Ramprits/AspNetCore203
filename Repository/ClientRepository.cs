using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetcore203.Repository {
    public class ClientRepository : IClientRepository {
        private readonly AspNetcore203DbContext _ctx;

        public ClientRepository (AspNetcore203DbContext ctx) {
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore203.Repository {
    public class ClientRepository : IClientRepository {
        private readonly AspNetCore203DbContext _ctx;

        public ClientRepository (AspNetCore203DbContext ctx) {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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