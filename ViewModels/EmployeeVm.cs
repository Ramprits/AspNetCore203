using System;
using AspNetCore203.Models;

namespace AspNetCore203.ViewModels {
    public class EmployeeVm {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Label { get; set; }
        // public DepartmentVm Department { get; set; }
    }
}