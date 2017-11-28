using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetcore203.Migrations
{
    public partial class ChangeSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Training",
                schema: "security",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Organization",
                schema: "security",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Modality",
                schema: "security",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "BusinessUnit",
                schema: "security",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Training",
                schema: "dbo",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "Organization",
                schema: "dbo",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "Modality",
                schema: "dbo",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "BusinessUnit",
                schema: "dbo",
                newSchema: "security");
        }
    }
}
