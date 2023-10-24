using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EIT4Talent.Migrations
{
    public partial class AddRequestCVTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestCVs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InterviewTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ApplyLevel = table.Column<int>(type: "integer", nullable: true),
                    InterviewLevel = table.Column<int>(type: "integer", nullable: true),
                    FinalLevel = table.Column<int>(type: "integer", nullable: true),
                    HRNote = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    OnboardDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    CVId = table.Column<long>(type: "bigint", nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    EmailSent = table.Column<bool>(type: "boolean", nullable: true),
                    Interviewed = table.Column<bool>(type: "boolean", nullable: true),
                    Percentage = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_RequestCVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestCVs_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVs_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVs_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestCVs_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVs_CreatorUserId",
                table: "RequestCVs",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVs_CVId",
                table: "RequestCVs",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVs_LastModifierUserId",
                table: "RequestCVs",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVs_RequestId",
                table: "RequestCVs",
                column: "RequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestCVs");
        }
    }
}
