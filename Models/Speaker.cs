using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_core_203.Models {
    [Table ("Speaker", Schema = "dbo")]
    public class Speaker {
        [Key]
        public Guid SpeakerId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterName { get; set; }
        public string GitHubName { get; set; }
        public string Bio { get; set; }
        public string HeadShotUrl { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Talk> Talks { get; set; }
        public Camp Camp { get; set; }

        public byte[] RowVersion { get; set; }
    }
}