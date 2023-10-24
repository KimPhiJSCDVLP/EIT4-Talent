using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EIT4Talent.Migrations
{
    public partial class AddCVTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true),
                    Address = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    ReferenceId = table.Column<long>(type: "bigint", nullable: true),
                    Birthday = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Avatar = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    UserType = table.Column<int>(type: "integer", nullable: false),
                    IsFemale = table.Column<bool>(type: "boolean", nullable: false),
                    LinkCV = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    CVStatus = table.Column<int>(type: "integer", nullable: false),
                    isClone = table.Column<bool>(type: "boolean", nullable: true),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVs_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVs_CreatorUserId",
                table: "CVs",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_LastModifierUserId",
                table: "CVs",
                column: "LastModifierUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CVs");
        }
    }
}
