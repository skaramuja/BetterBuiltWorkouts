using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Injectrepositoriestounitofwork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fb25e70-24b9-4c98-b19a-d16eefc28514");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "124337c5-8436-41ce-9fb7-baec7cadb915" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "205e80e2-e8a1-4dde-9432-89ac12885cda" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "a0ce16cb-50fc-4e19-89fc-cdd148caadec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28b58671-8609-4d31-9948-59d4c1344491");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124337c5-8436-41ce-9fb7-baec7cadb915");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "205e80e2-e8a1-4dde-9432-89ac12885cda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ce16cb-50fc-4e19-89fc-cdd148caadec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "Admin", "ADMIN" },
                    { "59a8e319-8781-4d6a-b56a-0afbd5d8bf42", "59a8e319-8781-4d6a-b56a-0afbd5d8bf42", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "358c4d41-fc0f-45b9-9874-827a7fccbd46", 0, "91ac89d7-9742-4748-9f4b-5eb7fd71d971", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEAUN/cBW6VxCUm9PVVMC7eVxJ13lTYBTdHkrZ9JTPeiWhroanvr2q7trwaN1CQYvDA==", null, false, "cd66b15e-0e88-4d31-9e6d-b6463125cd22", false, "drewxcom" },
                    { "0da27b2f-e209-4ea8-ac27-e386a45497e7", 0, "82b0b0d2-7b67-4387-abf2-de77fd912ef8", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAELBpUdzmYazHYY1ST2GF0uSwe6l+KdmQ3oRKLqth3gaAC4utda2J/09NbWOoXxPYpA==", null, false, "55d8ea60-b453-4a5c-831d-604204ca78d1", false, "chale" },
                    { "8014ed5c-16cf-4062-8ebb-aee86f503a68", 0, "919cf0c6-ffe6-4994-9793-2353ddaa946d", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEG3E43S0rUanR/z3Jtf3mnOeLr1ehzJO1xtZFIWuJlpu1JeYk+ECrTsRT2woQtDexg==", null, false, "1b0db49f-f8f5-45e5-b3e4-301b2e2a1c35", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "358c4d41-fc0f-45b9-9874-827a7fccbd46" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "0da27b2f-e209-4ea8-ac27-e386a45497e7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "8014ed5c-16cf-4062-8ebb-aee86f503a68" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59a8e319-8781-4d6a-b56a-0afbd5d8bf42");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "0da27b2f-e209-4ea8-ac27-e386a45497e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "358c4d41-fc0f-45b9-9874-827a7fccbd46" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a6f932d-16dd-420d-87e2-6d6dee1af6dd", "8014ed5c-16cf-4062-8ebb-aee86f503a68" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a6f932d-16dd-420d-87e2-6d6dee1af6dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0da27b2f-e209-4ea8-ac27-e386a45497e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "358c4d41-fc0f-45b9-9874-827a7fccbd46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8014ed5c-16cf-4062-8ebb-aee86f503a68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28b58671-8609-4d31-9948-59d4c1344491", "28b58671-8609-4d31-9948-59d4c1344491", "Admin", "ADMIN" },
                    { "0fb25e70-24b9-4c98-b19a-d16eefc28514", "0fb25e70-24b9-4c98-b19a-d16eefc28514", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "205e80e2-e8a1-4dde-9432-89ac12885cda", 0, "101d61ae-0415-4793-ae34-c6493ad4f26a", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEKz+6PK5V/m4uMbS5yg0syjhKruw7hlO7SjmJGz47Q6ZDZN0rm8GSmXoVC+NWZmD9Q==", null, false, "456f60a6-1cbe-49fa-a416-29c07cf7689f", false, "drewxcom" },
                    { "a0ce16cb-50fc-4e19-89fc-cdd148caadec", 0, "25f59aa7-6d4b-41a6-b037-6de76a6493d4", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEBIZ44QBmXfYEpaICjw96A/3WcTZqF43cPZdCpZCB6zJkfmFfIkJU587I6EJMIVQpQ==", null, false, "0bda0909-8c9d-4b60-9bf7-847458f28db8", false, "chale" },
                    { "124337c5-8436-41ce-9fb7-baec7cadb915", 0, "f25d8f69-a7ae-4582-a2f3-89367fe44f92", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEB8pJzJbEaGjOxOQ3TjNwTwWCtGx+0pscOHHv75Pk/wuzLY7OLBIbD9HHTcvH56caA==", null, false, "006c3f6b-bc67-4046-81c9-ae7e875e34d6", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "205e80e2-e8a1-4dde-9432-89ac12885cda" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "a0ce16cb-50fc-4e19-89fc-cdd148caadec" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28b58671-8609-4d31-9948-59d4c1344491", "124337c5-8436-41ce-9fb7-baec7cadb915" });
        }
    }
}
