<<<<<<< HEAD
using AspNetcore203.Models;
using AspNetcore203.ViewModels;
using AutoMapper;

namespace AspNetcore203.Infrastructure {
=======
using AspNetCore203.Models;
using AspNetCore203.ViewModels;
using AutoMapper;

namespace AspNetCore203.Infrastructure {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class Profiler : Profile {
        public Profiler () {
            CreateMap<Employee, EmployeeVm> ().
            ForMember (x => x.Name, opt => opt.MapFrom (c => $"{c.FirstName} {c.LastName}"))
                .ForMember (c => c.Label,
                    opt => opt.MapFrom (x => x.Department.Name)).ReverseMap ();
            CreateMap<CreateEmployee, Employee> ().ReverseMap ();
            CreateMap<Department, DepartmentVm> ().
            ForMember (x => x.Label, opt => opt.MapFrom (x => x.Name)).
            ForMember (x => x.Value, opt => opt.MapFrom (x => x.DepartmentId));
            CreateMap<CreateDepartment, Department> ().ReverseMap ();
            CreateMap<Camp, CampVm> ().ReverseMap ();
            CreateMap<Client, ClientVm> ().ForMember (c => c.Name, opt => opt.MapFrom (c => $"{c.FirstName} {c.LastName}")).ReverseMap ();
            CreateMap<Contact, ContactVm> ().ReverseMap ();
        }
    }
}