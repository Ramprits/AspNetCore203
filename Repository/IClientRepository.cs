using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Models;

namespace AspNet_core_203.Repository {
    public interface IClientRepository {
        Task<IEnumerable<Client>> ClientsAsync ();
        Task<Client> ClientAsync (Guid clientId);
        Task<Client> InsertClientAsync (Client client);
        Task<bool> UpdateClientAsync (Guid clientId);
        Task<bool> DeleteClientAsync (Guid clientId);
        Task<bool> ClientExistAsync (Guid clientId);
        Task<bool> SaveClientAsync ();
    }
}