using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetcore203.Infrastructure;

namespace AspNetcore203.Models {
    [Table ("Gender", Schema = "MST")]
    public class Gender : Entity {
        [Key]
        public Guid GenderId { get; set; }
        public string Name { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}