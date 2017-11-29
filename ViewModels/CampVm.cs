using System;
using Microsoft.CodeAnalysis;

<<<<<<< HEAD
namespace AspNetcore203.ViewModels {
=======
namespace AspNetCore203.ViewModels {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class CampVm {
        public string Name { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }
    }
}