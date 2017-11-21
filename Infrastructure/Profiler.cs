using AutoMapper;
using AspNet_core_203.Models;
using AspNet_core_203.ViewModels;

namespace AspNet_core_203.Infrastructure {
    public class Profiler : Profile {
        public Profiler () {
            CreateMap<Employee, EmployeeVm> ().ReverseMap ();
            CreateMap<CreateEmployee, Employee> ().ReverseMap ();
            CreateMap<Department, DepartmentVm> ().
            ForMember (x => x.Label, opt => opt.MapFrom (x => x.Name)).
            ForMember (x => x.Value, opt => opt.MapFrom (x => x.DepartmentId));
            CreateMap<CreateDepartment, Department> ().ReverseMap ();
            CreateMap<Camp, CampVm> ().ForMember (c => c.Location, opt => opt.ResolveUsing (c => new Location () {
            })).ReverseMap ();
        }
    }
}