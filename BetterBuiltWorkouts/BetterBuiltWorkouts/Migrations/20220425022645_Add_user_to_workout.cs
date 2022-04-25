using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Add_user_to_workout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "CompletedBy",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CompletedBy",
                table: "Workouts");

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
        }
    }
}
