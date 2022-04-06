using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Add_Plans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ExercisePlans",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisePlans", x => new { x.ExerciseId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_ExercisePlans_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExercisePlans_Plans_PlanId",
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
                table: "ExercisePlans",
                columns: new[] { "ExerciseId", "PlanId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "Name" },
                values: new object[] { "Better Built Systems", "Default Plan 1" });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "CreatedBy", "ExerciseId", "Name", "TimesCompleted" },
                values: new object[,]
                {
                    { 2, "Better Built Systems", null, "Default Plan 2", null },
                    { 3, "Better Built Systems", null, "Default Plan 3", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "9dc93f37-0935-4326-942d-98cc383b0e91" },
                    { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "583b5016-a84f-4505-9288-d0c27ba30661" },
                    { "a43b3c9c-5670-4642-bbbf-0c3cd84f5f1a", "fd9f9c24-90b1-4939-a4d4-93156250cdd7" }
                });

            migrationBuilder.InsertData(
                table: "ExercisePlans",
                columns: new[] { "ExerciseId", "PlanId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExercisePlans_PlanId",
                table: "ExercisePlans",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExercisePlans");

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

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "PlanId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "Name" },
                values: new object[] { null, "Basic Plan 1" });

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
        }
    }
}
