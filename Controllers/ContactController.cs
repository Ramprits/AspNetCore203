using System.Collections.Generic;
using System.Threading.Tasks;
using AspNet_core_203.Infrastructure;
using AspNet_core_203.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNet_core_203.Controllers {
    [Route ("api/contact")]
    public class ContactController : Controller {
        private readonly IContactRepository _repo;
        private readonly ILogger<ContactController> _logger;
        private readonly IMapper _mapper;

        public ContactController (IContactRepository repository, ILogger<ContactController> logger, IMapper mapper) {
            _repo = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts () {
            var getContacts = await _repo.ContactsAsync ();
            return Ok (_mapper.Map<IEnumerable<ContactVm>> (getContacts));
        }
    }
}