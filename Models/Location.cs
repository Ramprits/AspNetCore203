using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<< HEAD
namespace AspNetcore203.Models {
=======
namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Location", Schema = "dbo")]
    public class Location: Entity {
        [Key]
        public Guid LocationId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string CityTown { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Camp> Camp { get; set; }
       
    }
}