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
    public interface IEmployeeRepository {
        Task<IEnumerable<Employee>> GetEmployeesAsync ();
        Task<Employee> GetEmployeeAsync (Guid id);
        Task<Employee> InsertEmployeeAsync (Employee entity);
        Task<bool> UpdateEmployeeAsync (Employee entity);
        Task<bool> DeleteEmployeeAsync (Guid id);
        Task<bool> EmployeeExist (Guid id);
        Task<bool> SaveAsync ();
    }
}