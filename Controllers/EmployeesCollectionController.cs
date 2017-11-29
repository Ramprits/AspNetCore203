using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspNetcore203.Controllers {
    public class EmployeesCollectionController : Controller {
        private IMapper _mapper;
        public EmployeesCollectionController (IMapper mapper) {
            _mapper = mapper;
        }
    }
}