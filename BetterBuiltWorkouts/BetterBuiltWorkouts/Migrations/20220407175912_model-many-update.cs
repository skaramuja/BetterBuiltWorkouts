using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class modelmanyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExercisePlan");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e13213e-6be5-49f5-a8df-227e62a6a183");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "2db08e46-b1da-4baf-b361-4d05ad25771d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "9b83dac5-f553-4194-b8e9-cdee7f9753a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "dd05b536-933a-490d-9899-9f8c061cfe48" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2db08e46-b1da-4baf-b361-4d05ad25771d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b83dac5-f553-4194-b8e9-cdee7f9753a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd05b536-933a-490d-9899-9f8c061cfe48");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ExercisePlan",
                columns: table => new
                {
                    ExercisesExerciseId = table.Column<int>(type: "int", nullable: false),
                    PlansPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisePlan", x => new { x.ExercisesExerciseId, x.PlansPlanId });
                    table.ForeignKey(
                        name: "FK_ExercisePlan_Exercises_ExercisesExerciseId",
                        column: x => x.ExercisesExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExercisePlan_Plans_PlansPlanId",
                        column: x => x.PlansPlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "Admin", "ADMIN" },
                    { "6e13213e-6be5-49f5-a8df-227e62a6a183", "6e13213e-6be5-49f5-a8df-227e62a6a183", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dd05b536-933a-490d-9899-9f8c061cfe48", 0, "57bdf0a5-6120-4d2d-9e8a-3ae8634b4796", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAELn62fCxupQ7mHiV+U25T3o7RO57k0IaMu7+ClrxC065KsRauXs19qD93lmi8ynPAA==", null, false, "8152b928-8f97-41db-aaab-70f77586c894", false, "drewxcom" },
                    { "2db08e46-b1da-4baf-b361-4d05ad25771d", 0, "aa7d235c-af3e-492d-9dcb-1931aff22fcf", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAELX6BFLa/hU76w5mqDep2hByCrFU1/l3WbsW8TwUmJVVWfmryYy5x1JedxJnHNXiqA==", null, false, "6bd41edf-f101-4bc4-9b6f-b90379093e95", false, "chale" },
                    { "9b83dac5-f553-4194-b8e9-cdee7f9753a8", 0, "d72772fc-bb89-462b-a1f5-b45dd9b25b36", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEGgrZXBtpY6DAfyBOo4U0MGVdo1kE14ghD4xal/nJdvQC+QaKmSZCpdPfmiv0xSl+A==", null, false, "c47f10a7-7eae-4e9a-8ca2-9137d2696d42", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "dd05b536-933a-490d-9899-9f8c061cfe48" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "2db08e46-b1da-4baf-b361-4d05ad25771d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbaa3fe9-62fa-4583-9924-fd3e7ca02d32", "9b83dac5-f553-4194-b8e9-cdee7f9753a8" });

            migrationBuilder.CreateIndex(
                name: "IX_ExercisePlan_PlansPlanId",
                table: "ExercisePlan",
                column: "PlansPlanId");
        }
    }
}
