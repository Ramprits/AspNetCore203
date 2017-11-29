using AutoMapper;
using Microsoft.AspNetCore.Mvc;

<<<<<<< HEAD
namespace AspNetcore203.Controllers {
=======
namespace AspNetCore203.Controllers {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class EmployeesCollectionController : Controller {
        private IMapper _mapper;
        public EmployeesCollectionController (IMapper mapper) {
            _mapper = mapper;
        }
    }
}