using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class add_workout_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6d9997-d9d6-4942-adba-39fbe7c7e2de");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "029307dc-85f7-4736-885b-6ebc8bcb3d79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "63662c92-9cc0-4ffc-ad43-fe2a2b13548a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "a3486bf1-a5ef-42bb-a160-880edac8fed2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38fb147a-650e-4d80-91ff-cf442a84eebc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "029307dc-85f7-4736-885b-6ebc8bcb3d79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63662c92-9cc0-4ffc-ad43-fe2a2b13548a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3486bf1-a5ef-42bb-a160-880edac8fed2");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Plans");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "Admin", "ADMIN" },
                    { "66d723c3-863a-44ac-895b-3f210bd78f6b", "66d723c3-863a-44ac-895b-3f210bd78f6b", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0182e972-b42d-4a60-9874-48cef40be13a", 0, "ef2473e3-2de5-4102-b508-e6572b4515cc", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEJSLYl7EIJ0CShJkGsYPV0xozqnTB18oKWFnR4EW6zKJAknOrMGx4Puf/tPVTkugbw==", null, false, "c0464db0-ccc2-4e77-b968-0bae7b746c42", false, "drewxcom" },
                    { "ab986f2b-3d0d-400c-b7c4-c665ed4fe43b", 0, "2c5232c8-31e1-4647-b74c-c7aa978b294a", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEG25NIH0TyLfwPZU/WTUrXBrNNZW7a5anfEbhXWEVfb58FB4mzn5SRdugfnTNV6Ncw==", null, false, "e8bf2dfd-8606-4b4e-95ac-ac4b407cda55", false, "chale" },
                    { "14cf5b65-7b10-4b05-9557-f7a2a59e10b4", 0, "d00e5656-135a-4e31-965d-213fb79c9747", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEK5ZVyraaGRpC1ddmmzxEaBUsjD7daeixgl9caqyr2eT/AoDUjAhBPruzCMF+653Jw==", null, false, "22d655f1-f17c-46fd-9668-d2484a958b3e", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "0182e972-b42d-4a60-9874-48cef40be13a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "ab986f2b-3d0d-400c-b7c4-c665ed4fe43b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "14cf5b65-7b10-4b05-9557-f7a2a59e10b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d723c3-863a-44ac-895b-3f210bd78f6b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "0182e972-b42d-4a60-9874-48cef40be13a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "14cf5b65-7b10-4b05-9557-f7a2a59e10b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db16f94d-171c-47ea-8ce3-f0649a7e4b52", "ab986f2b-3d0d-400c-b7c4-c665ed4fe43b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db16f94d-171c-47ea-8ce3-f0649a7e4b52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0182e972-b42d-4a60-9874-48cef40be13a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14cf5b65-7b10-4b05-9557-f7a2a59e10b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab986f2b-3d0d-400c-b7c4-c665ed4fe43b");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38fb147a-650e-4d80-91ff-cf442a84eebc", "38fb147a-650e-4d80-91ff-cf442a84eebc", "Admin", "ADMIN" },
                    { "5b6d9997-d9d6-4942-adba-39fbe7c7e2de", "5b6d9997-d9d6-4942-adba-39fbe7c7e2de", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "029307dc-85f7-4736-885b-6ebc8bcb3d79", 0, "549ac1a4-ed20-47ea-93c0-04afe0f7a868", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEH9xS61DjpDvRhpPYzhhzny3DCXjzAgWcDxV5F29cHPy+AhRMWf7Lz3ObeoC0wL0+w==", null, false, "4fefd536-66f3-4582-be8a-1fd0906c958c", false, "drewxcom" },
                    { "63662c92-9cc0-4ffc-ad43-fe2a2b13548a", 0, "f0f60756-d77f-4a6f-9620-9b790bfae679", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAENsEzbrPQ1gC56EQYXTmj+dJBzAIV5T2HDXK8n9vTPLFXANMC9zMlN96a7BHnRhk+A==", null, false, "bf0d2b8c-60e6-4bbe-a2ed-502aa6b27302", false, "chale" },
                    { "a3486bf1-a5ef-42bb-a160-880edac8fed2", 0, "3435246e-5376-4ec3-8634-a28fd5ebe2f1", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEAjNwaCFvCU/06X2kiiDHY5vtNogzqB47YGID6iR5dpI6rb9uTruHu2ixaIS+m3Hbg==", null, false, "ab9bea5a-7753-453a-8754-f4655399dbdb", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "029307dc-85f7-4736-885b-6ebc8bcb3d79" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "63662c92-9cc0-4ffc-ad43-fe2a2b13548a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "a3486bf1-a5ef-42bb-a160-880edac8fed2" });
        }
    }
}
