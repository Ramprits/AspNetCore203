using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace AspNetcore203.ViewModels {
=======
namespace AspNetCore203.ViewModels {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class CreateDepartment {
        [Required (ErrorMessage = "You must enter department name"), MinLength (4), MaxLength (20)]
        public string Name { get; set; }
    }
}