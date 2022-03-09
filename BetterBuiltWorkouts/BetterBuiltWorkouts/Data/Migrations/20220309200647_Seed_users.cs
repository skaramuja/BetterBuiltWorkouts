using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Data.Migrations
{
    public partial class Seed_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "2eca1d98-abe0-4e22-9078-a687b5a0673d", "Admin", "ADMIN" },
                    { "6f6e18ef-42cf-4655-8fcc-64ec635d54fc", "6f6e18ef-42cf-4655-8fcc-64ec635d54fc", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "381c769a-debd-4ab7-a1b8-ce38db0a1e6a", 0, "428019f7-73dc-467b-bf77-2e8d72200cf8", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEPe+DhOWKuBdZw2iLjIUHrky6nNknhhmBd1OpbGBxLRR0KdxZTkmiY6DHxQ9vTK0sA==", null, false, "9cfa4b45-ec71-481d-8992-e9a27a0cd122", false, "drewxcom" },
                    { "0b10f73d-72c2-48ff-81f6-d54238cc679f", 0, "b121f70a-bced-49e3-b2a8-af341c407601", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEMF8kPJflaN8KMIGPkMyrmpjjd5aGkmZdzx3Dki53TyOVvWSBtphi77h2dCh4/lLVw==", null, false, "38370b50-73f8-4871-af0a-0ed34013e2c5", false, "chale" },
                    { "8a3af885-ec2a-4141-a979-ef7f157928e6", 0, "e38cb5b3-1cfd-4ce6-a087-d7b77f97cef8", "Karamuja.sabina@gmail.com", true, "Sabina", "Karamuja", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEKj2ySAfqYpQMxNkC+6pwovNw6TqbVZ972cBohSDtJ9bG8hikUDetZ1xA28DIMDlfw==", null, false, "19a58d28-e75f-419e-ac51-6bd1d9412b86", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "381c769a-debd-4ab7-a1b8-ce38db0a1e6a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "0b10f73d-72c2-48ff-81f6-d54238cc679f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "8a3af885-ec2a-4141-a979-ef7f157928e6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f6e18ef-42cf-4655-8fcc-64ec635d54fc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "0b10f73d-72c2-48ff-81f6-d54238cc679f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "381c769a-debd-4ab7-a1b8-ce38db0a1e6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eca1d98-abe0-4e22-9078-a687b5a0673d", "8a3af885-ec2a-4141-a979-ef7f157928e6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eca1d98-abe0-4e22-9078-a687b5a0673d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b10f73d-72c2-48ff-81f6-d54238cc679f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "381c769a-debd-4ab7-a1b8-ce38db0a1e6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a3af885-ec2a-4141-a979-ef7f157928e6");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
