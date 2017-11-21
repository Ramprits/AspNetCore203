using System;
using AspNet_core_203.Models;

namespace AspNet_core_203.ViewModels {
    public class EmployeeVm {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Department Department { get; set; }
    }
}