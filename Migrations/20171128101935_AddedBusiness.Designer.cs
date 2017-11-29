﻿// <auto-generated />
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
=======
using AspNetCore203.Infrastructure;
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace AspNetcore203.Migrations
{
<<<<<<< HEAD
    [DbContext(typeof(AspNetcore203DbContext))]
=======
    [DbContext(typeof(AspNetCore203DbContext))]
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    [Migration("20171128101935_AddedBusiness")]
    partial class AddedBusiness
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("security")
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.BusinessUnit", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.BusinessUnit", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("BusinessUnitId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("BusinessUnitId");

                    b.ToTable("BusinessUnit");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Camp", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Camp", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("CampId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("Length");

                    b.Property<Guid?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camp","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Client", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Client", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ClientId");

                    b.ToTable("Client","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Contact", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Contact", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Subject");

                    b.HasKey("ContactId");

                    b.ToTable("Contact","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Department", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Department", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("DepartmentId");

                    b.ToTable("Department","MST");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Employee", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Employee", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<Guid>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<Guid?>("GenderId");

                    b.Property<string>("Image");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenderId");

                    b.ToTable("Employee","MST");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Gender", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Gender", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("GenderId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<byte[]>("RowVersion");

                    b.HasKey("GenderId");

                    b.ToTable("Gender","MST");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Location", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Location", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Address3");

                    b.Property<string>("CityTown");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("PostalCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("StateProvince");

                    b.HasKey("LocationId");

                    b.ToTable("Location","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Modality", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Modality", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("ModalityId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("ModalityId");

                    b.ToTable("Modality");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Organization", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Organization", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("OrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organization");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Speaker", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Speaker", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("SpeakerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<Guid?>("CampId");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GitHubName");

                    b.Property<string>("HeadShotUrl");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<byte[]>("RowVersion");

                    b.Property<string>("TwitterName");

                    b.Property<string>("UserId");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("SpeakerId");

                    b.HasIndex("CampId");

                    b.HasIndex("UserId");

                    b.ToTable("Speaker","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Talk", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Talk", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("TalkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract");

                    b.Property<string>("Category");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Level");

                    b.Property<string>("Prerequisites");

                    b.Property<string>("Room");

                    b.Property<byte[]>("RowVersion");

                    b.Property<Guid?>("SpeakerId");

                    b.Property<DateTime>("StartingTime");

                    b.Property<string>("Title");

                    b.HasKey("TalkId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talk","dbo");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Training", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.Training", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.Property<Guid>("TrainingId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AverageCost");

                    b.Property<Guid>("BusinessUnitId");

                    b.Property<string>("ConcernedPublic");

                    b.Property<string>("Description");

                    b.Property<int>("DurationInDays");

                    b.Property<string>("EducationalObjectives");

                    b.Property<string>("ExternalLinks");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("IsCPF");

                    b.Property<bool>("IsFree");

                    b.Property<string>("Language");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Location");

                    b.Property<Guid>("ModalityId");

                    b.Property<string>("Name");

                    b.Property<Guid>("OrganizationId");

                    b.Property<string>("OthersEducationalObjectives");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("TrainingId");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("ModalityId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime>("LastModified");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.ApplicationUser", b =>
=======
            modelBuilder.Entity("AspNetCore203.Models.ApplicationUser", b =>
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Camp", b =>
                {
                    b.HasOne("AspNetcore203.Models.Location", "Location")
=======
            modelBuilder.Entity("AspNetCore203.Models.Camp", b =>
                {
                    b.HasOne("AspNetCore203.Models.Location", "Location")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Camp")
                        .HasForeignKey("LocationId");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Employee", b =>
                {
                    b.HasOne("AspNetcore203.Models.Department", "Department")
=======
            modelBuilder.Entity("AspNetCore203.Models.Employee", b =>
                {
                    b.HasOne("AspNetCore203.Models.Department", "Department")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("AspNetcore203.Models.Gender", "Gender")
=======
                    b.HasOne("AspNetCore203.Models.Gender", "Gender")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Employees")
                        .HasForeignKey("GenderId");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Speaker", b =>
                {
                    b.HasOne("AspNetcore203.Models.Camp", "Camp")
                        .WithMany()
                        .HasForeignKey("CampId");

                    b.HasOne("AspNetcore203.Models.ApplicationUser", "User")
=======
            modelBuilder.Entity("AspNetCore203.Models.Speaker", b =>
                {
                    b.HasOne("AspNetCore203.Models.Camp", "Camp")
                        .WithMany()
                        .HasForeignKey("CampId");

                    b.HasOne("AspNetCore203.Models.ApplicationUser", "User")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany()
                        .HasForeignKey("UserId");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Talk", b =>
                {
                    b.HasOne("AspNetcore203.Models.Speaker", "Speaker")
=======
            modelBuilder.Entity("AspNetCore203.Models.Talk", b =>
                {
                    b.HasOne("AspNetCore203.Models.Speaker", "Speaker")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Talks")
                        .HasForeignKey("SpeakerId");
                });

<<<<<<< HEAD
            modelBuilder.Entity("AspNetcore203.Models.Training", b =>
                {
                    b.HasOne("AspNetcore203.Models.BusinessUnit", "BusinessUnit")
=======
            modelBuilder.Entity("AspNetCore203.Models.Training", b =>
                {
                    b.HasOne("AspNetCore203.Models.BusinessUnit", "BusinessUnit")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Training")
                        .HasForeignKey("BusinessUnitId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("AspNetcore203.Models.Modality", "Modality")
=======
                    b.HasOne("AspNetCore203.Models.Modality", "Modality")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Training")
                        .HasForeignKey("ModalityId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("AspNetcore203.Models.Organization", "Organization")
=======
                    b.HasOne("AspNetCore203.Models.Organization", "Organization")
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                        .WithMany("Training")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
