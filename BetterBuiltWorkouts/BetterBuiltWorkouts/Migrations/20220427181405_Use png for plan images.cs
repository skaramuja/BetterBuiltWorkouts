using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Usepngforplanimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d4dcdb4-e462-4cd3-b649-81d90dd91de1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "710a1ebb-07d1-40cb-b5f5-dea1b53d2646" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "de0bee9a-a679-40a0-8bd3-1f5229cd7a64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "e34e3a7e-a559-44ea-bbc9-74a708b04d77" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "710a1ebb-07d1-40cb-b5f5-dea1b53d2646");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de0bee9a-a679-40a0-8bd3-1f5229cd7a64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e34e3a7e-a559-44ea-bbc9-74a708b04d77");

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
                column: "Image",
                value: "LiftingPlan.png");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 2,
                column: "Image",
                value: "CardioPlan.png");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Image",
                value: "StretchingPlan.png");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "Admin", "ADMIN" },
                    { "7d4dcdb4-e462-4cd3-b649-81d90dd91de1", "7d4dcdb4-e462-4cd3-b649-81d90dd91de1", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "710a1ebb-07d1-40cb-b5f5-dea1b53d2646", 0, "55211522-9cb8-47d4-97dd-0fc2a4ac4e1a", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEPVJXD0330S8bfPyQPNshz/clgvvumtritJSRVMPDeP3Q9Oj3rncv/q7bscQ00Sn9g==", null, false, "c9135632-0406-4605-b137-32ab2895e4b9", false, "drewxcom" },
                    { "de0bee9a-a679-40a0-8bd3-1f5229cd7a64", 0, "e74b91da-04e9-4fd4-bfb6-e43c76653364", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEJH41Xzi72W2XA4IAZUcw0yOx2FT4YtEY9LnPUaCs6rkNccJXpNyKAmMLcZ/7EJ2/g==", null, false, "174504d5-a20e-48f2-bab7-4769fa7cc982", false, "chale" },
                    { "e34e3a7e-a559-44ea-bbc9-74a708b04d77", 0, "8c096957-8825-49d8-8d6c-d6ed5e7dd9a7", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEH6JWIQyCX/Ln7fqVADgimBwD8KvSYEbww7xPC8E93uUf2z9a2ChI6AfX9KKLWZXug==", null, false, "c574fe7b-4df6-4dd4-9214-5f070b12b0f9", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 1,
                column: "Image",
                value: "LiftingPlan");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 2,
                column: "Image",
                value: "CardioPlan");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Image",
                value: "StretchingPlan");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "710a1ebb-07d1-40cb-b5f5-dea1b53d2646" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "de0bee9a-a679-40a0-8bd3-1f5229cd7a64" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6f10cd8-9d76-4533-8db0-e81fd2ad8b54", "e34e3a7e-a559-44ea-bbc9-74a708b04d77" });
        }
    }
}
