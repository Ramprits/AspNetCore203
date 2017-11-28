using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCore203.Models {
    [Table ("Modality", Schema = "dbo")]
    public class Modality {
        [Key]
        public Guid ModalityId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Training> Training { get; set; }
    }
}