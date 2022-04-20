using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTypes",
                columns: table => new
                {
                    ExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTypes", x => x.ExerciseTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Time = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Reps = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                        column: x => x.ExerciseTypeID,
                        principalTable: "ExerciseTypes",
                        principalColumn: "ExerciseTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "6a299da0-8cce-487c-9340-acb0f9f5ae04", "Admin", "ADMIN" },
                    { "90a52f39-2660-4948-bcbc-77d12b727d3f", "90a52f39-2660-4948-bcbc-77d12b727d3f", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6de9e11d-f012-450a-8dc2-8ae58d510403", 0, "138c920a-4d5c-44cf-91a3-d6fcf8d9b3b7", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEEt+sWNWr8yrU0VKPtg48pC9QpuUK1gvi4amIdwI44AAHnNQJIbEHDaD+GcRL63zxQ==", null, false, "1f44b440-222e-412c-a399-61643f666608", false, "drewxcom" },
                    { "3e45d3e9-4d3c-4e20-9ace-e3d32a554134", 0, "d46649fd-b659-4272-965c-719b1b58e9fa", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEG+NkD0roVTv0/uXbyVozi9Z71Er2uSC3Ul6xpMKSqqgQAljLou7A/hGqvwm2dVOjg==", null, false, "e1434804-7a6b-4b31-a959-8305fa1f2b76", false, "chale" },
                    { "f0f0ae27-d4f3-45ea-a383-e0a919a41462", 0, "121a6103-08d8-4e0c-8e94-d55207f41201", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEHR0XHmx3gimo3ta5Z7ZTU05+PQdohouC8jO5qLJ7dKHiRO+IykDxz5F61cbVfyo8w==", null, false, "cfab60da-771a-44bd-97e8-0f5f4cc7b1ad", false, "skaramuja" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseTypes",
                columns: new[] { "ExerciseTypeID", "Name" },
                values: new object[,]
                {
                    { "aerobic", "Aerobic" },
                    { "strength_training", "Strength Training" },
                    { "streching", "Stretching" },
                    { "balance", "Balance" },
                    { "other", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "CreatedBy", "End", "Name", "Start" },
                values: new object[,]
                {
                    { 1, "Better Built Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Example Plan 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Better Built Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Example Plan 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Better Built Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Example Plan 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "f0f0ae27-d4f3-45ea-a383-e0a919a41462" },
                    { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "3e45d3e9-4d3c-4e20-9ace-e3d32a554134" },
                    { "6a299da0-8cce-487c-9340-acb0f9f5ae04", "6de9e11d-f012-450a-8dc2-8ae58d510403" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CreatedBy", "Distance", "ExerciseTypeID", "Image", "Name", "Note", "PlanId", "Reps", "Time", "Weight" },
                values: new object[,]
                {
                    { 67, "Better Built Systems", null, "streching", "NeckStretch.png", "Neck Stretch", null, 3, null, null, null },
                    { 27, "Better Built Systems", null, "strength_training", "PushUps.png", "Push-ups", null, null, null, null, null },
                    { 30, "Better Built Systems", null, "strength_training", "SeatedCalfRaise.png", "Seated Calf Raise", null, null, null, null, null },
                    { 31, "Better Built Systems", null, "strength_training", "ShoulderPress.png", "Shoulder Press", null, null, null, null, null },
                    { 32, "Better Built Systems", null, "strength_training", "ShoulderShrug.png", "Shoulder Shrug", null, null, null, null, null },
                    { 34, "Better Built Systems", null, "strength_training", "Squat.png", "Squat", null, null, null, null, null },
                    { 36, "Better Built Systems", null, "strength_training", "StandingCalfRaise.png", "Standing Calf Raise", null, null, null, null, null },
                    { 41, "Better Built Systems", null, "strength_training", "TricepExtension.png", "Tricep Extension", null, null, null, null, null },
                    { 43, "Better Built Systems", null, "strength_training", "UprightRow.png", "Upright Row", null, null, null, null, null },
                    { 47, "Better Built Systems", null, "streching", "CalfStretch.png", "Calf Stretch", null, null, null, null, null },
                    { 48, "Better Built Systems", null, "streching", "HamstringStretch.png", "Hamstring Stretch", null, null, null, null, null },
                    { 49, "Better Built Systems", null, "streching", "QuadricepsStretch.png", "Quadriceps Stretch", null, null, null, null, null },
                    { 50, "Better Built Systems", null, "streching", "HipFlexorsStretch.png", "Hip Flexors Stretch", null, null, null, null, null },
                    { 51, "Better Built Systems", null, "streching", "KneeToChestStretch.png", "Knee-to-Chest Stretch", null, null, null, null, null },
                    { 52, "Better Built Systems", null, "streching", "ShoulderStretch.png", "Shoulder Stretch", null, null, null, null, null },
                    { 53, "Better Built Systems", null, "streching", "NeckStretch.png", "Neck Stretch", null, null, null, null, null },
                    { 39, "Better Built Systems", null, "balance", "TaiChi.png", "Tai Chi", null, null, null, null, null },
                    { 54, "Better Built Systems", null, "balance", "TightropeWalk.png", "Tightrope Walk", null, null, null, null, null },
                    { 55, "Better Built Systems", null, "balance", "FlamingoStand.png", "Flamingo Stand", null, null, null, null, null },
                    { 56, "Better Built Systems", null, "balance", "HeelToToeWalk.png", "Heel-to-Toe Walk", null, null, null, null, null },
                    { 57, "Better Built Systems", null, "balance", "BandedTriplanarToeTaps.png", "Banded Triplanar Toe Taps", null, null, null, null, null },
                    { 58, "Better Built Systems", null, "strength_training", "BenchPress.png", "Bench Press", null, 1, null, null, null },
                    { 59, "Better Built Systems", null, "strength_training", "BicepCurl.png", "Bicep Curl", null, 1, null, null, null },
                    { 60, "Better Built Systems", null, "strength_training", "ChestFly.png", "Chest Fly", null, 1, null, null, null },
                    { 61, "Better Built Systems", null, "aerobic", "Biking.png", "Biking", null, 2, null, null, null },
                    { 62, "Better Built Systems", null, "aerobic", "Swimming.png", "Swimming", null, 2, null, null, null },
                    { 63, "Better Built Systems", null, "aerobic", "JoggingOrRunning.png", "Jogging or Running", null, 2, null, null, null },
                    { 64, "Better Built Systems", null, "streching", "HipFlexorsStretch.png", "Hip Flexors Stretch", null, 3, null, null, null },
                    { 65, "Better Built Systems", null, "streching", "KneeToChestStretch.png", "Knee-to-Chest Stretch", null, 3, null, null, null },
                    { 66, "Better Built Systems", null, "streching", "ShoulderStretch.png", "Shoulder Stretch", null, 3, null, null, null },
                    { 26, "Better Built Systems", null, "strength_training", "PullUp.png", "Pull-up", null, null, null, null, null },
                    { 24, "Better Built Systems", null, "balance", "Pilates.png", "Pilates", null, null, null, null, null },
                    { 25, "Better Built Systems", null, "strength_training", "PullDown.png", "Pull-down", null, null, null, null, null },
                    { 21, "Better Built Systems", null, "strength_training", "LegPress.png", "Leg Press", null, null, null, null, null },
                    { 5, "Better Built Systems", null, "aerobic", "Biking.png", "Biking", null, null, null, null, null },
                    { 6, "Better Built Systems", null, "aerobic", "BriskWalking.png", "Brisk Walking", null, null, null, null, null },
                    { 7, "Better Built Systems", null, "aerobic", "CardioClass.png", "Cardio Class", null, null, null, null, null },
                    { 8, "Better Built Systems", null, "aerobic", "CardioMachine.png", "Cardio Machine", null, null, null, null, null },
                    { 11, "Better Built Systems", null, "aerobic", "Dancing.png", "Dancing", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CreatedBy", "Distance", "ExerciseTypeID", "Image", "Name", "Note", "PlanId", "Reps", "Time", "Weight" },
                values: new object[,]
                {
                    { 13, "Better Built Systems", null, "aerobic", "GardeningAndWeeding.png", "Gardening and Weeding", null, null, null, null, null },
                    { 14, "Better Built Systems", null, "aerobic", "Golf.png", "Golf", null, null, null, null, null },
                    { 15, "Better Built Systems", null, "aerobic", "HighIntensityIntervalTraining.png", "High-Intensity Interval Training", null, null, null, null, null },
                    { 16, "Better Built Systems", null, "aerobic", "Hiking.png", "Hiking", null, null, null, null, null },
                    { 17, "Better Built Systems", null, "aerobic", "JoggingOrRunning.png", "Jogging or Running", null, null, null, null, null },
                    { 23, "Better Built Systems", null, "aerobic", "LiftingWeights.png", "Lifting Weights", null, null, null, null, null },
                    { 28, "Better Built Systems", null, "aerobic", "ResistanceExercise.png", "Resistance Exercise with Elastic Bands or Tubes", null, null, null, null, null },
                    { 29, "Better Built Systems", null, "aerobic", "Rowing.png", "Rowing", null, null, null, null, null },
                    { 33, "Better Built Systems", null, "aerobic", "Soccer.png", "Soccer", null, null, null, null, null },
                    { 35, "Better Built Systems", null, "aerobic", "Stairs.png", "Stairs", null, null, null, null, null },
                    { 37, "Better Built Systems", null, "aerobic", "StrengthClass.png", "Strength Class", null, null, null, null, null },
                    { 38, "Better Built Systems", null, "aerobic", "Swimming.png", "Swimming", null, null, null, null, null },
                    { 20, "Better Built Systems", null, "strength_training", "LegExtension.png", "Leg Extension", null, null, null, null, null },
                    { 19, "Better Built Systems", null, "strength_training", "LegCurl.png", "Leg Curl", null, null, null, null, null },
                    { 18, "Better Built Systems", null, "strength_training", "LateralRaise.png", "Lateral Raise", null, null, null, null, null },
                    { 12, "Better Built Systems", null, "strength_training", "Deadlift.png", "Deadlift", null, null, null, null, null },
                    { 10, "Better Built Systems", null, "strength_training", "Crunches.png", "Crunches", null, null, null, null, null },
                    { 9, "Better Built Systems", null, "strength_training", "ChestFly.png", "Chest Fly", null, null, null, null, null },
                    { 22, "Better Built Systems", null, "strength_training", "Lunge.png", "Lunge", null, null, null, null, null },
                    { 4, "Better Built Systems", null, "strength_training", "BicepCurl.png", "Bicep Curl", null, null, null, null, null },
                    { 1, "Better Built Systems", null, "strength_training", "BackExtension.png", "Back Extension", null, null, null, null, null },
                    { 46, "Better Built Systems", null, "aerobic", "Yoga.png", "Yoga", null, null, null, null, null },
                    { 45, "Better Built Systems", null, "aerobic", "WalkingWithStroller.png", "Walking with a Stroller", null, null, null, null, null },
                    { 44, "Better Built Systems", null, "aerobic", "Volleyball.png", "Volleyball", null, null, null, null, null },
                    { 42, "Better Built Systems", null, "aerobic", "UltimateFrisbee.png", "Ultimate Frisbee", null, null, null, null, null },
                    { 40, "Better Built Systems", null, "aerobic", "Tennis.png", "Tennis", null, null, null, null, null },
                    { 3, "Better Built Systems", null, "strength_training", "BenchPress.png", "Bench Press", null, null, null, null, null },
                    { 2, "Better Built Systems", null, "aerobic", "Basketball.png", "Basketball", null, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PlanId",
                table: "Exercises",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

            migrationBuilder.DropTable(
                name: "Plans");
        }
    }
}
