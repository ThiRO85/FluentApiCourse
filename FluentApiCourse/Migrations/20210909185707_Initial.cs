using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiCourse.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Budget = table.Column<decimal>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Administrator = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    DetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Days = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.DetailsID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    DetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Details_DetailsID",
                        column: x => x.DetailsID,
                        principalTable: "Details",
                        principalColumn: "DetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    OnlineCourseCourseID = table.Column<int>(nullable: true),
                    OnsiteCourseCourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_OnlineCourseCourseID",
                        column: x => x.OnlineCourseCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_OnsiteCourseCourseID",
                        column: x => x.OnsiteCourseCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfficeAsignments",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    InstructorID1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeAsignments", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_OfficeAsignments_Instructors_InstructorID1",
                        column: x => x.InstructorID1,
                        principalTable: "Instructors",
                        principalColumn: "InstructorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DetailsID",
                table: "Courses",
                column: "DetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnlineCourseCourseID",
                table: "Instructors",
                column: "OnlineCourseCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnsiteCourseCourseID",
                table: "Instructors",
                column: "OnsiteCourseCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeAsignments_InstructorID1",
                table: "OfficeAsignments",
                column: "InstructorID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeAsignments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Details");
        }
    }
}
