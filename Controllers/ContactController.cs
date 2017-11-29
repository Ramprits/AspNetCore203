using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Infrastructure;
using AspNetcore203.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetcore203.Controllers {
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