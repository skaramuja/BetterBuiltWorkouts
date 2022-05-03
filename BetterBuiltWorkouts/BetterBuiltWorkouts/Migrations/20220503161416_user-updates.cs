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
                    { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "182f23a4-c669-4f94-bf86-66e893a7d7f4", "Admin", "ADMIN" },
                    { "40d12083-6893-401a-a53e-38b5266b33e6", "40d12083-6893-401a-a53e-38b5266b33e6", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c0db896-e3c2-4a69-b8c4-fc8f67fe92c2", 0, "0b5c018e-201f-4869-bf50-e0d1f004bd73", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAELhRpkUV09TSnuBVucZC9wfFOu1chsyqtkjresFLpapHL3LyJWw977zSSUrKS5isIQ==", null, false, "2a87ee91-9fe4-4d98-a7ea-3560e1b950b1", false, "drewxcom" },
                    { "9852a5c3-32ab-42d8-84d6-a8e7273c1410", 0, "1a80c7d7-8cf7-45a1-ac16-4a625c202a84", "emhennis@dmacc.edu", true, "Evan", "Hennis", false, null, "EMHENNIS@DMACC.EDU", "EMHENNIS", "AQAAAAEAACcQAAAAEPubgCbp9/mJO5bNzbR810SvJ498cJHBjajcAF3zcEMy3WgczXUUQOMzoFU33Z4/Vw==", null, false, "88a4cd6f-d5b9-4a7b-9d64-4cd59b88940f", false, "emhennis" },
                    { "c52e2509-2201-4c75-8edf-414253e9fb72", 0, "dc513c68-08b4-464f-a0f0-14a5e32dcf9e", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEKQrhjNH2z9GGDJLAyMXPlCYYBTSpgmXX2oFbgXxk3EctWDC+4GzPYBwnb53bfSTkw==", null, false, "a9d3d064-e04c-4924-811d-cddfbce6a3c6", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "4c0db896-e3c2-4a69-b8c4-fc8f67fe92c2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "9852a5c3-32ab-42d8-84d6-a8e7273c1410" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "c52e2509-2201-4c75-8edf-414253e9fb72" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40d12083-6893-401a-a53e-38b5266b33e6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "4c0db896-e3c2-4a69-b8c4-fc8f67fe92c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "9852a5c3-32ab-42d8-84d6-a8e7273c1410" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "182f23a4-c669-4f94-bf86-66e893a7d7f4", "c52e2509-2201-4c75-8edf-414253e9fb72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "182f23a4-c669-4f94-bf86-66e893a7d7f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c0db896-e3c2-4a69-b8c4-fc8f67fe92c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9852a5c3-32ab-42d8-84d6-a8e7273c1410");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c52e2509-2201-4c75-8edf-414253e9fb72");

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
    }
}
