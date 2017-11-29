using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Repository;
using AspNetcore203.ViewModels;
=======
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
    [Route ("api/client")]
    public class ClientController : Controller {
        private readonly IClientRepository _repo;
        private readonly ILogger<ClientController> _logger;
        private readonly IMapper _mapper;

        public ClientController (IClientRepository repository, ILogger<ClientController> logger, IMapper mapper) {
            _repo = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients () {
            var getClients = await _repo.ClientsAsync ();
            return Ok (_mapper.Map<IEnumerable<ContactVm>> (getClients));
        }
    }
}