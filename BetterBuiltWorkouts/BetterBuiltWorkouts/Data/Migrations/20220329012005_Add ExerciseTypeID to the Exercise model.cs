using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Data.Migrations
{
    public partial class AddExerciseTypeIDtotheExercisemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17fb455c-b872-4dbd-98e6-ee4b83b5939e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "49e5d625-954b-4f36-ab58-6453ebbd56c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "62d63c54-8fb0-41ed-9108-14e3316a98b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "8e881760-9683-455c-ad43-f169a9a02504" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c9c4c6-4644-42de-9093-4877067ede23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49e5d625-954b-4f36-ab58-6453ebbd56c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d63c54-8fb0-41ed-9108-14e3316a98b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e881760-9683-455c-ad43-f169a9a02504");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeID",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "Admin", "ADMIN" },
                    { "edd5de60-d5bc-46d0-b3a6-d829eec68050", "edd5de60-d5bc-46d0-b3a6-d829eec68050", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a51365c-5390-44c8-ad19-79e3f84d39e0", 0, "c5725928-f117-4f66-ba03-4c48a57f6f6f", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEMpvajCBQybp9raa/PFbx6M/1rcDXBLDrpmFBflK0+r0ijCfDMLe3FscTEOnPzxqKQ==", null, false, "734a204a-505e-44e6-9f6b-78c6c7bc0f54", false, "drewxcom" },
                    { "9ed5580f-0987-4733-89a7-ae07bf8cc67f", 0, "30fd3a82-db43-4bf5-adb9-6f34f96ef52f", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEPCe53GUf4Z3RaJCyQ4T8PqPgQpTRtzWjJU1vZbgwta+9K3prYawaCCXvIjUTA9fZA==", null, false, "83b959fb-227c-4044-a525-83037451b777", false, "chale" },
                    { "ead3976b-1a71-4212-af6c-260318a51747", 0, "68992138-d15e-4c0d-845c-9676412367c8", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEJl1ct6J3XLZ4cucSvDrGIAJw9Cfy8bV43YjdTbCew1LdeXKNGEOlMw4vr5NzcxAIA==", null, false, "59e45b85-c77b-49d3-8b0e-73bdd1493bd4", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "0a51365c-5390-44c8-ad19-79e3f84d39e0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "9ed5580f-0987-4733-89a7-ae07bf8cc67f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "ead3976b-1a71-4212-af6c-260318a51747" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID",
                principalTable: "ExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edd5de60-d5bc-46d0-b3a6-d829eec68050");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "0a51365c-5390-44c8-ad19-79e3f84d39e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "9ed5580f-0987-4733-89a7-ae07bf8cc67f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f", "ead3976b-1a71-4212-af6c-260318a51747" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c5bd6c1-76e7-476f-b4ed-895f2f0df00f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a51365c-5390-44c8-ad19-79e3f84d39e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ed5580f-0987-4733-89a7-ae07bf8cc67f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ead3976b-1a71-4212-af6c-260318a51747");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeID",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f4c9c4c6-4644-42de-9093-4877067ede23", "f4c9c4c6-4644-42de-9093-4877067ede23", "Admin", "ADMIN" },
                    { "17fb455c-b872-4dbd-98e6-ee4b83b5939e", "17fb455c-b872-4dbd-98e6-ee4b83b5939e", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e881760-9683-455c-ad43-f169a9a02504", 0, "3dbf4167-8814-4ea0-9017-82fdeacf3408", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEFvRa1ivqCpkkWnLNHght49ZOPmgyp0cldVbU/tEru1TQco2p3+2m9UK1wrrDoI4Lw==", null, false, "314ffbb9-b0b5-4a9e-ae45-e76bb452454e", false, "drewxcom" },
                    { "49e5d625-954b-4f36-ab58-6453ebbd56c7", 0, "57419a8d-1feb-485f-ad84-fc1e76a3db4c", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAECbxFQJGOJBnQbPANzPmNHdM65tGLTt3NmButtVtLzenTBXNL6i5zX8GnOAFtVJWWw==", null, false, "6b9537ff-4e38-43d5-8cde-971829cb8e5f", false, "chale" },
                    { "62d63c54-8fb0-41ed-9108-14e3316a98b0", 0, "ac6b7c91-0521-43c9-908d-b7e3787f3136", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEI7kcHIdzTtSEWHhksIKWYRMoxF30Ajh5/JWInWwlCOal5NHhlgBcUgJOBefYYhWmQ==", null, false, "cfb6a9cd-1e65-4839-aefc-ca88d9582abd", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "8e881760-9683-455c-ad43-f169a9a02504" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "49e5d625-954b-4f36-ab58-6453ebbd56c7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4c9c4c6-4644-42de-9093-4877067ede23", "62d63c54-8fb0-41ed-9108-14e3316a98b0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID",
                principalTable: "ExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
