using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class ExerciseUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5d361e5-1ee3-42df-b4cd-ef2a9523c358");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "6b81737e-903c-435c-a292-dd390cc91ed4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "86525bfd-83ed-4764-aca0-a2af02581798" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "ab51a321-1df8-4ea9-8796-dbb66dae3764" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "561f82e2-2d71-4a34-839c-520a43b08fe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b81737e-903c-435c-a292-dd390cc91ed4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86525bfd-83ed-4764-aca0-a2af02581798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab51a321-1df8-4ea9-8796-dbb66dae3764");

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
                keyValue: 16,
                column: "Name",
                value: "Gardening");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "Name",
                value: "HIIT");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                column: "Name",
                value: "Elastic Bands or Tubes");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "561f82e2-2d71-4a34-839c-520a43b08fe1", "561f82e2-2d71-4a34-839c-520a43b08fe1", "Admin", "ADMIN" },
                    { "d5d361e5-1ee3-42df-b4cd-ef2a9523c358", "d5d361e5-1ee3-42df-b4cd-ef2a9523c358", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6b81737e-903c-435c-a292-dd390cc91ed4", 0, "c509aca4-eff0-405d-8bfb-3acf12a3fdb2", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEI3rt9TgZi/aON6AbXhGGPECwSDaQlomAtRA66nq5S/8jzUP4PjNa/V0DlVZx6TV3g==", null, false, "f2cd8219-91b4-4c94-9d25-b657423b9f20", false, "drewxcom" },
                    { "ab51a321-1df8-4ea9-8796-dbb66dae3764", 0, "008da146-d641-4ad2-8f54-8fec56f1ef1e", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAECsPmXTLrcsLHwdaLaaSwABwT6dpqKo74H5iiou9oPzJLlwbp0zLofOtjxWccK8GYg==", null, false, "ac258c50-b260-4acc-af11-ab621db66ee8", false, "chale" },
                    { "86525bfd-83ed-4764-aca0-a2af02581798", 0, "21b97125-1bef-400c-a91e-6aee74f8da46", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEKYLC5K4/oq81+qXSlZCIIvLc33gLeWNCqext6tXWT176jlDQFi/d1LyT7MhM1/TqQ==", null, false, "85e69acd-a3ce-4b08-b5a9-5b4b95ee2385", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "Name",
                value: "Gardening and Weeding");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "Name",
                value: "High-Intensity Interval Training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                column: "Name",
                value: "Resistance Exercise with Elastic Bands or Tubes");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "6b81737e-903c-435c-a292-dd390cc91ed4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "ab51a321-1df8-4ea9-8796-dbb66dae3764" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "561f82e2-2d71-4a34-839c-520a43b08fe1", "86525bfd-83ed-4764-aca0-a2af02581798" });
        }
    }
}
