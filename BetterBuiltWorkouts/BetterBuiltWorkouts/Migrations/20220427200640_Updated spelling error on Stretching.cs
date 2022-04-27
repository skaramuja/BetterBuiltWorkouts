using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class UpdatedspellingerroronStretching : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a3d805ad-8e97-43a2-ad67-04afda1ed40e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a5a276a1-4299-4aca-8019-b7045723c31c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a159a9ad-ae35-4d78-8149-b659018862c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3d805ad-8e97-43a2-ad67-04afda1ed40e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5a276a1-4299-4aca-8019-b7045723c31c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "Admin", "ADMIN" },
                    { "62845c9c-4cf4-461a-a298-b0a763f989a4", "62845c9c-4cf4-461a-a298-b0a763f989a4", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "88567f28-fc94-4341-ad77-d44c5fda5d49", 0, "bdbacb2f-e702-4019-a7d4-d6afa9de68bd", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEFHwfR0pAhMXVavlmT6ad+VK2dgl2AJ4RUevQ7anuDV0jy8WdOVzm+0lMInQZ8bHNA==", null, false, "6a49a9c2-ef1b-4066-93d6-e06cd39be521", false, "drewxcom" },
                    { "4e8d66ef-538b-4497-a69c-cb351c016d22", 0, "3767d875-00a5-4873-b5c1-3921e5e60b13", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEMT//pOT7GNZFohN89qtX/5wIkU1vpmvtzakNPTdog5dhXgRKZMEiTxuyG6AvfnWow==", null, false, "b3b38964-4e0c-465b-b66f-7ee6e0f75225", false, "chale" },
                    { "74bbfe56-6810-42ce-bd0f-ba6559db3d37", 0, "8a9dd4bb-ba73-4c1f-86bb-7373a4d5f492", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEBGm6T0o63jxFQwv2RMXjynOAgPhCU6cpLkdhwJ69r4Ji6LY4QErM3hLrr+gL+ZNFg==", null, false, "2fece5df-e0c8-43e7-8560-32feed5820e7", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Name",
                value: "Sample Stretching Plan");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "88567f28-fc94-4341-ad77-d44c5fda5d49" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "4e8d66ef-538b-4497-a69c-cb351c016d22" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "74bbfe56-6810-42ce-bd0f-ba6559db3d37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62845c9c-4cf4-461a-a298-b0a763f989a4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "4e8d66ef-538b-4497-a69c-cb351c016d22" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "74bbfe56-6810-42ce-bd0f-ba6559db3d37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3", "88567f28-fc94-4341-ad77-d44c5fda5d49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cb25a3e-67c6-4af1-8fdc-3fca2ade64b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e8d66ef-538b-4497-a69c-cb351c016d22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74bbfe56-6810-42ce-bd0f-ba6559db3d37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88567f28-fc94-4341-ad77-d44c5fda5d49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a159a9ad-ae35-4d78-8149-b659018862c8", "a159a9ad-ae35-4d78-8149-b659018862c8", "Admin", "ADMIN" },
                    { "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e", "0dddf99b-eeeb-4af7-be1c-105ad7ad9a5e", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a3d805ad-8e97-43a2-ad67-04afda1ed40e", 0, "b37eba2f-dbc9-430f-b97f-22a2532de82f", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAECwKwCm+AR3MVlsMgjD7tqot40IxJwxMQufnAAkgd79bpxU6/smoZpN14yne4ueAuw==", null, false, "4e2dbc9e-49a1-48aa-9201-63f597174971", false, "drewxcom" },
                    { "a5a276a1-4299-4aca-8019-b7045723c31c", 0, "ba04f93f-87ab-412c-bd8b-1f08bef8421f", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEK2o1mts62mke37NKf1j8zj3aoh9PO+fA8Ryi39VdzagRthZInHnjCYb2I0FU0qPig==", null, false, "a2e705b1-e939-4572-a254-5d71824536f7", false, "chale" },
                    { "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4", 0, "c32af0f4-d618-4fb5-97f2-1cb96c5adbf4", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEDuBWAfb5UFyo3T1VcXxNVA4/DT4jEC+i5HMgNK3r25EbhNdxHdVRS55q9h4lQBAXQ==", null, false, "97954546-9171-45c2-b7df-cd448d6ac042", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3,
                column: "Name",
                value: "Sample Streching Plan");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a3d805ad-8e97-43a2-ad67-04afda1ed40e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "a5a276a1-4299-4aca-8019-b7045723c31c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a159a9ad-ae35-4d78-8149-b659018862c8", "3511b6e5-ff26-4ee7-9adc-bb767e8f6cc4" });
        }
    }
}
