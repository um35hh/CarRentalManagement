using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "d3c7ea12-573b-4bf3-8f14-02f6a0098b44", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "975d303b-d666-47a1-9cd7-4b62c0323fa8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e0eed88d-876c-4c91-9d9e-baf5579251a5", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEDm0e0nZ1B2wDUZ9pI7Yj/8S/NFJGTNWS2VVj3/E1JsjPZ8YyrCkjhcgKJcT8V7xPQ==", null, false, "d340846b-3ff5-4756-a754-26d23701d5e2", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 51, 15, 889, DateTimeKind.Local).AddTicks(9364), new DateTime(2022, 12, 2, 11, 51, 15, 892, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 51, 15, 892, DateTimeKind.Local).AddTicks(4679), new DateTime(2022, 12, 2, 11, 51, 15, 892, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreadtedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 2, 11, 51, 15, 894, DateTimeKind.Local).AddTicks(5171), new DateTime(2022, 12, 2, 11, 51, 15, 894, DateTimeKind.Local).AddTicks(5199), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 2, 11, 51, 15, 894, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 12, 2, 11, 51, 15, 894, DateTimeKind.Local).AddTicks(5205), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreadtedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(314), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(320), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(324), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 12, 2, 11, 51, 15, 895, DateTimeKind.Local).AddTicks(328), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 39, 2, 966, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(8007), new DateTime(2022, 12, 2, 9, 39, 2, 968, DateTimeKind.Local).AddTicks(8011) });
        }
    }
}
