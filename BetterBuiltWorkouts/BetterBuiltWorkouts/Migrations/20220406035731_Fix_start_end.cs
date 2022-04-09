using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Fix_start_end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f251407d-e55a-43e1-9990-b7e25e8aa18f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "583b5016-a84f-4505-9288-d0c27ba30661" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "9dc93f37-0935-4326-942d-98cc383b0e91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "fd9f9c24-90b1-4939-a4d4-93156250cdd7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "583b5016-a84f-4505-9288-d0c27ba30661");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dc93f37-0935-4326-942d-98cc383b0e91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9f9c24-90b1-4939-a4d4-93156250cdd7");

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
                    { "4d14c42e-61b6-4c73-a0f5-97f926691788", "4d14c42e-61b6-4c73-a0f5-97f926691788", "Admin", "ADMIN" },
                    { "4e59cab6-123e-49be-8314-447834545cd6", "4e59cab6-123e-49be-8314-447834545cd6", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abe57003-0b83-4ca6-b3c9-8472cb58deea", 0, "212bf5ec-25da-43ab-973f-beded69630ba", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEDonWXtM9TFsTLjEQa0dfCxhle1sdLpaFOXfLIYBlavZp9eu3mRovvNVtxkNc6+QTA==", null, false, "8fff8e0f-a8d2-4525-92d3-30de0517a8ca", false, "drewxcom" },
                    { "316bd4fc-eceb-492e-abe8-06eb0d6a324f", 0, "ad6a6fd8-4e1a-4699-a1b3-3cb43b8cc942", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEAlzznCZ70SoqXjqkeM+TRHSgs59jJ/k+Wl5vFWipwrxxepWtRFkN4Crodyl/ygR5g==", null, false, "fbc7ca5b-cc90-4cd4-a4ac-d423adf28cb7", false, "chale" },
                    { "8c7b88b3-6863-4e6e-967c-00fac9afb6aa", 0, "3eca8f41-14bf-450e-9f41-0dfdd5fe9539", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAELZqmC9ncKle8fhdKra3Fi9/Feh6+RWkgHcuy39xzZsNqkRmRVQTR9T6rYpNeGu/FA==", null, false, "bf858138-f9b7-4f2e-a86a-d432dcbf7169", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "abe57003-0b83-4ca6-b3c9-8472cb58deea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "316bd4fc-eceb-492e-abe8-06eb0d6a324f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "8c7b88b3-6863-4e6e-967c-00fac9afb6aa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e59cab6-123e-49be-8314-447834545cd6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "316bd4fc-eceb-492e-abe8-06eb0d6a324f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "8c7b88b3-6863-4e6e-967c-00fac9afb6aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "abe57003-0b83-4ca6-b3c9-8472cb58deea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d14c42e-61b6-4c73-a0f5-97f926691788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "316bd4fc-eceb-492e-abe8-06eb0d6a324f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c7b88b3-6863-4e6e-967c-00fac9afb6aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abe57003-0b83-4ca6-b3c9-8472cb58deea");

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
                    { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "Admin", "ADMIN" },
                    { "f251407d-e55a-43e1-9990-b7e25e8aa18f", "f251407d-e55a-43e1-9990-b7e25e8aa18f", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9dc93f37-0935-4326-942d-98cc383b0e91", 0, "62630c43-55b8-457b-b7df-b58cdc9ff4b9", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEDh5GzmB27gFoIZ4tcGtx+BT5otOEm+TN0Jrc5YexGGcxdaFkTXniWO0R/5jfL1RLQ==", null, false, "511f70ba-eef9-40f6-b420-00d8977026be", false, "drewxcom" },
                    { "583b5016-a84f-4505-9288-d0c27ba30661", 0, "50320761-8f1b-4799-9fd4-446b86aa7b32", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEHjFpbzJSYtJK7X/aQnYzHBljWs08o0A1k9g4h02VUYcrTUgVPId54EdTKccZ6P0mA==", null, false, "99e2dc9a-21b1-4b33-a22a-2e639b5e9cb7", false, "chale" },
                    { "fd9f9c24-90b1-4939-a4d4-93156250cdd7", 0, "1ab56cb9-20db-4a32-9669-b2f71166246c", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEMIHnmErzka135BvPo2IYnVzhdA3KD+pNPDzOPxFLm7CTBHto19eM8WlDeQKMm/gzw==", null, false, "aa961906-e349-460a-aa18-677a910d64ce", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "9dc93f37-0935-4326-942d-98cc383b0e91" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "583b5016-a84f-4505-9288-d0c27ba30661" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "fd9f9c24-90b1-4939-a4d4-93156250cdd7" });
        }
    }
}
