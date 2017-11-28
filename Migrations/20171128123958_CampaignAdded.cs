using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetcore203.Migrations
{
    public partial class CampaignAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserTokens");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "security",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "MST",
                table: "Gender");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "MST",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "MST",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Talk");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Modality");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "Camp");

            migrationBuilder.DropColumn(
                name: "LastModified",
                schema: "dbo",
                table: "BusinessUnit");

            migrationBuilder.CreateTable(
                name: "Campaign",
                schema: "dbo",
                columns: table => new
                {
                    CampaignId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsClose = table.Column<bool>(nullable: false),
                    ManagerLock = table.Column<bool>(nullable: false),
                    MaximumWishes = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    UserLock = table.Column<bool>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.CampaignId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaign",
                schema: "dbo");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserTokens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserLogins",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetUserClaims",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "security",
                table: "AspNetRoleClaims",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "MST",
                table: "Gender",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "MST",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "MST",
                table: "Department",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Training",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Talk",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Speaker",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Organization",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Modality",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Location",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Contact",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Client",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "Camp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                schema: "dbo",
                table: "BusinessUnit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
