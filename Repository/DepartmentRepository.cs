using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Models;

namespace AspNet_core_203.Repository {
    public class DepartmentRepository : IDepartmentRepository {
        private readonly AspNet_core_203DbContext _context;

        public DepartmentRepository (AspNet_core_203DbContext context) {
            _context = context;
        }
        public Task<bool> DeleteDepartmentAsync (Guid id) {
            throw new NotImplementedException ();
        }

        public Task<Department> GetDepartmentAsync (Guid id) {
            throw new NotImplementedException ();
        }

        public async Task<IEnumerable<Department>> GetDepartmentsAsync () {
            return await _context.Departments.ToListAsync ();
        }

        public async Task<Department> InsertDepartmentAsync (Department entity) {
            entity.DepartmentId = Guid.NewGuid ();
            await _context.AddAsync (entity);
            try {
                await _context.SaveChangesAsync ();
            } catch (System.Exception ex) {

                throw new Exception ($"Unable to create new department {ex.Message}");
            }
            return entity;
        }

        public async Task<bool> SaveAsync () {
            return (await _context.SaveChangesAsync () >= 0);
        }

        public Task<bool> UpdateDepartmentAsync (Department entity) {
            throw new NotImplementedException ();
        }
    }
}