using System;
using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace AspNetcore203.ViewModels {
=======
namespace AspNetCore203.ViewModels {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public abstract class EmployeeForManipulationDto {
        [Required (ErrorMessage = "You must enter first name")]
        [MaxLength (5, ErrorMessage = "The firstName shouldn't have more than 5 characters.")]
        public virtual string FirstName { get; set; }

        [Required (ErrorMessage = "You must enter last name"), MaxLength (25), MinLength (5)]
        public string LastName { get; set; }
        [Required (ErrorMessage = "You must enter email")]
        public string Email { get; set; }
        [Required (ErrorMessage = "You must enter mobile number")]
        public string Mobile { get; set; }
        public Guid DepartmentId { get; set; }
    }
}