using System;
using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Models;

namespace AspNetcore203.Infrastructure {
=======
using AspNetCore203.Models;

namespace AspNetCore203.Infrastructure {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public interface IContactRepository {
        Task<IEnumerable<Contact>> ContactsAsync ();
        Task<Contact> ContactAsync (Guid contactId);
        Task<Contact> InsertContactAsync (Contact contact);
        Task<bool> UpdateContactAsync (Guid contactId);
        Task<bool> DeleteContactAsync (Guid contactId);
        Task<bool> ContactExistAsync (Guid contactId);
        Task<bool> SaveContactAsync ();
    }
}