using System;
namespace AspNetCore203.Models {
    public class Entity {
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}