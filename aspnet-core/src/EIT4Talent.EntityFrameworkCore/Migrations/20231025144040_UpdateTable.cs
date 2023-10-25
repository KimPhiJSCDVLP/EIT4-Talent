using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EIT4Talent.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "Requests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubPositionId",
                table: "Requests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "CVs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CVSourceId",
                table: "CVs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubPositionId",
                table: "CVs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    DisplayName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ColorCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Branch_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Capability",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    Note = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    FromType = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_Capability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capability_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Capability_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CVSource",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ReferenceType = table.Column<byte>(type: "smallint", nullable: true),
                    ColorCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
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
                    table.PrimaryKey("PK_CVSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVSource_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVSource_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_EducationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationType_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EducationType_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    BodyMessage = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Type = table.Column<byte>(type: "smallint", nullable: false),
                    CCs = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
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
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTemplate_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmailTemplate_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupSkill",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Default = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_GroupSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupSkill_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupSkill_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ColorCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
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
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Position_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestCVInterview",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    RequestCVId = table.Column<long>(type: "bigint", nullable: false),
                    InterviewId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_RequestCVInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestCVInterview_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVInterview_AbpUsers_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestCVInterview_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVInterview_RequestCVs_RequestCVId",
                        column: x => x.RequestCVId,
                        principalTable: "RequestCVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestCVStatusChangeHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    FromStatus = table.Column<int>(type: "integer", nullable: true),
                    TimeAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ToStatus = table.Column<int>(type: "integer", nullable: false),
                    RequestCVId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_RequestCVStatusChangeHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestCVStatusChangeHistory_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVStatusChangeHistory_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVStatusChangeHistory_RequestCVs_RequestCVId",
                        column: x => x.RequestCVId,
                        principalTable: "RequestCVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestCVStatusHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TimeAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RequestCVId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_RequestCVStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestCVStatusHistory_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVStatusHistory_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVStatusHistory_RequestCVs_RequestCVId",
                        column: x => x.RequestCVId,
                        principalTable: "RequestCVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestCVCapabilityResult",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    RequestCVId = table.Column<long>(type: "bigint", nullable: false),
                    CapabilityId = table.Column<long>(type: "bigint", nullable: false),
                    Factor = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_RequestCVCapabilityResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestCVCapabilityResult_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVCapabilityResult_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestCVCapabilityResult_Capability_CapabilityId",
                        column: x => x.CapabilityId,
                        principalTable: "Capability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestCVCapabilityResult_RequestCVs_RequestCVId",
                        column: x => x.RequestCVId,
                        principalTable: "RequestCVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EducationTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ColorCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
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
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Education_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Education_EducationType_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailStatusHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    CVId = table.Column<long>(type: "bigint", nullable: false),
                    EmailTemplateId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
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
                    table.PrimaryKey("PK_EmailStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailStatusHistory_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmailStatusHistory_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmailStatusHistory_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailStatusHistory_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    GroupSkillId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Skill_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Skill_GroupSkill_GroupSkillId",
                        column: x => x.GroupSkillId,
                        principalTable: "GroupSkill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubPosition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ColorCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    PositionId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_SubPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPosition_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubPosition_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubPosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVEducation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    EducationId = table.Column<long>(type: "bigint", nullable: false),
                    CVId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_CVEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVEducation_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVEducation_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVEducation_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CVEducation_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVSkill",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    SkillId = table.Column<long>(type: "bigint", nullable: false),
                    CVId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_CVSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVSkill_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVSkill_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CVSkill_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CVSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestSkill",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    SkillId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_RequestSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestSkill_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestSkill_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestSkill_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CapabilitySetting",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenantId = table.Column<int>(type: "integer", nullable: true),
                    UserType = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    GuideLine = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    SubPositionId = table.Column<long>(type: "bigint", nullable: false),
                    CapabilityId = table.Column<long>(type: "bigint", nullable: false),
                    Factor = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_CapabilitySetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapabilitySetting_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapabilitySetting_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CapabilitySetting_Capability_CapabilityId",
                        column: x => x.CapabilityId,
                        principalTable: "Capability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapabilitySetting_SubPosition_SubPositionId",
                        column: x => x.SubPositionId,
                        principalTable: "SubPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_BranchId",
                table: "Requests",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SubPositionId",
                table: "Requests",
                column: "SubPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_BranchId",
                table: "CVs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_CVSourceId",
                table: "CVs",
                column: "CVSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_SubPositionId",
                table: "CVs",
                column: "SubPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_CreatorUserId",
                table: "Branch",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_LastModifierUserId",
                table: "Branch",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Capability_CreatorUserId",
                table: "Capability",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Capability_LastModifierUserId",
                table: "Capability",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CapabilitySetting_CapabilityId",
                table: "CapabilitySetting",
                column: "CapabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CapabilitySetting_CreatorUserId",
                table: "CapabilitySetting",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CapabilitySetting_LastModifierUserId",
                table: "CapabilitySetting",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CapabilitySetting_SubPositionId",
                table: "CapabilitySetting",
                column: "SubPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_CreatorUserId",
                table: "CVEducation",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_CVId",
                table: "CVEducation",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_EducationId",
                table: "CVEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_CVEducation_LastModifierUserId",
                table: "CVEducation",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSkill_CreatorUserId",
                table: "CVSkill",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSkill_CVId",
                table: "CVSkill",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSkill_LastModifierUserId",
                table: "CVSkill",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSkill_SkillId",
                table: "CVSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSource_CreatorUserId",
                table: "CVSource",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CVSource_LastModifierUserId",
                table: "CVSource",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_CreatorUserId",
                table: "Education",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_EducationTypeId",
                table: "Education",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_LastModifierUserId",
                table: "Education",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationType_CreatorUserId",
                table: "EducationType",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationType_LastModifierUserId",
                table: "EducationType",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatusHistory_CreatorUserId",
                table: "EmailStatusHistory",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatusHistory_CVId",
                table: "EmailStatusHistory",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatusHistory_EmailTemplateId",
                table: "EmailStatusHistory",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailStatusHistory_LastModifierUserId",
                table: "EmailStatusHistory",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_CreatorUserId",
                table: "EmailTemplate",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_LastModifierUserId",
                table: "EmailTemplate",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSkill_CreatorUserId",
                table: "GroupSkill",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSkill_LastModifierUserId",
                table: "GroupSkill",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_CreatorUserId",
                table: "Position",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_LastModifierUserId",
                table: "Position",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVCapabilityResult_CapabilityId",
                table: "RequestCVCapabilityResult",
                column: "CapabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVCapabilityResult_CreatorUserId",
                table: "RequestCVCapabilityResult",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVCapabilityResult_LastModifierUserId",
                table: "RequestCVCapabilityResult",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVCapabilityResult_RequestCVId",
                table: "RequestCVCapabilityResult",
                column: "RequestCVId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVInterview_CreatorUserId",
                table: "RequestCVInterview",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVInterview_InterviewId",
                table: "RequestCVInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVInterview_LastModifierUserId",
                table: "RequestCVInterview",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVInterview_RequestCVId",
                table: "RequestCVInterview",
                column: "RequestCVId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusChangeHistory_CreatorUserId",
                table: "RequestCVStatusChangeHistory",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusChangeHistory_LastModifierUserId",
                table: "RequestCVStatusChangeHistory",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusChangeHistory_RequestCVId",
                table: "RequestCVStatusChangeHistory",
                column: "RequestCVId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusHistory_CreatorUserId",
                table: "RequestCVStatusHistory",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusHistory_LastModifierUserId",
                table: "RequestCVStatusHistory",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestCVStatusHistory_RequestCVId",
                table: "RequestCVStatusHistory",
                column: "RequestCVId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSkill_CreatorUserId",
                table: "RequestSkill",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSkill_LastModifierUserId",
                table: "RequestSkill",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSkill_RequestId",
                table: "RequestSkill",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSkill_SkillId",
                table: "RequestSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CreatorUserId",
                table: "Skill",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_GroupSkillId",
                table: "Skill",
                column: "GroupSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_LastModifierUserId",
                table: "Skill",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPosition_CreatorUserId",
                table: "SubPosition",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPosition_LastModifierUserId",
                table: "SubPosition",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPosition_PositionId",
                table: "SubPosition",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Branch_BranchId",
                table: "CVs",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_CVSource_CVSourceId",
                table: "CVs",
                column: "CVSourceId",
                principalTable: "CVSource",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_SubPosition_SubPositionId",
                table: "CVs",
                column: "SubPositionId",
                principalTable: "SubPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Branch_BranchId",
                table: "Requests",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_SubPosition_SubPositionId",
                table: "Requests",
                column: "SubPositionId",
                principalTable: "SubPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Branch_BranchId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_CVSource_CVSourceId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_SubPosition_SubPositionId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Branch_BranchId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_SubPosition_SubPositionId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "CapabilitySetting");

            migrationBuilder.DropTable(
                name: "CVEducation");

            migrationBuilder.DropTable(
                name: "CVSkill");

            migrationBuilder.DropTable(
                name: "CVSource");

            migrationBuilder.DropTable(
                name: "EmailStatusHistory");

            migrationBuilder.DropTable(
                name: "RequestCVCapabilityResult");

            migrationBuilder.DropTable(
                name: "RequestCVInterview");

            migrationBuilder.DropTable(
                name: "RequestCVStatusChangeHistory");

            migrationBuilder.DropTable(
                name: "RequestCVStatusHistory");

            migrationBuilder.DropTable(
                name: "RequestSkill");

            migrationBuilder.DropTable(
                name: "SubPosition");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "Capability");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "EducationType");

            migrationBuilder.DropTable(
                name: "GroupSkill");

            migrationBuilder.DropIndex(
                name: "IX_Requests_BranchId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_SubPositionId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_CVs_BranchId",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_CVSourceId",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_SubPositionId",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "SubPositionId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "CVSourceId",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "SubPositionId",
                table: "CVs");
        }
    }
}
