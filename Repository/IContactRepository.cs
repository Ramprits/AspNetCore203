using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Models;

namespace AspNetcore203.Infrastructure {
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