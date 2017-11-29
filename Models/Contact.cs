using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<< HEAD
namespace AspNetcore203.Models {
=======
namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Contact", Schema = "dbo")]
    public class Contact: Entity {
        [Key]
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
       
    }
}