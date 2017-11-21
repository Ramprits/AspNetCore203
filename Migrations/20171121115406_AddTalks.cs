using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetcore203.Migrations
{
    public partial class AddTalks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "security",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "security",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "security",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Speaker",
                schema: "dbo",
                columns: table => new
                {
                    SpeakerId = table.Column<Guid>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    CampId = table.Column<Guid>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    GitHubName = table.Column<string>(nullable: true),
                    HeadShotUrl = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TwitterName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speaker_Camp_CampId",
                        column: x => x.CampId,
                        principalSchema: "dbo",
                        principalTable: "Camp",
                        principalColumn: "CampId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Speaker_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Talk",
                schema: "dbo",
                columns: table => new
                {
                    TalkId = table.Column<Guid>(nullable: false),
                    Abstract = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Level = table.Column<string>(nullable: true),
                    Prerequisites = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SpeakerId = table.Column<Guid>(nullable: true),
                    StartingTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talk", x => x.TalkId);
                    table.ForeignKey(
                        name: "FK_Talk_Speaker_SpeakerId",
                        column: x => x.SpeakerId,
                        principalSchema: "dbo",
                        principalTable: "Speaker",
                        principalColumn: "SpeakerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_CampId",
                schema: "dbo",
                table: "Speaker",
                column: "CampId");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_UserId",
                schema: "dbo",
                table: "Speaker",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Talk_SpeakerId",
                schema: "dbo",
                table: "Talk",
                column: "SpeakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talk",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Speaker",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "security",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "security",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "security",
                table: "AspNetUsers");
        }
    }
}
