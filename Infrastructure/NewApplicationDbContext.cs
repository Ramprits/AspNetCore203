using System;
using System.Linq;
using AspNet_core_203.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNet_core_203.Infrastructure {
    public class AspNet_core_203DbContext : IdentityDbContext {
        public AspNet_core_203DbContext (DbContextOptions<AspNet_core_203DbContext> options) : base (options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Camp> Camps { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema ("security");
            modelBuilder.Entity<Employee> ().Property (e => e.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Department> ().Property (d => d.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Camp> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Location> ().Property (l => l.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Client> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            modelBuilder.Entity<Contact> ().Property (c => c.RowVersion).ValueGeneratedOnAddOrUpdate ().IsConcurrencyToken ();
            foreach (var entityType in modelBuilder.Model.GetEntityTypes ()) {
                modelBuilder.Entity (entityType.Name).Property<DateTime> ("LastModified");
                modelBuilder.Entity (entityType.Name).Ignore ("IsDirty");
            }
            base.OnModelCreating (modelBuilder);
        }
        public override int SaveChanges () {
            foreach (var entry in ChangeTracker.Entries ()
                    .Where (e => e.State == EntityState.Added || e.State == EntityState.Modified)) {
                entry.Property ("LastModified").CurrentValue = DateTime.Now;
            }
            return base.SaveChanges ();
        }
    }
}