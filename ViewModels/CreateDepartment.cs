using System.ComponentModel.DataAnnotations;

namespace AspNetCore203.ViewModels {
    public class CreateDepartment {
        [Required (ErrorMessage = "You must enter department name"), MinLength (4), MaxLength (20)]
        public string Name { get; set; }
    }
}