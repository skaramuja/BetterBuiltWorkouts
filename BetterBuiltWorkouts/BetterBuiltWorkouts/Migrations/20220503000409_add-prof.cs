using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class addprof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93ca5b4a-49e1-4a39-b777-ffb52e30d0c6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "aeef813c-391b-4393-92ec-cbb7f8699ce6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "d25b72f7-350c-41e0-b777-a53a189c4675" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "feaf6e98-fbfd-4dd6-99d1-00894bca3e57" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be775e7f-0fea-4f45-944d-33667cee55c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeef813c-391b-4393-92ec-cbb7f8699ce6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d25b72f7-350c-41e0-b777-a53a189c4675");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "feaf6e98-fbfd-4dd6-99d1-00894bca3e57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "748376cc-5096-40ab-bc9d-80c215e4be4d", "748376cc-5096-40ab-bc9d-80c215e4be4d", "Admin", "ADMIN" },
                    { "2e33c01a-6f38-4740-ad01-2af834c7aeda", "2e33c01a-6f38-4740-ad01-2af834c7aeda", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9a330569-e01d-40d2-a9fe-30eba59b4c0d", 0, "a8ec2cba-10b6-4e01-b88b-cf5c630fb19d", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAECc4lRI9fPW7SdGFd+bCnl3cGeivQcDKM5fWSccKv2tG3dMF8bD4N3f4wkawoB5lzg==", null, false, "ad1ba4f9-58a5-4ac5-b5bd-4b6706c6e748", false, "drewxcom" },
                    { "119abdfd-21cd-4bb4-9db5-3db5b5de21a0", 0, "4fee0039-ce26-47ee-9641-a089589f9a5e", "emhennis@dmacc.edu", true, "Evan", "Hennis", false, null, "EMHENNIS@DMACC.EDU", "EMHENNIS", "AQAAAAEAACcQAAAAEKJWOrxPrQYC/Qxx8KLftoiDZM0tvM/sbE2ed9cIUV9GLM/+/qRfVZIkK4HD9CW/og==", null, false, "19472dfe-ae09-480d-980c-604238341fee", false, "emhennis" },
                    { "29f95e2f-ebda-44ee-a59d-331a7cf1e372", 0, "83552ab1-7f6d-443d-a7a0-c4e1ecc8b41c", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAELI3aChtjDmLOSNm4vrMEDiGaxayFySR1CwPHK9PBfs0cM4fqjE4APnUDRG+LFJJug==", null, false, "d0fe994a-4b14-4084-b6c2-0c209ce164e7", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "9a330569-e01d-40d2-a9fe-30eba59b4c0d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "119abdfd-21cd-4bb4-9db5-3db5b5de21a0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "29f95e2f-ebda-44ee-a59d-331a7cf1e372" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e33c01a-6f38-4740-ad01-2af834c7aeda");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "119abdfd-21cd-4bb4-9db5-3db5b5de21a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "29f95e2f-ebda-44ee-a59d-331a7cf1e372" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "748376cc-5096-40ab-bc9d-80c215e4be4d", "9a330569-e01d-40d2-a9fe-30eba59b4c0d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748376cc-5096-40ab-bc9d-80c215e4be4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119abdfd-21cd-4bb4-9db5-3db5b5de21a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f95e2f-ebda-44ee-a59d-331a7cf1e372");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a330569-e01d-40d2-a9fe-30eba59b4c0d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be775e7f-0fea-4f45-944d-33667cee55c3", "be775e7f-0fea-4f45-944d-33667cee55c3", "Admin", "ADMIN" },
                    { "93ca5b4a-49e1-4a39-b777-ffb52e30d0c6", "93ca5b4a-49e1-4a39-b777-ffb52e30d0c6", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d25b72f7-350c-41e0-b777-a53a189c4675", 0, "7516d9e4-f30a-47bc-856b-d43058400e39", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEFzd9nHVfCj9EEyOhKZC3VToTfXN2sEb/O3wXdLHK6UIT/q3O7F3GdoaMygk6HrQGw==", null, false, "d6eb2822-deca-4a3a-a7dd-675d54af0b69", false, "drewxcom" },
                    { "feaf6e98-fbfd-4dd6-99d1-00894bca3e57", 0, "d07abe47-5e0b-45ac-bffd-6a22518bd325", "emhennis@dmacc.edu", true, "Evan", "Hennis", false, null, "EMHENNIS@DMACC.EDU", "EMHENNIS", null, null, false, "6d10968b-0394-464a-aafa-4822bf531a58", false, "emhennis" },
                    { "aeef813c-391b-4393-92ec-cbb7f8699ce6", 0, "68aab411-5a64-4212-bce6-95e85cfdd489", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEILelK0grc3f51umRbEuz3iceVamyqu0/6dhbNDXOeTceJmvMJETQA8OLS3bJZQLaw==", null, false, "c4577a9e-f5d0-417e-baf0-e78f47e4a49a", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "d25b72f7-350c-41e0-b777-a53a189c4675" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "feaf6e98-fbfd-4dd6-99d1-00894bca3e57" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be775e7f-0fea-4f45-944d-33667cee55c3", "aeef813c-391b-4393-92ec-cbb7f8699ce6" });
        }
    }
}
