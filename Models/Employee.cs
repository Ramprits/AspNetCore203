using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetcore203.Infrastructure;

namespace AspNetcore203.Models {
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