using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class UpdateDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d989c372-f55a-438c-bbcd-6976a963f1e3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "827583dc-c2c5-4a5e-a65d-51095566d041" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "9e7fbb7f-ad41-4f6d-a000-1ce3bc6bc0f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "f7c4dc04-2d63-4759-b19e-7d12f7d20e50" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb957f2-d413-4f51-b2a3-8a04a02f4950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "827583dc-c2c5-4a5e-a65d-51095566d041");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e7fbb7f-ad41-4f6d-a000-1ce3bc6bc0f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7c4dc04-2d63-4759-b19e-7d12f7d20e50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a159a9ad-ae35-4d78-8149-b659018862c8", "a159a9ad-ae35-4d78-8149-b659018862c8", "Admin", "ADMIN" },
                    { "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e", "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a3d805ad-8e97-43a2-ad67-04afda1ed40e", 0, "b37eba2f-dbc9-430f-b97f-22a2532de82f", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAECwKwCm+AR3MVlsMgjD7tqot40IxJwxMQufnAAkgd79bpxU6/smoZpN14yne4ueAuw==", null, false, "4e2dbc9e-49a1-48aa-9201-63f597174971", false, "drewxcom" },
                    { "a5a276a1-4299-4aca-8019-b7045723c31c", 0, "ba04f93f-87ab-412c-bd8b-1f08bef8421f", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEK2o1mts62mke37NKf1j8zj3aoh9PO+fA8Ryi39VdzagRthZInHnjCYb2I0FU0qPig==", null, false, "a2e705b1-e939-4572-a254-5d71824536f7", false, "chale" },
                    { "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4", 0, "c32af0f4-d618-4fb5-97f2-1cb96c5adbf4", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEDuBWAfb5UFyo3T1VcXxNVA4/DT4jEC+i5HMgNK3r25EbhNdxHdVRS55q9h4lQBAXQ==", null, false, "97954546-9171-45c2-b7df-cd448d6ac042", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 1,
                column: "Name",
                value: "Sample Strength Plan");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 2,
                column: "Name",
                value: "Sample Cardio Plan");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Name",
                value: "Sample Streching Plan");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a3d805ad-8e97-43a2-ad67-04afda1ed40e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a5a276a1-4299-4aca-8019-b7045723c31c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a3d805ad-8e97-43a2-ad67-04afda1ed40e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a5a276a1-4299-4aca-8019-b7045723c31c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a159a9ad-ae35-4d78-8149-b659018862c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3d805ad-8e97-43a2-ad67-04afda1ed40e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5a276a1-4299-4aca-8019-b7045723c31c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "Admin", "ADMIN" },
                    { "d989c372-f55a-438c-bbcd-6976a963f1e3", "d989c372-f55a-438c-bbcd-6976a963f1e3", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e7fbb7f-ad41-4f6d-a000-1ce3bc6bc0f2", 0, "97bd03a0-fa92-4a85-a8f9-b44b27ebb179", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEKpxCoYWwfzgQzTIz8ZiFW0nPmpXtGhv6othi+d+hKtGPJa5XRyJXpACLQuqtG1suw==", null, false, "fd15f553-6d74-4881-89f5-58c5b2babdc0", false, "drewxcom" },
                    { "827583dc-c2c5-4a5e-a65d-51095566d041", 0, "8311d396-5c94-41db-85cd-841958cc2c10", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEHVf/SRxQmrtuaucdZzPpCgTeY1eU6Y3kDVm32HBr/XxJ8YnbM+7QeNYvB8z2+Pzkw==", null, false, "81fea309-253d-4f18-aa7f-b6df1d3cec57", false, "chale" },
                    { "f7c4dc04-2d63-4759-b19e-7d12f7d20e50", 0, "b0ace98d-dfd9-4055-b2cf-de9646c7c574", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEMCtsYCgp3jHU4xpS9APS91xlN8XrgHHRioPlmXL5uDNr6JVyQXssk4NfCV2BFMOig==", null, false, "2596938a-6235-4cd4-99a1-0d4f04b4290f", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 1,
                column: "Name",
                value: "Example Plan 1");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 2,
                column: "Name",
                value: "Example Plan 2");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Name",
                value: "Example Plan 3");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "9e7fbb7f-ad41-4f6d-a000-1ce3bc6bc0f2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "827583dc-c2c5-4a5e-a65d-51095566d041" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4eb957f2-d413-4f51-b2a3-8a04a02f4950", "f7c4dc04-2d63-4759-b19e-7d12f7d20e50" });
        }
    }
}
