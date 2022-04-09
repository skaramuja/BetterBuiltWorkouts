using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Add_Plan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2172027-e924-4bbd-be5e-53db9e571f14");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "1720a676-602c-4083-bd1f-8813be8cfb7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "9f39f31d-16ad-49f3-942a-2a2909cd14aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "cde303cf-f9a0-4886-9a97-eda149f6aa69" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1720a676-602c-4083-bd1f-8813be8cfb7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f39f31d-16ad-49f3-942a-2a2909cd14aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde303cf-f9a0-4886-9a97-eda149f6aa69");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Exercises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reps",
                table: "Exercises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeID",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Distance",
                table: "Exercises",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimesCompleted = table.Column<int>(type: "int", nullable: true),
                    ExerciseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef3cd181-4243-415a-8dc4-00814e0311e2", "ef3cd181-4243-415a-8dc4-00814e0311e2", "Admin", "ADMIN" },
                    { "7b44f9c7-1d78-437e-b84a-ec0cec18dfa9", "7b44f9c7-1d78-437e-b84a-ec0cec18dfa9", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5d337ecb-806f-4ddb-a52c-6861a9e4f5b2", 0, "b656d009-9890-4f00-b111-811338750128", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEHOMFjZ1+pNumZ9jAGg9Ry6BoTmdZOLG/pRTZ8uXGk7QDRTDWJcms7v9EBCU7vXdwA==", null, false, "0362d5eb-3c57-4416-b146-44dc5f852feb", false, "drewxcom" },
                    { "e11a212f-4a92-4fd9-8e8a-1afdb50d4553", 0, "047f4f1a-1315-407d-9d60-be79e035f90c", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEKgTPQhbIL/h7JRw5btVMQHcsnNmmCQwHHIM4F7bME355rkVHsr8kVgj50tCtWvzfw==", null, false, "b875ce0c-eadf-43e1-9658-61344185375f", false, "chale" },
                    { "df2644ec-2f0e-4093-bcec-6e2a6ab11077", 0, "2f724d89-045d-453d-8570-b756d7b28160", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEDsVyFr3Se6wZAT6CFJyw5kluq90O9yhN8Q7F5GvbjkIXlEaTPCAgo6pU4j6xX0Jdg==", null, false, "0a57a945-5dfe-4ef7-9a60-bf5423e7a56a", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "CreatedBy", "ExerciseId", "Name", "TimesCompleted" },
                values: new object[] { 1, null, null, "Basic Plan 1", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "5d337ecb-806f-4ddb-a52c-6861a9e4f5b2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "e11a212f-4a92-4fd9-8e8a-1afdb50d4553" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "df2644ec-2f0e-4093-bcec-6e2a6ab11077" });

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

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b44f9c7-1d78-437e-b84a-ec0cec18dfa9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "5d337ecb-806f-4ddb-a52c-6861a9e4f5b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "df2644ec-2f0e-4093-bcec-6e2a6ab11077" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef3cd181-4243-415a-8dc4-00814e0311e2", "e11a212f-4a92-4fd9-8e8a-1afdb50d4553" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef3cd181-4243-415a-8dc4-00814e0311e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d337ecb-806f-4ddb-a52c-6861a9e4f5b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2644ec-2f0e-4093-bcec-6e2a6ab11077");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e11a212f-4a92-4fd9-8e8a-1afdb50d4553");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reps",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeID",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Distance",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "Admin", "ADMIN" },
                    { "d2172027-e924-4bbd-be5e-53db9e571f14", "d2172027-e924-4bbd-be5e-53db9e571f14", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9f39f31d-16ad-49f3-942a-2a2909cd14aa", 0, "4a6334f8-5960-42d2-a1e6-84412d8efe16", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEF1X2bVQ0lIAQAA7wkQjGeJcfexP1XaALqFD0N9VlNTjJEZsmVeuWExe1gK43gyZ9g==", null, false, "c8da601d-21b4-4188-acc1-05b949aac5f5", false, "drewxcom" },
                    { "1720a676-602c-4083-bd1f-8813be8cfb7e", 0, "213f441a-a1d8-46c1-b6aa-71c08a930217", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEBZVwKX2wGJE2Y+NfnrHdTT8r6w/6McTy9Z1krg9kUE+U6A6etPj3vkhJKexOfR9NQ==", null, false, "024ab306-93f2-46aa-b6cf-362b06e4b900", false, "chale" },
                    { "cde303cf-f9a0-4886-9a97-eda149f6aa69", 0, "54596207-9bfa-4317-b4f3-5a5690a37d60", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEPu1/3Ic2eXTD6dlYfTz8NIT4dCULdANkT7GNxtJRcaPnOJxtNG8yrHri6I+VMX0Nw==", null, false, "92324e7c-ced5-44b5-9413-58cdf6376876", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "9f39f31d-16ad-49f3-942a-2a2909cd14aa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "1720a676-602c-4083-bd1f-8813be8cfb7e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c85e47b-2d6f-49dc-8f86-1d6dd77cf1af", "cde303cf-f9a0-4886-9a97-eda149f6aa69" });

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
