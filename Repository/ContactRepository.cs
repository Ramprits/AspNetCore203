using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_core_203.Repository {
    public class ContactRepository : IContactRepository {
        private readonly AspNet_core_203DbContext _ctx;

        public ContactRepository (AspNet_core_203DbContext context) {
            _ctx = context;
        }
        public async Task<Contact> ContactAsync (Guid contactId) {
            return await _ctx.Contacts.FirstOrDefaultAsync (c => c.ContactId == contactId);
        }

        public async Task<bool> ContactExistAsync (Guid contactId) {
            return await _ctx.Contacts.AnyAsync (c => c.ContactId == contactId);
        }

        public async Task<IEnumerable<Contact>> ContactsAsync () {
            return await _ctx.Contacts.ToListAsync ();
        }

        public async Task<bool> DeleteContactAsync (Guid contactId) {
            var deleteContact = await _ctx.Contacts.FirstOrDefaultAsync (c => c.ContactId == contactId);
            try {
                return await _ctx.SaveChangesAsync () > 0 ? true : false;
            } catch (System.Exception ex) {
                throw new Exception ($"{ex.Message}");
            }
        }

        public async Task<Contact> InsertContactAsync (Contact contact) {
            await _ctx.AddAsync (contact);
            try {
                await _ctx.SaveChangesAsync ();
            } catch (System.Exception ex) {

                throw new Exception ($"{ex.Message}");
            }
            return contact;
        }

        public async Task<bool> SaveContactAsync () {
            return (await _ctx.SaveChangesAsync () >= 0);
        }

        public Task<bool> UpdateContactAsync (Guid contactId) {
            throw new NotImplementedException ();
        }
    }
}