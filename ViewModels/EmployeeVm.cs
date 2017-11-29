using System;
using AspNetcore203.Models;

namespace AspNetcore203.ViewModels {
    public class EmployeeVm {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Label { get; set; }
        // public DepartmentVm Department { get; set; }
    }
}