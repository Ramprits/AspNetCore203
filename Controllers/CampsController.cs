using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Repository;
using AspNetcore203.ViewModels;
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Repository;
using AspNetCore203.ViewModels;
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

<<<<<<< HEAD
namespace AspNetcore203.Controllers {
=======
namespace AspNetCore203.Controllers {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Route ("api/camps"), ValidateModel, NoCache]
    public class CampsController : Controller {
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<CampsController> _logger;
        public CampsController (ICampRepository repository, IMapper mapper,
            ILogger<CampsController> logger) {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetCamps () {
            var getCamps = await _repository.CampsAsync ();
            return Ok (_mapper.Map<IEnumerable<CampVm>> (getCamps));
        }
    }
}