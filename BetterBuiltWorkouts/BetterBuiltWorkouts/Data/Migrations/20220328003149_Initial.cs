using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Exercises",
                columns: table => new
                {
                    ExerciseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Reps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseID);
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                        column: x => x.ExerciseTypeID,
                        principalTable: "ExerciseTypes",
                        principalColumn: "ExerciseTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f4c9c4c6-4644-42de-9093-4877067ede23", "62d63c54-8fb0-41ed-9108-14e3316a98b0" },
                    { "f4c9c4c6-4644-42de-9093-4877067ede23", "49e5d625-954b-4f36-ab58-6453ebbd56c7" },
                    { "f4c9c4c6-4644-42de-9093-4877067ede23", "8e881760-9683-455c-ad43-f169a9a02504" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "CreatedBy", "Distance", "ExerciseTypeID", "Image", "IsPublic", "Link", "Name", "Note", "Reps", "Time", "Weight" },
                values: new object[,]
                {
                    { "d6014007-0233-4688-8496-8eb8dc257207", null, null, "balance", "BandedTriplanarToeTaps.png", true, null, "Banded Triplanar Toe Taps", null, null, null, null },
                    { "850f15cf-73f5-469b-a370-53f37c5af815", null, null, "strength_training", "LegExtension.png", true, null, "Leg Extension", null, null, null, null },
                    { "0263b2d1-2156-42c9-b6d8-b74dfd77d15c", null, null, "strength_training", "LegPress.png", true, null, "Leg Press", null, null, null, null },
                    { "a6a7fd68-ddd4-4ec5-8669-1bc1d860f142", null, null, "strength_training", "Lunge.png", true, null, "Lunge", null, null, null, null },
                    { "9f0ff33e-6300-449c-9312-ead13bfd7f54", null, null, "strength_training", "PullDown.png", true, null, "Pull-down", null, null, null, null },
                    { "ff720fa6-a4c6-4cbb-a04b-44a5f776869d", null, null, "strength_training", "PullUp.png", true, null, "Pull-up", null, null, null, null },
                    { "bf068445-0818-450d-a7f8-54b3479756d8", null, null, "strength_training", "PushUps.png", true, null, "Push-ups", null, null, null, null },
                    { "c71c6641-4ba3-4e7e-94ce-5cd352ca9dc7", null, null, "strength_training", "SeatedCalfRaise.png", true, null, "Seated Calf Raise", null, null, null, null },
                    { "70f3bf4f-b8c3-4575-ad10-9b5abcc9f403", null, null, "strength_training", "ShoulderPress.png", true, null, "Shoulder Press", null, null, null, null },
                    { "2a859216-92b9-4c45-abe3-c1d62d3c7386", null, null, "strength_training", "ShoulderShrug.png", true, null, "Shoulder Shrug", null, null, null, null },
                    { "dbe8ec95-55c0-458c-88b4-3f498489571f", null, null, "strength_training", "Squat.png", true, null, "Squat", null, null, null, null },
                    { "d80a3240-b7cf-49ce-b9f4-5c5f28674bd0", null, null, "strength_training", "StandingCalfRaise.png", true, null, "Standing Calf Raise", null, null, null, null },
                    { "3398a21b-d450-4729-84ff-91c587e791fb", null, null, "strength_training", "TricepExtension.png", true, null, "Tricep Extension", null, null, null, null },
                    { "55aaa08a-f24c-45ab-beeb-b205e8715cee", null, null, "strength_training", "UprightRow.png", true, null, "Upright Row", null, null, null, null },
                    { "07ee99cb-a437-4c5a-9c63-5ed0b8881b88", null, null, "streching", "HamstringStretch.png", true, null, "Hamstring Stretch", null, null, null, null },
                    { "39809ec8-a82b-4018-98eb-0262c7ff6ab5", null, null, "streching", "QuadricepsStretch.png", true, null, "Quadriceps Stretch", null, null, null, null },
                    { "ee02fbc6-5c17-4193-a407-acd1a16d97db", null, null, "streching", "HipFlexorsStretch.png", true, null, "Hip Flexors Stretch", null, null, null, null },
                    { "c9e43654-3fea-447a-9005-a9677e30ea0a", null, null, "streching", "KneeToChestStretch.png", true, null, "Knee-to-Chest Stretch", null, null, null, null },
                    { "ba826abd-0faa-47c2-800f-14c892c6a6cf", null, null, "streching", "ShoulderStretch.png", true, null, "Shoulder Stretch", null, null, null, null },
                    { "eb2cfc73-9935-428f-9bbf-3873f8899b48", null, null, "streching", "NeckStretch.png", true, null, "Neck Stretch", null, null, null, null },
                    { "a859c8ee-1611-4c36-ba33-65431b9ea5be", null, null, "balance", "Pilates.png", true, null, "Pilates", null, null, null, null },
                    { "fd455b61-f96f-4463-9d8d-a250644b66f2", null, null, "balance", "TaiChi.png", true, null, "Tai Chi", null, null, null, null },
                    { "f659ebec-9196-424b-8245-d83200ddf1c1", null, null, "balance", "TightropeWalk.png", true, null, "Tightrope Walk", null, null, null, null },
                    { "7d547024-da6b-428e-b75c-b3dd9010dc7a", null, null, "balance", "FlamingoStand.png", true, null, "Flamingo Stand", null, null, null, null },
                    { "6003b0eb-5412-4331-98ad-9f9a31f64d87", null, null, "balance", "HeelToToeWalk.png", true, null, "Heel-to-Toe Walk", null, null, null, null },
                    { "97ec7f49-4e07-45a0-8dbf-d0a378fe2ff5", null, null, "strength_training", "LegCurl.png", true, null, "Leg Curl", null, null, null, null },
                    { "784c99bc-3f3d-447f-bbc5-047073e72ede", null, null, "streching", "CalfStretch.png", true, null, "Calf Stretch", null, null, null, null },
                    { "21feedca-86d0-4e15-8c03-8b1cff77d111", null, null, "strength_training", "LateralRaise.png", true, null, "Lateral Raise", null, null, null, null },
                    { "09225d37-099c-4d92-b92f-573238275e60", null, null, "strength_training", "Crunches.png", true, null, "Crunches", null, null, null, null },
                    { "a2602232-9e81-4426-9534-1fa28ed46f03", null, null, "aerobic", "Biking.png", true, null, "Biking", null, null, null, null },
                    { "d3a5d568-cc64-4ac2-a8cf-89ba7e6ac313", null, null, "aerobic", "BriskWalking.png", true, null, "Brisk Walking", null, null, null, null },
                    { "7bb1fc0d-d4b7-49c1-a194-1071a505447d", null, null, "aerobic", "CardioClass.png", true, null, "Cardio Class", null, null, null, null },
                    { "2c4892b6-bd35-4721-9ee0-7390aca29aa4", null, null, "aerobic", "CardioMachine.png", true, null, "Cardio Machine", null, null, null, null },
                    { "263da85f-11cb-40b8-a46c-4d44e0de4b61", null, null, "aerobic", "Dancing.png", true, null, "Dancing", null, null, null, null },
                    { "fcf92528-8837-4ec8-a3fe-fc69131122cc", null, null, "aerobic", "GardeningAndWeeding.png", true, null, "Gardening and Weeding", null, null, null, null },
                    { "593fe2ab-25b9-411e-bcd3-509278f4ca75", null, null, "aerobic", "Golf.png", true, null, "Golf", null, null, null, null },
                    { "6492c5d9-e870-4272-b671-d9dcd2d5e753", null, null, "aerobic", "HighIntensityIntervalTraining.png", true, null, "High-Intensity Interval Training", null, null, null, null },
                    { "5bd3fb30-c732-4a13-8c50-11436d9699cb", null, null, "aerobic", "Hiking.png", true, null, "Hiking", null, null, null, null },
                    { "ddf87e95-6025-4575-b6e0-3be747a21f7a", null, null, "aerobic", "JoggingOrRunning.png", true, null, "Jogging or Running", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseID", "CreatedBy", "Distance", "ExerciseTypeID", "Image", "IsPublic", "Link", "Name", "Note", "Reps", "Time", "Weight" },
                values: new object[,]
                {
                    { "1a10b635-7f7d-48f8-8210-b98ca0ba3593", null, null, "aerobic", "LiftingWeights.png", true, null, "Lifting Weights", null, null, null, null },
                    { "cea68f5f-f97d-4dd3-9f66-39ea0d5e2647", null, null, "aerobic", "ResistanceExercise.png", true, null, "Resistance Exercise with Elastic Bands or Tubes", null, null, null, null },
                    { "4b24d8d2-17cc-48f9-bbfb-9806558382bd", null, null, "strength_training", "Deadlift.png", true, null, "Deadlift", null, null, null, null },
                    { "5ce15d39-13c8-44bb-8777-606dd75eb1b6", null, null, "aerobic", "Rowing.png", true, null, "Rowing", null, null, null, null },
                    { "383e3184-0f0f-4f10-aa9e-617f3310c487", null, null, "aerobic", "Stairs.png", true, null, "Stairs", null, null, null, null },
                    { "a81e3b79-b91c-47a1-be30-445f816e8acc", null, null, "aerobic", "StrengthClass.png", true, null, "Strength Class", null, null, null, null },
                    { "9bf9b6a5-cbaa-44fd-9041-fea6eaf4c00b", null, null, "aerobic", "Swimming.png", true, null, "Swimming", null, null, null, null },
                    { "f01f30f6-0545-4419-aa56-33deda68e4f2", null, null, "aerobic", "Tennis.png", true, null, "Tennis", null, null, null, null },
                    { "6d12aeff-cb64-491f-8ffb-88aeec6f28d2", null, null, "aerobic", "UltimateFrisbee.png", true, null, "Ultimate Frisbee", null, null, null, null },
                    { "fcc18a2a-c8a4-481f-bdf7-ff0f0c3dd572", null, null, "aerobic", "Volleyball.png", true, null, "Volleyball", null, null, null, null },
                    { "5f996ce4-7c42-4372-8cc2-6905d9f855bc", null, null, "aerobic", "WalkingWithStroller.png", true, null, "Walking with a Stroller", null, null, null, null },
                    { "d1954921-5890-450f-901a-a5d3781e2064", null, null, "aerobic", "Yoga.png", true, null, "Yoga", null, null, null, null },
                    { "50c8dd43-1e2c-4d69-bba8-26b7449e04cd", null, null, "strength_training", "BackExtension.png", true, null, "Back Extension", null, null, null, null },
                    { "36a710ed-e131-4109-a9ea-68b5103ded88", null, null, "strength_training", "BenchPress.png", true, null, "Bench Press", null, null, null, null },
                    { "c37dbdbc-4c80-4eba-812b-2532d079f51d", null, null, "strength_training", "BicepCurl.png", true, null, "Bicep Curl", null, null, null, null },
                    { "fba7c5db-62b0-498c-ae50-d71cdc8bc03d", null, null, "strength_training", "ChestFly.png", true, null, "Chest Fly", null, null, null, null },
                    { "0b73db3e-79c5-4c39-84a2-73202e2a50d1", null, null, "aerobic", "Soccer.png", true, null, "Soccer", null, null, null, null },
                    { "0fbdd46c-2c1c-4714-8862-1027a1507d48", null, null, "aerobic", "Basketball.png", true, null, "Basketball", null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ExerciseTypes");

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
    }
}
