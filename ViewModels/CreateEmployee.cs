using System;
using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace AspNetcore203.ViewModels {
=======
namespace AspNetCore203.ViewModels {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
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