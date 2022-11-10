using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vacancy.Core.Migrations
{
    public partial class Fefsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aboutvacancies",
                columns: table => new
                {
                    AboutvacancieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutvacancieName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aboutvacancies", x => x.AboutvacancieId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "Fieldactivities",
                columns: table => new
                {
                    FieldactivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldactivityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fieldactivities", x => x.FieldactivityId);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    InformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InformationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "Logotypes",
                columns: table => new
                {
                    LogotypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogotypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logotypes", x => x.LogotypeId);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    RequirementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.RequirementId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogotypeId = table.Column<int>(type: "int", nullable: false),
                    FieldactivityId = table.Column<int>(type: "int", nullable: false),
                    InformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Companies_Fieldactivities_FieldactivityId",
                        column: x => x.FieldactivityId,
                        principalTable: "Fieldactivities",
                        principalColumn: "FieldactivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Informations_InformationId",
                        column: x => x.InformationId,
                        principalTable: "Informations",
                        principalColumn: "InformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Logotypes_LogotypeId",
                        column: x => x.LogotypeId,
                        principalTable: "Logotypes",
                        principalColumn: "LogotypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ExperienceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeId);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resumes_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    VacancieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutvacancieId = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<int>(type: "int", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.VacancieId);
                    table.ForeignKey(
                        name: "FK_Vacancies_Aboutvacancies_AboutvacancieId",
                        column: x => x.AboutvacancieId,
                        principalTable: "Aboutvacancies",
                        principalColumn: "AboutvacancieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vacancies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancies_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "352e0305-43d5-4672-9495-ca2d1e86b5e2", "a68a092e-5a09-4030-8cdd-c5d935f758f3", "User", "USER" },
                    { "47405d77-dd20-41b2-bcfa-1f344c8adb80", "f08567c1-2309-4e22-96f8-09f5d0b58651", "Moderator", "MODERATOR" },
                    { "b5df0da3-0e9a-48cb-a0e0-0784b1c8df22", "7abb5cd8-4731-44b2-a4a3-30311ffbe0a1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "566d2d1d-de5a-4cb9-8bff-fdcc2fcc62c9", 0, "449230c4-fa88-4c70-b55f-a41a89264114", "admin@vacancy.com", true, null, null, false, null, "ADMIN@VACANCY.COM", "ADMIN@VACANCY.COM", "AQAAAAEAACcQAAAAEIqxlUKEfFm/ZAdbmA89z9EH9Y2bKqQOzBrATielpxnDTzi2DTxcrYliYqA+dXxFyQ==", null, false, "15366726-f00f-461f-b7e9-1676260658c4", false, "admin@vacancy.com" },
                    { "da38ab52-7212-4280-96f7-d655ea63cb73", 0, "24740dd8-c355-4fb6-80e1-2c3c49c6e87c", "user@vacancy.com", true, null, null, false, null, "USER@VACANCY.COM", "USER@VACANCY.COM", "AQAAAAEAACcQAAAAECBsON8LENCMjDx9jrnDydkw7nKmHhxv4QKwnfXnXKLCtZJgNBofj+2oB2PykapBdQ==", null, false, "e0b3b2a7-2005-4538-bed8-16719296d798", false, "user@vacancy.com" },
                    { "ded6a91c-1ea8-49a3-a270-fa138ef4075b", 0, "98dbebc8-f4b9-49a8-9e13-30f9e5ddf253", "moder@vacancy.com", true, null, null, false, null, "MODER@VACANCY.COM", "MODER@VACANCY.COM", "AQAAAAEAACcQAAAAEOLswwkZgswtRbLEAdYWPZfe5Tl6kOvjyGR5nwZAaIASjjqDIX6lWz5pBvk0HLJF8Q==", null, false, "2cd6cae2-3fba-4b1a-9903-0786c2e294c2", false, "moder@vacancy.com" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "EducationName" },
                values: new object[] { 1, "Тут ви маєте розмістити свої данні про освіту, коли ви її отримали та по якій спеціальності" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ExperienceId", "ExperienceName" },
                values: new object[] { 1, "Тут ви можете вказати чи є у вас досвід роботи та за бажанням описати чим ви займались раніше" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "SkillName" },
                values: new object[] { 1, "Тут ви можете вказати свої вміння яких ви навчились протягом деякого часу" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "352e0305-43d5-4672-9495-ca2d1e86b5e2", "566d2d1d-de5a-4cb9-8bff-fdcc2fcc62c9" },
                    { "47405d77-dd20-41b2-bcfa-1f344c8adb80", "566d2d1d-de5a-4cb9-8bff-fdcc2fcc62c9" },
                    { "b5df0da3-0e9a-48cb-a0e0-0784b1c8df22", "566d2d1d-de5a-4cb9-8bff-fdcc2fcc62c9" },
                    { "352e0305-43d5-4672-9495-ca2d1e86b5e2", "da38ab52-7212-4280-96f7-d655ea63cb73" },
                    { "352e0305-43d5-4672-9495-ca2d1e86b5e2", "ded6a91c-1ea8-49a3-a270-fa138ef4075b" },
                    { "47405d77-dd20-41b2-bcfa-1f344c8adb80", "ded6a91c-1ea8-49a3-a270-fa138ef4075b" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_FieldactivityId",
                table: "Companies",
                column: "FieldactivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_InformationId",
                table: "Companies",
                column: "InformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LogotypeId",
                table: "Companies",
                column: "LogotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_EducationId",
                table: "Resumes",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ExperienceId",
                table: "Resumes",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_SkillId",
                table: "Resumes",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_UserId",
                table: "Resumes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_AboutvacancieId",
                table: "Vacancies",
                column: "AboutvacancieId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CompanyId",
                table: "Vacancies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_RequirementId",
                table: "Vacancies",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_UserId",
                table: "Vacancies",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Aboutvacancies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "Fieldactivities");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Logotypes");
        }
    }
}
