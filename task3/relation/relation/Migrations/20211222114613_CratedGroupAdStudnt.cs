using Microsoft.EntityFrameworkCore.Migrations;

namespace relation.Migrations
{
    public partial class CratedGroupAdStudnt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Groups_GroupID",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "students");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_GroupID",
                table: "students",
                newName: "IX_students_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Groups_GroupId",
                table: "students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Groups_GroupId",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Student",
                newName: "GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_students_GroupId",
                table: "Student",
                newName: "IX_Student_GroupID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Groups_GroupID",
                table: "Student",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
