using System;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Models;
using AspNetcore203.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetcore203.Controllers {
=======
using AspNetCore203.Models;
using AspNetCore203.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore203.Controllers {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Route ("api/campaign")]
    public class CampaignController : Controller {
        private readonly ICampaignaignRepository _repo;

        public CampaignController (ICampaignaignRepository repository) {
            _repo = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCampaigns () {
            var getCampaigns = await _repo.CampaignsAsync ();
            return Ok (getCampaigns);
        }

        [HttpGet ("{campaignId}", Name = "GetCampaign")]
        public async Task<IActionResult> GetCampaigns (Guid campaignId) {
            var getCampaigns = await _repo.CampaignAsync (campaignId);
            return Ok (getCampaigns);
        }

        [HttpPost]
        public async Task<IActionResult> AddCampaign ([FromBody] Campaign campaign) {
            if (!ModelState.IsValid) {
                return BadRequest ();
            }
            var newCampaign = await _repo.InsertCampaignAsync (campaign);
            if (newCampaign == null) {
                return BadRequest ();
            }
            return Created ("GetCampaign", null);
        }
    }
}