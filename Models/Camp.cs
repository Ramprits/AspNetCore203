using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_core_203.Models {
    [Table ("Camp", Schema = "dbo")]
    public class Camp : Entity {
        [Key]
        public Guid CampId { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }

    }
}