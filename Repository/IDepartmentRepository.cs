using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
    public interface IDepartmentRepository {

        Task<IEnumerable<Department>> GetDepartmentsAsync ();
        Task<Department> GetDepartmentAsync (Guid id);
        Task<Department> InsertDepartmentAsync (Department entity);
        Task<bool> UpdateDepartmentAsync (Department entity);
        Task<bool> DeleteDepartmentAsync (Guid id);
        Task<bool> SaveAsync ();
    }
}