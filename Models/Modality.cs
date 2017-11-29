using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<< HEAD
namespace AspNetcore203.Models {
=======
namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Modality", Schema = "dbo")]
    public class Modality {
        [Key]
        public Guid ModalityId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Training> Training { get; set; }
    }
}