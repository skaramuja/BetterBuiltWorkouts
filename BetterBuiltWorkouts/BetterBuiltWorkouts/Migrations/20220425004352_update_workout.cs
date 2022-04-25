using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class update_workout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutId);
                    table.ForeignKey(
                        name: "FK_Workouts_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e6a6353b-1feb-4b9b-9a12-905cae432922", "e6a6353b-1feb-4b9b-9a12-905cae432922", "Admin", "ADMIN" },
                    { "41c5e357-1342-4e14-b0dc-29d3f39af015", "41c5e357-1342-4e14-b0dc-29d3f39af015", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b58cfe27-dfe4-458d-aac3-45aef93e97bb", 0, "409dd055-48b7-4c4a-84c7-023ca8806b0c", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEFRk1igZwCEZ5/wsXW7mHhujeqS2PV4qIKCiHeKCtRCZJcmvJYR/R6x90nFgvqsT1A==", null, false, "2599a746-d4d8-4021-b871-485240eed61d", false, "drewxcom" },
                    { "bc35e29f-4c82-4e4b-9e75-ecb27c044db2", 0, "edf5edf4-f88d-4838-9480-e0252447e75b", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEHlyeBn0I0JBqk1V8BCrHLILlZ0pXUkKykz5IczbHzx6G6++pPu4Xyh0VUpAml3XAA==", null, false, "f4791d1b-0cd1-4fe2-9033-3286fb588222", false, "chale" },
                    { "bf59ef17-5f67-4752-844e-04eb6ff57370", 0, "85050c93-571d-4ad4-ad00-0492e19af27d", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEHa8ACXtcmnJLTeEHEb3SFL96RAtOQrPCkWs9eioCZg1Cb+HQERKf2rivw8dilLvfA==", null, false, "e4e56e41-c575-4a1d-84b5-7ed76de1d7e1", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "b58cfe27-dfe4-458d-aac3-45aef93e97bb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "bc35e29f-4c82-4e4b-9e75-ecb27c044db2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "bf59ef17-5f67-4752-844e-04eb6ff57370" });

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_PlanId",
                table: "Workouts",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c5e357-1342-4e14-b0dc-29d3f39af015");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "b58cfe27-dfe4-458d-aac3-45aef93e97bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "bc35e29f-4c82-4e4b-9e75-ecb27c044db2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6a6353b-1feb-4b9b-9a12-905cae432922", "bf59ef17-5f67-4752-844e-04eb6ff57370" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6a6353b-1feb-4b9b-9a12-905cae432922");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b58cfe27-dfe4-458d-aac3-45aef93e97bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc35e29f-4c82-4e4b-9e75-ecb27c044db2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf59ef17-5f67-4752-844e-04eb6ff57370");

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
    }
}
