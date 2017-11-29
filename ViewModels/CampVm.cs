using System;
using Microsoft.CodeAnalysis;

namespace AspNetcore203.ViewModels {
    public class CampVm {
        public string Name { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }
    }
}