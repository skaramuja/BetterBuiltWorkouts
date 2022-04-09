using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e59cab6-123e-49be-8314-447834545cd6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "316bd4fc-eceb-492e-abe8-06eb0d6a324f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "8c7b88b3-6863-4e6e-967c-00fac9afb6aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "abe57003-0b83-4ca6-b3c9-8472cb58deea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d14c42e-61b6-4c73-a0f5-97f926691788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "316bd4fc-eceb-492e-abe8-06eb0d6a324f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c7b88b3-6863-4e6e-967c-00fac9afb6aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abe57003-0b83-4ca6-b3c9-8472cb58deea");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4d14c42e-61b6-4c73-a0f5-97f926691788", "4d14c42e-61b6-4c73-a0f5-97f926691788", "Admin", "ADMIN" },
                    { "4e59cab6-123e-49be-8314-447834545cd6", "4e59cab6-123e-49be-8314-447834545cd6", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abe57003-0b83-4ca6-b3c9-8472cb58deea", 0, "212bf5ec-25da-43ab-973f-beded69630ba", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEDonWXtM9TFsTLjEQa0dfCxhle1sdLpaFOXfLIYBlavZp9eu3mRovvNVtxkNc6+QTA==", null, false, "8fff8e0f-a8d2-4525-92d3-30de0517a8ca", false, "drewxcom" },
                    { "316bd4fc-eceb-492e-abe8-06eb0d6a324f", 0, "ad6a6fd8-4e1a-4699-a1b3-3cb43b8cc942", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEAlzznCZ70SoqXjqkeM+TRHSgs59jJ/k+Wl5vFWipwrxxepWtRFkN4Crodyl/ygR5g==", null, false, "fbc7ca5b-cc90-4cd4-a4ac-d423adf28cb7", false, "chale" },
                    { "8c7b88b3-6863-4e6e-967c-00fac9afb6aa", 0, "3eca8f41-14bf-450e-9f41-0dfdd5fe9539", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAELZqmC9ncKle8fhdKra3Fi9/Feh6+RWkgHcuy39xzZsNqkRmRVQTR9T6rYpNeGu/FA==", null, false, "bf858138-f9b7-4f2e-a86a-d432dcbf7169", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "abe57003-0b83-4ca6-b3c9-8472cb58deea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "316bd4fc-eceb-492e-abe8-06eb0d6a324f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d14c42e-61b6-4c73-a0f5-97f926691788", "8c7b88b3-6863-4e6e-967c-00fac9afb6aa" });
        }
    }
}
