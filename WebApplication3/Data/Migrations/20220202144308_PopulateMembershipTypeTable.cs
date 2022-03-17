﻿using Microsoft.EntityFrameworkCore.Migrations;
using Vidly.Models;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class PopulateMembershipTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new [] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values:  new Object[] { 1, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 2, 30, 1, 10 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 3, 90, 3, 15 });

            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SingUpFee", "DurationInMonths", "DiscountRate" },
                values: new Object[] { 4, 300, 12, 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
