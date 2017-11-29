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
    [Table ("Department", Schema = "MST")]
    public class Department : Entity {
        [Key]
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }

    }
}