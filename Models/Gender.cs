using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;

namespace AspNetcore203.Models {
=======
using AspNetCore203.Infrastructure;

namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Gender", Schema = "MST")]
    public class Gender : Entity {
        [Key]
        public Guid GenderId { get; set; }
        public string Name { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}