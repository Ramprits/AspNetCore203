using System;
using System.Linq;
using AspNetcore203.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetcore203.Infrastructure {
    public class AspNetcore203DbContext : IdentityDbContext {
        public AspNetcore203DbContext (DbContextOptions<AspNetcore203DbContext> options) : base (options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Camp> Camps { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Modality> Modalities { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Campaign> Campaign { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema ("security");
            modelBuilder.Entity<Employee> ().Property (e => e.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Department> ().Property (d => d.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Camp> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Location> ().Property (l => l.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Client> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Contact> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();

            base.OnModelCreating (modelBuilder);
        }

    }
}