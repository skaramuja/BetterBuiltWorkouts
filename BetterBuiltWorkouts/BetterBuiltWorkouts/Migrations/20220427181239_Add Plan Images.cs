using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class AddPlanImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73b341e-6906-486b-8656-89eedfa76a32");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "550c74e1-d2ac-4f06-9a55-2c925d788610" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "9407f8f7-e39f-4cd5-8fcb-2e02a2ddaf28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "f97b7b8c-db52-412a-a1b3-2afbaeb99334" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85236398-5415-4318-b551-5a29fd9d8441");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "550c74e1-d2ac-4f06-9a55-2c925d788610");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9407f8f7-e39f-4cd5-8fcb-2e02a2ddaf28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f97b7b8c-db52-412a-a1b3-2afbaeb99334");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Plans");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85236398-5415-4318-b551-5a29fd9d8441", "85236398-5415-4318-b551-5a29fd9d8441", "Admin", "ADMIN" },
                    { "d73b341e-6906-486b-8656-89eedfa76a32", "d73b341e-6906-486b-8656-89eedfa76a32", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f97b7b8c-db52-412a-a1b3-2afbaeb99334", 0, "4f8e15d1-2163-41e9-99d2-17422e9f8fe8", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEF2P1V9+15ZeoSb78y9d2IMocEQIPSMIW6rX6YwWsIy7zuzVc5RQub349O3VcZBwxw==", null, false, "a67ff664-049b-4c72-9481-b61b26171011", false, "drewxcom" },
                    { "550c74e1-d2ac-4f06-9a55-2c925d788610", 0, "7bfaf8c3-12ed-4809-a171-05d2d446fa12", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAENkr856HZBw45oJ71TdHs4q6uXadDZDl81qMIcI1D2BL8ysxvjJBhbYe7e7gOVRikw==", null, false, "37907c03-ce33-4b06-a068-b0674fdb4e98", false, "chale" },
                    { "9407f8f7-e39f-4cd5-8fcb-2e02a2ddaf28", 0, "1535030d-151c-4b86-9975-e10863881909", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAED3uemmo7WtoWPv+fDXbtfUBRiF02ZK96mYxQZCJAaL6TtLy5sUII6c7fi5qqnN8XA==", null, false, "81e7f843-ac82-45db-9c6e-7b0852cf5f6a", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "f97b7b8c-db52-412a-a1b3-2afbaeb99334" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "550c74e1-d2ac-4f06-9a55-2c925d788610" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85236398-5415-4318-b551-5a29fd9d8441", "9407f8f7-e39f-4cd5-8fcb-2e02a2ddaf28" });
        }
    }
}
