using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNet_core_203.Infrastructure;

namespace AspNet_core_203.Models {
    [Table ("Department", Schema = "MST")]
    public class Department : Entity {
        [Key]
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }

    }
}