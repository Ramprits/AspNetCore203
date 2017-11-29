using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetcore203.ViewModels {
    public class CreateEmployee : EmployeeForManipulationDto {
        public override string FirstName {
            get {
                return base.FirstName;
            }

            set {
                base.FirstName = value;
            }
        }
    }
}