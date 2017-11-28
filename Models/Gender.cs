using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCore203.Infrastructure;

namespace AspNetCore203.Models {
    [Table ("Gender", Schema = "MST")]
    public class Gender : Entity {
        [Key]
        public Guid GenderId { get; set; }
        public string Name { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}