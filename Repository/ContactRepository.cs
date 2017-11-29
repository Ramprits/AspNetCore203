using System;
using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetcore203.Repository {
    public class ContactRepository : IContactRepository {
        private readonly AspNetcore203DbContext _ctx;

        public ContactRepository (AspNetcore203DbContext context) {
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore203.Repository {
    public class ContactRepository : IContactRepository {
        private readonly AspNetCore203DbContext _ctx;

        public ContactRepository (AspNetCore203DbContext context) {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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