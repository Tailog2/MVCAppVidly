using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Data.Migrations
{
    public partial class RenameAtrPassportIDInAspNetUsersToPassportId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassportID",
                table: "AspNetUsers",
                newName: "PassportId");

            migrationBuilder.AlterColumn<string>(
                name: "PassportId",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassportId",
                table: "AspNetUsers",
                newName: "PassportID");

            migrationBuilder.AlterColumn<string>(
                name: "PassportID",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
