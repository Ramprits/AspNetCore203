using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<< HEAD
namespace AspNetcore203.Models {
=======
namespace AspNetCore203.Models {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Table ("Campaign", Schema = "dbo")]
    public class Campaign {
        [Key]
        public Guid CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int MaximumWishes { get; set; }
        public DateTime Year { get; set; }
        public bool IsActive { get; set; }
        public bool IsClose { get; set; }
        public bool UserLock { get; set; }
        public bool ManagerLock { get; set; }

    }
}