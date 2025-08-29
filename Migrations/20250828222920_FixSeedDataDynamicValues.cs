using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiWatch.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDataDynamicValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19148c45-17a2-9b50-a242-411e8d17be41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("702f9de1-aeec-4c46-3f58-6008a912f8ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7b0f9d7-5f70-4e94-cb01-4d84cbf52593"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("2b54f7da-c2cf-238c-8529-34aebfda96cb"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("650f0f70-a108-af4b-b9db-92ce2cf633ae"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("d31005e0-1534-6d66-45d1-580ac521784e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76d32438-b3de-0d09-43be-620c377e822a"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "Createdon", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Road" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Waste" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Electricity" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedBy", "Createdon", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "In Progress" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Submitted" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Resolved" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "Createdon", "Email", "FullName", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "PasswordHash", "Role" },
                values: new object[] { new Guid("30000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "SuperAdmin", "System Administrator", false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "$2a$11$.vCYWiCOAuf.t/.fOGHGeeeEcTxmXeeBqGxQRoiMlkyrLmjJz0epu", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "Createdon", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("19148c45-17a2-9b50-a242-411e8d17be41"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 75, DateTimeKind.Utc).AddTicks(9681), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electricity" },
                    { new Guid("702f9de1-aeec-4c46-3f58-6008a912f8ff"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 75, DateTimeKind.Utc).AddTicks(9086), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Road" },
                    { new Guid("c7b0f9d7-5f70-4e94-cb01-4d84cbf52593"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 75, DateTimeKind.Utc).AddTicks(9678), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waste" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedBy", "Createdon", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("2b54f7da-c2cf-238c-8529-34aebfda96cb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 74, DateTimeKind.Utc).AddTicks(6953), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submitted" },
                    { new Guid("650f0f70-a108-af4b-b9db-92ce2cf633ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 74, DateTimeKind.Utc).AddTicks(6957), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved" },
                    { new Guid("d31005e0-1534-6d66-45d1-580ac521784e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 74, DateTimeKind.Utc).AddTicks(6165), false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "Createdon", "Email", "FullName", "IsDeleted", "IsDeletedBy", "IsDeletedOn", "LastModifiedBy", "LastModifiedOn", "PasswordHash", "Role" },
                values: new object[] { new Guid("76d32438-b3de-0d09-43be-620c377e822a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 8, 28, 22, 25, 10, 76, DateTimeKind.Utc).AddTicks(923), "SuperAdmin", "", false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$.vCYWiCOAuf.t/.fOGHGeeeEcTxmXeeBqGxQRoiMlkyrLmjJz0epu", 1 });
        }
    }
}
