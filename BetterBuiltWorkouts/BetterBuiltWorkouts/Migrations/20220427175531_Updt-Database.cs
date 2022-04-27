using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class UpdtDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00806a94-784f-45d1-98ed-04c7cf63530f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "369f6ad9-f092-4837-a310-bf97ca0124b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "d7de3744-6b02-48a3-a8ff-c68e2ac895fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "dbe17eb9-6bb8-4e7f-916d-f24cc4b1f7d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369f6ad9-f092-4837-a310-bf97ca0124b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7de3744-6b02-48a3-a8ff-c68e2ac895fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbe17eb9-6bb8-4e7f-916d-f24cc4b1f7d7");

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

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "PlanId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                column: "PlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "PlanId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                column: "PlanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "PlanId",
                value: 3);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "Admin", "ADMIN" },
                    { "00806a94-784f-45d1-98ed-04c7cf63530f", "00806a94-784f-45d1-98ed-04c7cf63530f", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "369f6ad9-f092-4837-a310-bf97ca0124b0", 0, "211cbfc6-e8dd-40ad-af27-f63bc8bb7240", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEB7jmgPL1HJl/1fBuV4ybjRgcFK8/V3pQ62bL75CD+XfYd5CX6R0zSd98uRYSrQdvQ==", null, false, "5cdd5a64-99c9-473f-ab54-65702679af61", false, "drewxcom" },
                    { "dbe17eb9-6bb8-4e7f-916d-f24cc4b1f7d7", 0, "30d8f214-e65b-4d06-a13e-17c395ea4e4b", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEOegtIPRN5fcT3E4LOH8k288768g7+H6Kn90hQmDqsdWVp/kOw3jqSxqZwk+3pGBmQ==", null, false, "c649ad9d-d2dd-479e-b55a-b465fb0aaef7", false, "chale" },
                    { "d7de3744-6b02-48a3-a8ff-c68e2ac895fc", 0, "aa481527-f3dd-49e7-a016-e8f719d42482", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEJiieK0AeemELJ4lE/8Zw75tJ/EJcQXN/J5eiahGLAlvVmBw2nggi8b08uHIZ0dguQ==", null, false, "c1dcfbe2-bbed-4c34-9dc5-d959a4dc1bf9", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                column: "PlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                column: "PlanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "PlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                column: "PlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                column: "PlanId",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "369f6ad9-f092-4837-a310-bf97ca0124b0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "dbe17eb9-6bb8-4e7f-916d-f24cc4b1f7d7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d2b83118-4da8-4aeb-b0a8-5ba0f09ea5ba", "d7de3744-6b02-48a3-a8ff-c68e2ac895fc" });
        }
    }
}
