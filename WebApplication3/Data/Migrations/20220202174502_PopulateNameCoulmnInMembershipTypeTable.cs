using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class PopulateNameCoulmnInMembershipTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate", "Name" },
                values: new Object[] { 1, 0, 0, 0, "PayAsYouGo" });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate", "Name" },
                values: new Object[] { 2, 30, 1, 10, "Monthly" });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate", "Name" },
                values: new Object[] { 3, 90, 3, 15, "Quarterly" });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate", "Name" },
                values: new Object[] { 4, 300, 12, 20, "Annually" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 1, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 2, 30, 1, 10 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 3, 90, 3, 15 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 4, 300, 12, 20 });
        }
    }
}
