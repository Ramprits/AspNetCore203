using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetcore203.Infrastructure;

namespace AspNetcore203.Models {
    [Table ("Department", Schema = "MST")]
    public class Department : Entity {
        [Key]
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }

    }
}