using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e54082ea-c5d2-4a91-8d88-4d42572b2b6c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEP55U/w4Wtt4NXkWGfEyvLlGi9GmDkJTIP0s8V4sl2H1/lkSWzDnJgR8V67V1D4KcQ==", null, false, "cb0a8f70-b352-49af-a1e0-bc19432c3f92", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(4527), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(5791), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(5798), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6602), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6608), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6614), "X5", "System" },
                    { 3, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6618), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6621), new DateTime(2024, 2, 2, 11, 45, 39, 572, DateTimeKind.Local).AddTicks(6623), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
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
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "id",
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
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 44, 8, 764, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 1, 26, 18, 44, 8, 764, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 44, 8, 764, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 1, 26, 18, 44, 8, 764, DateTimeKind.Local).AddTicks(7220) });
        }
    }
}
