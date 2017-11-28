using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCore203.Models {
    [Table ("BusinessUnit", Schema = "dbo")]
    public class BusinessUnit {
        [Key]
        public Guid BusinessUnitId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Training> Training { get; set; }
    }
}