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