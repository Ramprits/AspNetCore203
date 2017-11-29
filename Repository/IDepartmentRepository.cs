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
    public interface IDepartmentRepository {

        Task<IEnumerable<Department>> GetDepartmentsAsync ();
        Task<Department> GetDepartmentAsync (Guid id);
        Task<Department> InsertDepartmentAsync (Department entity);
        Task<bool> UpdateDepartmentAsync (Department entity);
        Task<bool> DeleteDepartmentAsync (Guid id);
        Task<bool> SaveAsync ();
    }
}