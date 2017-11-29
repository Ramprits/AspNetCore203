using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;

namespace AspNetcore203.Models {
=======
using AspNetCore203.Infrastructure;

namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Employee", Schema = "MST")]
    public class Employee  : Entity {
        [Key]
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Image { get; set; }
        public Guid? GenderId { get; set; }
        public Gender Gender { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}