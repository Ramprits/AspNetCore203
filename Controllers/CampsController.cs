using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Repository;
using AspNet_core_203.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNet_core_203.Controllers {
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