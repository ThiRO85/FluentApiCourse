using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiCourse.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorId",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OfficeAsignments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "OfficeAsignments",
                newName: "InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_OfficeAsignments_InstructorId",
                table: "OfficeAsignments",
                newName: "IX_OfficeAsignments_InstructorID");

            migrationBuilder.AddColumn<int>(
                name: "OfficeAsignmentID",
                table: "OfficeAsignments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Instructors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Departments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments",
                column: "OfficeAsignmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "InstructorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorID",
                table: "OfficeAsignments",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorID",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "OfficeAsignmentID",
                table: "OfficeAsignments");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "OfficeAsignments",
                newName: "InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_OfficeAsignments_InstructorID",
                table: "OfficeAsignments",
                newName: "IX_OfficeAsignments_InstructorId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OfficeAsignments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorId",
                table: "OfficeAsignments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
