using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_core_203.Models {
    [Table ("Campaign", Schema = "dbo")]
    public class Campaign {
        [Key]
        public Guid CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string MaximumWishes { get; set; }
        public string Year { get; set; }
        public string IsActive { get; set; }
        public string IsClose { get; set; }
        public string UserLock { get; set; }
        public string ManagerLock { get; set; }

    }
}