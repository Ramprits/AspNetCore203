using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
    public class EmployeeRepository : IEmployeeRepository {
        private readonly AspNetcore203DbContext _context;
        private readonly ILogger _Logger;

        public EmployeeRepository (AspNetcore203DbContext context, ILoggerFactory loggerFactory) {
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;

namespace AspNetCore203.Repository {
    public class EmployeeRepository : IEmployeeRepository {
        private readonly AspNetCore203DbContext _context;
        private readonly ILogger _Logger;

        public EmployeeRepository (AspNetCore203DbContext context, ILoggerFactory loggerFactory) {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
            _context = context;
            _Logger = loggerFactory.CreateLogger ("EmployeeRepository");
        }
        public async Task<bool> DeleteEmployeeAsync (Guid id) {
            var deleteEmployee = await _context.Employees.FirstOrDefaultAsync (x => x.EmployeeId == id);
            _context.Remove (deleteEmployee);
            try {
                return (await _context.SaveChangesAsync () > 0 ? true : false);
            } catch (System.Exception exp) {
                _Logger.LogError ($"Error in {nameof(DeleteEmployeeAsync)}: " + exp.Message);
            }
            return false;
        }
        public async Task<bool> EmployeeExist (Guid id) {
            return await _context.Employees.AnyAsync (x => x.EmployeeId == id);
        }
        public async Task<Employee> GetEmployeeAsync (Guid id) {
            return await _context.Employees.FirstOrDefaultAsync (x => x.EmployeeId == id);
        }
        public async Task<IEnumerable<Employee>> GetEmployeesAsync () {
            return await _context.Employees.Include (x => x.Department).ToListAsync ();
        }
        public async Task<Employee> InsertEmployeeAsync (Employee entity) {
            entity.EmployeeId = Guid.NewGuid ();
            var employeeAlreadyExists = _context.Employees.AnyAsync (x => x.EmployeeId == entity.EmployeeId);
            if (await employeeAlreadyExists) {
                throw new Exception ($"employee with {entity.EmployeeId} is already exists !");
            }
            if (entity.FirstName == entity.LastName) {
                throw new Exception ($"{entity.FirstName} and {entity.LastName} couldn't be same.");
            }
            await _context.Employees.AddAsync (entity);
            try {
                await _context.SaveChangesAsync ();
            } catch (System.Exception exp) {
                _Logger.LogError ($"Error in {nameof(InsertEmployeeAsync)}: " + exp.Message);
            }

            return entity;
        }

        public async Task<bool> SaveAsync () {
            return (await _context.SaveChangesAsync () >= 0);
        }

        public Task<bool> UpdateEmployeeAsync (Employee entity) {
            throw new NotImplementedException ();
        }
    }
}