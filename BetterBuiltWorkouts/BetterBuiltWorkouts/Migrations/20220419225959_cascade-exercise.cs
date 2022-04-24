using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class cascadeexercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Plans_PlanId",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90a52f39-2660-4948-bcbc-77d12b727d3f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "3e45d3e9-4d3c-4e20-9ace-e3d32a554134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "6de9e11d-f012-450a-8dc2-8ae58d510403" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "f0f0ae27-d4f3-45ea-a383-e0a919a41462" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a299da0-8cce-487c-9340-acb0f9f5ae04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e45d3e9-4d3c-4e20-9ace-e3d32a554134");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6de9e11d-f012-450a-8dc2-8ae58d510403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0f0ae27-d4f3-45ea-a383-e0a919a41462");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "80d17830-47a0-40fe-a89b-05ffe4a901f8", "Admin", "ADMIN" },
                    { "40622de6-d0aa-47f9-a3e6-b89b3156b92c", "40622de6-d0aa-47f9-a3e6-b89b3156b92c", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fceaf3a3-ff99-42e6-8d10-b11b42288c96", 0, "aa0a64f4-76b2-4d3c-9caf-0641b16fbb09", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEJkCqDRb5F5TE0LH2OnmykiLIHnb/+11qTzjtiaxtvtwSy2L7cyEN4y2aYfkBKzO4Q==", null, false, "c10739d8-1b51-419f-bf93-99f99f2f507a", false, "drewxcom" },
                    { "9c40a624-6363-4272-aadc-4925653e6d23", 0, "7182ee06-aa15-4de6-9746-89448f2d8583", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEGmSceuZjCA7kucs3fnS587TdTKea3/6NerUdHtfz5IIC8LFvIWermWlwAe3xjJI4g==", null, false, "272af3f1-7237-46fa-9718-72e2a20bf5fa", false, "chale" },
                    { "263913a3-9deb-4331-85c7-d0db39175713", 0, "cc40be50-db3e-4fbf-b7c3-ad19cc1f31a2", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEEZWQJd8zyDzo1NhZpghpT+Qv8lJeDPfoQ8HFaSb4GWJs6THmrZ+473Th8JldQmEtQ==", null, false, "84620331-a961-48ec-a49f-71d107cb4cff", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "fceaf3a3-ff99-42e6-8d10-b11b42288c96" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "9c40a624-6363-4272-aadc-4925653e6d23" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "263913a3-9deb-4331-85c7-d0db39175713" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Plans_PlanId",
                table: "Exercises",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Plans_PlanId",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40622de6-d0aa-47f9-a3e6-b89b3156b92c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "263913a3-9deb-4331-85c7-d0db39175713" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "9c40a624-6363-4272-aadc-4925653e6d23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "fceaf3a3-ff99-42e6-8d10-b11b42288c96" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d17830-47a0-40fe-a89b-05ffe4a901f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "263913a3-9deb-4331-85c7-d0db39175713");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c40a624-6363-4272-aadc-4925653e6d23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fceaf3a3-ff99-42e6-8d10-b11b42288c96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "6a299da0-8cce-487c-9340-acb0f9f5ae04", "Admin", "ADMIN" },
                    { "90a52f39-2660-4948-bcbc-77d12b727d3f", "90a52f39-2660-4948-bcbc-77d12b727d3f", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6de9e11d-f012-450a-8dc2-8ae58d510403", 0, "138c920a-4d5c-44cf-91a3-d6fcf8d9b3b7", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEEt+sWNWr8yrU0VKPtg48pC9QpuUK1gvi4amIdwI44AAHnNQJIbEHDaD+GcRL63zxQ==", null, false, "1f44b440-222e-412c-a399-61643f666608", false, "drewxcom" },
                    { "3e45d3e9-4d3c-4e20-9ace-e3d32a554134", 0, "d46649fd-b659-4272-965c-719b1b58e9fa", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEG+NkD0roVTv0/uXbyVozi9Z71Er2uSC3Ul6xpMKSqqgQAljLou7A/hGqvwm2dVOjg==", null, false, "e1434804-7a6b-4b31-a959-8305fa1f2b76", false, "chale" },
                    { "f0f0ae27-d4f3-45ea-a383-e0a919a41462", 0, "121a6103-08d8-4e0c-8e94-d55207f41201", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEHR0XHmx3gimo3ta5Z7ZTU05+PQdohouC8jO5qLJ7dKHiRO+IykDxz5F61cbVfyo8w==", null, false, "cfab60da-771a-44bd-97e8-0f5f4cc7b1ad", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "6de9e11d-f012-450a-8dc2-8ae58d510403" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "3e45d3e9-4d3c-4e20-9ace-e3d32a554134" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "f0f0ae27-d4f3-45ea-a383-e0a919a41462" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Plans_PlanId",
                table: "Exercises",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
