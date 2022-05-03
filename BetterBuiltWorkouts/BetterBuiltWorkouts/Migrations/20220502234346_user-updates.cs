using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class userupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12760960-8631-4c01-98c5-9c41817bf80c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "2482cf64-e12f-4871-8272-901eba96e145" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "b3423286-f27a-45ed-8252-38a576bd0af4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "caf53105-fabc-4073-a9d9-3caeea5e0ce5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09f9c0ca-be4d-46b7-930b-b998481724b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2482cf64-e12f-4871-8272-901eba96e145");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caf53105-fabc-4073-a9d9-3caeea5e0ce5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05f58cbd-36ec-4251-b0fe-3a011c643130", "05f58cbd-36ec-4251-b0fe-3a011c643130", "Admin", "ADMIN" },
                    { "d2a59abb-a81f-477e-b913-a5020be9362a", "d2a59abb-a81f-477e-b913-a5020be9362a", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75157424-1cc2-4469-b1eb-8c9a2e88ccc3", 0, "55a0e424-51d2-4bee-ac59-b3b83f58cf90", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEHMScbj0tZAmpZpXwwMHvJrHnw8dp1isplegcd17oCkM4BTNPMs9zarlgzKme12HLA==", null, false, "07780890-5d2e-47b4-9bbf-aa615c7ac8f6", false, "drewxcom" },
                    { "352fe5a4-e3d4-456c-83e8-01bbee639026", 0, "05ae8a1e-9c45-4b7c-9e3b-179647d325f4", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAECBHlkogBiTsdSjkfS1Lik9nlcuaQ2f9sGcqH9rerrN4sg5mAIwwHIyVypTrJONwCg==", null, false, "5363485e-328d-48c3-bf46-8500f6474b2d", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "05f58cbd-36ec-4251-b0fe-3a011c643130", "75157424-1cc2-4469-b1eb-8c9a2e88ccc3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "05f58cbd-36ec-4251-b0fe-3a011c643130", "352fe5a4-e3d4-456c-83e8-01bbee639026" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2a59abb-a81f-477e-b913-a5020be9362a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05f58cbd-36ec-4251-b0fe-3a011c643130", "352fe5a4-e3d4-456c-83e8-01bbee639026" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05f58cbd-36ec-4251-b0fe-3a011c643130", "75157424-1cc2-4469-b1eb-8c9a2e88ccc3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05f58cbd-36ec-4251-b0fe-3a011c643130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "352fe5a4-e3d4-456c-83e8-01bbee639026");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75157424-1cc2-4469-b1eb-8c9a2e88ccc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09f9c0ca-be4d-46b7-930b-b998481724b6", "09f9c0ca-be4d-46b7-930b-b998481724b6", "Admin", "ADMIN" },
                    { "12760960-8631-4c01-98c5-9c41817bf80c", "12760960-8631-4c01-98c5-9c41817bf80c", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2482cf64-e12f-4871-8272-901eba96e145", 0, "88be5fe6-4bcc-428d-a29f-f6bdc47bb81c", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEEsuANjtv6REIpPnUAKUhnZaeD2lueHVAV6k5NnQYG9gaMpzAzfm9DMYdPOr+wNoug==", null, false, "a103efce-45ca-4333-b37a-16c954fabf45", false, "drewxcom" },
                    { "caf53105-fabc-4073-a9d9-3caeea5e0ce5", 0, "99043a9f-023f-473d-856d-6f0b0446821a", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEKL3ON7KquJdXfjPB/XU823rV4IMbiJp47zSEI+aHMti3h7oXH+/mzR9TwD2G3L3uw==", null, false, "7fc5749c-752a-4a90-a287-94116317ca7d", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "2482cf64-e12f-4871-8272-901eba96e145" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "b3423286-f27a-45ed-8252-38a576bd0af4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09f9c0ca-be4d-46b7-930b-b998481724b6", "caf53105-fabc-4073-a9d9-3caeea5e0ce5" });
        }
    }
}
