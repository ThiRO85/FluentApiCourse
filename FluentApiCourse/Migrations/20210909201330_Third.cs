using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiCourse.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Details_DetailsID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_OnlineCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_OnsiteCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorID",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_OnlineCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_OnsiteCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "OfficeAsignmentID",
                table: "OfficeAsignments");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "OnlineCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "OnsiteCourseCourseID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DetailsID",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "OfficeAsignments",
                newName: "InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_OfficeAsignments_InstructorID",
                table: "OfficeAsignments",
                newName: "IX_OfficeAsignments_InstructorId");

            migrationBuilder.RenameColumn(
                name: "DetailsID",
                table: "Courses",
                newName: "DetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DetailsID",
                table: "Courses",
                newName: "IX_Courses_DetailsId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OfficeAsignments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OnlineCourseId",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OnsiteCourseId",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Details",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Departments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Courses",
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
                name: "PK_Details",
                table: "Details",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnlineCourseId",
                table: "Instructors",
                column: "OnlineCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnsiteCourseId",
                table: "Instructors",
                column: "OnsiteCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Details_DetailsId",
                table: "Courses",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_OnlineCourseId",
                table: "Instructors",
                column: "OnlineCourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_OnsiteCourseId",
                table: "Instructors",
                column: "OnsiteCourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorId",
                table: "OfficeAsignments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Details_DetailsId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_OnlineCourseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_OnsiteCourseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorId",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfficeAsignments",
                table: "OfficeAsignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_OnlineCourseId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_OnsiteCourseId",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OfficeAsignments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "OnlineCourseId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "OnsiteCourseId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "OfficeAsignments",
                newName: "InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_OfficeAsignments_InstructorId",
                table: "OfficeAsignments",
                newName: "IX_OfficeAsignments_InstructorID");

            migrationBuilder.RenameColumn(
                name: "DetailsId",
                table: "Courses",
                newName: "DetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DetailsId",
                table: "Courses",
                newName: "IX_Courses_DetailsID");

            migrationBuilder.AddColumn<int>(
                name: "OfficeAsignmentID",
                table: "OfficeAsignments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OnlineCourseCourseID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OnsiteCourseCourseID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailsID",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Courses",
                type: "int",
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
                name: "PK_Details",
                table: "Details",
                column: "DetailsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnlineCourseCourseID",
                table: "Instructors",
                column: "OnlineCourseCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OnsiteCourseCourseID",
                table: "Instructors",
                column: "OnsiteCourseCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentID",
                table: "Courses",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Details_DetailsID",
                table: "Courses",
                column: "DetailsID",
                principalTable: "Details",
                principalColumn: "DetailsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_OnlineCourseCourseID",
                table: "Instructors",
                column: "OnlineCourseCourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_OnsiteCourseCourseID",
                table: "Instructors",
                column: "OnsiteCourseCourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeAsignments_Instructors_InstructorID",
                table: "OfficeAsignments",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
