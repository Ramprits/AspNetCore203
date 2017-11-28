using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetcore203.Migrations
{
    public partial class AddedBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUnit",
                schema: "security",
                columns: table => new
                {
                    BusinessUnitId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnit", x => x.BusinessUnitId);
                });

            migrationBuilder.CreateTable(
                name: "Modality",
                schema: "security",
                columns: table => new
                {
                    ModalityId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modality", x => x.ModalityId);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                schema: "security",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                schema: "security",
                columns: table => new
                {
                    TrainingId = table.Column<Guid>(nullable: false),
                    AverageCost = table.Column<decimal>(nullable: false),
                    BusinessUnitId = table.Column<Guid>(nullable: false),
                    ConcernedPublic = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DurationInDays = table.Column<int>(nullable: false),
                    EducationalObjectives = table.Column<string>(nullable: true),
                    ExternalLinks = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsCPF = table.Column<string>(nullable: true),
                    IsFree = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    ModalityId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<Guid>(nullable: false),
                    OthersEducationalObjectives = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_Training_BusinessUnit_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalSchema: "security",
                        principalTable: "BusinessUnit",
                        principalColumn: "BusinessUnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Modality_ModalityId",
                        column: x => x.ModalityId,
                        principalSchema: "security",
                        principalTable: "Modality",
                        principalColumn: "ModalityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "security",
                        principalTable: "Organization",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_BusinessUnitId",
                schema: "security",
                table: "Training",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_ModalityId",
                schema: "security",
                table: "Training",
                column: "ModalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_OrganizationId",
                schema: "security",
                table: "Training",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Training",
                schema: "security");

            migrationBuilder.DropTable(
                name: "BusinessUnit",
                schema: "security");

            migrationBuilder.DropTable(
                name: "Modality",
                schema: "security");

            migrationBuilder.DropTable(
                name: "Organization",
                schema: "security");
        }
    }
}
