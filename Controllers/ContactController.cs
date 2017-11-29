using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.ViewModels;
=======
using AspNetCore203.Infrastructure;
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