using System;
using Microsoft.CodeAnalysis;

namespace AspNet_core_203.ViewModels {
    public class CampVm {
        public string Name { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }
        public Location Location { get; set; }
    }
}