using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Infrastructure;
using AspNetcore203.Repository;
using AspNetcore203.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetcore203.Controllers {
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