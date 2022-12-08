using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreadtedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 12, 2, 9, 39, 2, 966, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(7353), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreadtedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(8007), new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(8011), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
