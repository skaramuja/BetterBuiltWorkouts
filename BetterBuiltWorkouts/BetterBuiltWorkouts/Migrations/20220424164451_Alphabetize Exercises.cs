using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class AlphabetizeExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40622de6-d0aa-47f9-a3e6-b89b3156b92c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "263913a3-9deb-4331-85c7-d0db39175713" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "9c40a624-6363-4272-aadc-4925653e6d23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "fceaf3a3-ff99-42e6-8d10-b11b42288c96" });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d17830-47a0-40fe-a89b-05ffe4a901f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "263913a3-9deb-4331-85c7-d0db39175713");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c40a624-6363-4272-aadc-4925653e6d23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fceaf3a3-ff99-42e6-8d10-b11b42288c96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38fb147a-650e-4d80-91ff-cf442a84eebc", "38fb147a-650e-4d80-91ff-cf442a84eebc", "Admin", "ADMIN" },
                    { "5b6d9997-d9d6-4942-adba-39fbe7c7e2de", "5b6d9997-d9d6-4942-adba-39fbe7c7e2de", "Suspended", "SUSPENDED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "029307dc-85f7-4736-885b-6ebc8bcb3d79", 0, "549ac1a4-ed20-47ea-93c0-04afe0f7a868", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEH9xS61DjpDvRhpPYzhhzny3DCXjzAgWcDxV5F29cHPy+AhRMWf7Lz3ObeoC0wL0+w==", null, false, "4fefd536-66f3-4582-be8a-1fd0906c958c", false, "drewxcom" },
                    { "63662c92-9cc0-4ffc-ad43-fe2a2b13548a", 0, "f0f60756-d77f-4a6f-9620-9b790bfae679", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAENsEzbrPQ1gC56EQYXTmj+dJBzAIV5T2HDXK8n9vTPLFXANMC9zMlN96a7BHnRhk+A==", null, false, "bf0d2b8c-60e6-4bbe-a2ed-502aa6b27302", false, "chale" },
                    { "a3486bf1-a5ef-42bb-a160-880edac8fed2", 0, "3435246e-5376-4ec3-8634-a28fd5ebe2f1", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEAjNwaCFvCU/06X2kiiDHY5vtNogzqB47YGID6iR5dpI6rb9uTruHu2ixaIS+m3Hbg==", null, false, "ab9bea5a-7753-453a-8754-f4655399dbdb", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "BandedTriplanarToeTaps.png", "Banded Triplanar Toe Taps" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Basketball.png", "Basketball" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "BenchPress.png", "Bench Press", 1 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "strength_training", "BicepCurl.png", "Bicep Curl", 1 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "Biking.png", "Biking", 2 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                columns: new[] { "Image", "Name" },
                values: new object[] { "BriskWalking.png", "Brisk Walking" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "CalfStretch.png", "Calf Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "CardioClass.png", "Cardio Class" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "CardioMachine.png", "Cardio Machine" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "strength_training", "ChestFly.png", "Chest Fly", 1 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Crunches.png", "Crunches" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Dancing.png", "Dancing" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "Deadlift.png", "Deadlift" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "FlamingoStand.png", "Flamingo Stand" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                columns: new[] { "Image", "Name" },
                values: new object[] { "GardeningAndWeeding.png", "Gardening and Weeding" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Golf.png", "Golf" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "HamstringStretch.png", "Hamstring Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "HeelToToeWalk.png", "Heel-to-Toe Walk" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "HighIntensityIntervalTraining.png", "High-Intensity Interval Training" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Hiking.png", "Hiking" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "HipFlexorsStretch.png", "Hip Flexors Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "JoggingOrRunning.png", "Jogging or Running", 2 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "KneeToChestStretch.png", "Knee-to-Chest Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                columns: new[] { "Image", "Name" },
                values: new object[] { "LateralRaise.png", "Lateral Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26,
                columns: new[] { "Image", "Name" },
                values: new object[] { "LegCurl.png", "Leg Curl" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27,
                columns: new[] { "Image", "Name" },
                values: new object[] { "LegExtension.png", "Leg Extension" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "LegPress.png", "Leg Press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 29,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "Lunge.png", "Lunge" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "LiftingWeights.png", "Lifting Weights" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "NeckStretch.png", "Neck Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 32,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "Pilates.png", "Pilates" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "PullDown.png", "Pull-down" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34,
                columns: new[] { "Image", "Name" },
                values: new object[] { "PullUp.png", "Pull-up" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "PushUps.png", "Push-ups" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 36,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "QuadricepsStretch.png", "Quadriceps Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                columns: new[] { "Image", "Name" },
                values: new object[] { "ResistanceExercise.png", "Resistance Exercise with Elastic Bands or Tubes" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 38,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Rowing.png", "Rowing" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 39,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "SeatedCalfRaise.png", "Seated Calf Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 40,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "ShoulderPress.png", "Shoulder Press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41,
                columns: new[] { "Image", "Name" },
                values: new object[] { "ShoulderShrug.png", "Shoulder Shrug" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 42,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "ShoulderStretch.png", "Shoulder Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 43,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Soccer.png", "Soccer" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 44,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "Squat.png", "Squat" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 45,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Stairs.png", "Stairs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 46,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "StandingCalfRaise.png", "Standing Calf Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 47,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "StrengthClass.png", "Strength Class" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 48,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "aerobic", "Swimming.png", "Swimming", 2 });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 49,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "TaiChi.png", "Tai Chi" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 50,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Tennis.png", "Tennis" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 51,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "TightropeWalk.png", "Tightrope Walk" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 52,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "TricepExtension.png", "Tricep Extension" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 53,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "UltimateFrisbee.png", "Ultimate Frisbee" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 54,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "UprightRow.png", "Upright Row" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 55,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Volleyball.png", "Volleyball" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 56,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "WalkingWithStroller.png", "Walking with a Stroller" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 57,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Yoga.png", "Yoga" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "029307dc-85f7-4736-885b-6ebc8bcb3d79" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "63662c92-9cc0-4ffc-ad43-fe2a2b13548a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "a3486bf1-a5ef-42bb-a160-880edac8fed2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6d9997-d9d6-4942-adba-39fbe7c7e2de");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "029307dc-85f7-4736-885b-6ebc8bcb3d79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "63662c92-9cc0-4ffc-ad43-fe2a2b13548a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38fb147a-650e-4d80-91ff-cf442a84eebc", "a3486bf1-a5ef-42bb-a160-880edac8fed2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38fb147a-650e-4d80-91ff-cf442a84eebc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "029307dc-85f7-4736-885b-6ebc8bcb3d79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63662c92-9cc0-4ffc-ad43-fe2a2b13548a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3486bf1-a5ef-42bb-a160-880edac8fed2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40622de6-d0aa-47f9-a3e6-b89b3156b92c", "40622de6-d0aa-47f9-a3e6-b89b3156b92c", "Suspended", "SUSPENDED" },
                    { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "80d17830-47a0-40fe-a89b-05ffe4a901f8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fceaf3a3-ff99-42e6-8d10-b11b42288c96", 0, "aa0a64f4-76b2-4d3c-9caf-0641b16fbb09", "drewxcom@gmail.com", true, "Drew", "Crawford", false, null, "DREWXCOM@GMAIL.COM", "DREWXCOM", "AQAAAAEAACcQAAAAEJkCqDRb5F5TE0LH2OnmykiLIHnb/+11qTzjtiaxtvtwSy2L7cyEN4y2aYfkBKzO4Q==", null, false, "c10739d8-1b51-419f-bf93-99f99f2f507a", false, "drewxcom" },
                    { "9c40a624-6363-4272-aadc-4925653e6d23", 0, "7182ee06-aa15-4de6-9746-89448f2d8583", "hale.l.c91@gmail.com", true, "Cody", "Hale", false, null, "HALE.L.C91@GMAIL.COM", "CHALE", "AQAAAAEAACcQAAAAEGmSceuZjCA7kucs3fnS587TdTKea3/6NerUdHtfz5IIC8LFvIWermWlwAe3xjJI4g==", null, false, "272af3f1-7237-46fa-9718-72e2a20bf5fa", false, "chale" },
                    { "263913a3-9deb-4331-85c7-d0db39175713", 0, "cc40be50-db3e-4fbf-b7c3-ad19cc1f31a2", "Karamuja.sabina@gmail.com", true, "Sabina", "Johnson", false, null, "KARAMUJA.SABINA@GMAIL.COM", "SKARAMUJA", "AQAAAAEAACcQAAAAEEZWQJd8zyDzo1NhZpghpT+Qv8lJeDPfoQ8HFaSb4GWJs6THmrZ+473Th8JldQmEtQ==", null, false, "84620331-a961-48ec-a49f-71d107cb4cff", false, "skaramuja" }
                });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Basketball.png", "Basketball" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "BenchPress.png", "Bench Press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "BicepCurl.png", "Bicep Curl", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "aerobic", "Biking.png", "Biking", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "BriskWalking.png", "Brisk Walking", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                columns: new[] { "Image", "Name" },
                values: new object[] { "CardioClass.png", "Cardio Class" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "CardioMachine.png", "Cardio Machine" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "ChestFly.png", "Chest Fly" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "Crunches.png", "Crunches" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "aerobic", "Dancing.png", "Dancing", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Deadlift.png", "Deadlift" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13,
                columns: new[] { "Image", "Name" },
                values: new object[] { "GardeningAndWeeding.png", "Gardening and Weeding" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Golf.png", "Golf" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "HighIntensityIntervalTraining.png", "High-Intensity Interval Training" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Hiking.png", "Hiking" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                columns: new[] { "Image", "Name" },
                values: new object[] { "JoggingOrRunning.png", "Jogging or Running" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "LateralRaise.png", "Lateral Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "LegCurl.png", "Leg Curl" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "LegExtension.png", "Leg Extension" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "LegPress.png", "Leg Press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "Lunge.png", "Lunge" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23,
                columns: new[] { "Image", "Name", "PlanId" },
                values: new object[] { "LiftingWeights.png", "Lifting Weights", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "Pilates.png", "Pilates" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25,
                columns: new[] { "Image", "Name" },
                values: new object[] { "PullDown.png", "Pull-down" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26,
                columns: new[] { "Image", "Name" },
                values: new object[] { "PullUp.png", "Pull-up" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27,
                columns: new[] { "Image", "Name" },
                values: new object[] { "PushUps.png", "Push-ups" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "ResistanceExercise.png", "Resistance Exercise with Elastic Bands or Tubes" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 29,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Rowing.png", "Rowing" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "SeatedCalfRaise.png", "Seated Calf Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "ShoulderPress.png", "Shoulder Press" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 32,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "ShoulderShrug.png", "Shoulder Shrug" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Soccer.png", "Soccer" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Squat.png", "Squat" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Stairs.png", "Stairs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 36,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "StandingCalfRaise.png", "Standing Calf Raise" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37,
                columns: new[] { "Image", "Name" },
                values: new object[] { "StrengthClass.png", "Strength Class" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 38,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Swimming.png", "Swimming" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 39,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "TaiChi.png", "Tai Chi" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 40,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Tennis.png", "Tennis" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41,
                columns: new[] { "Image", "Name" },
                values: new object[] { "TricepExtension.png", "Tricep Extension" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 42,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "UltimateFrisbee.png", "Ultimate Frisbee" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 43,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "strength_training", "UprightRow.png", "Upright Row" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 44,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Volleyball.png", "Volleyball" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 45,
                columns: new[] { "Image", "Name" },
                values: new object[] { "WalkingWithStroller.png", "Walking with a Stroller" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 46,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "aerobic", "Yoga.png", "Yoga" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 47,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "CalfStretch.png", "Calf Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 48,
                columns: new[] { "ExerciseTypeID", "Image", "Name", "PlanId" },
                values: new object[] { "streching", "HamstringStretch.png", "Hamstring Stretch", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 49,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "QuadricepsStretch.png", "Quadriceps Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 50,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "HipFlexorsStretch.png", "Hip Flexors Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 51,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "KneeToChestStretch.png", "Knee-to-Chest Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 52,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "ShoulderStretch.png", "Shoulder Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 53,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "streching", "NeckStretch.png", "Neck Stretch" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 54,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "TightropeWalk.png", "Tightrope Walk" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 55,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "FlamingoStand.png", "Flamingo Stand" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 56,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "HeelToToeWalk.png", "Heel-to-Toe Walk" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 57,
                columns: new[] { "ExerciseTypeID", "Image", "Name" },
                values: new object[] { "balance", "BandedTriplanarToeTaps.png", "Banded Triplanar Toe Taps" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "CreatedBy", "Distance", "ExerciseTypeID", "Image", "Name", "Note", "PlanId", "Reps", "Time", "Weight" },
                values: new object[,]
                {
                    { 58, "Better Built Systems", null, "strength_training", "BenchPress.png", "Bench Press", null, 1, null, null, null },
                    { 59, "Better Built Systems", null, "strength_training", "BicepCurl.png", "Bicep Curl", null, 1, null, null, null },
                    { 60, "Better Built Systems", null, "strength_training", "ChestFly.png", "Chest Fly", null, 1, null, null, null },
                    { 61, "Better Built Systems", null, "aerobic", "Biking.png", "Biking", null, 2, null, null, null },
                    { 62, "Better Built Systems", null, "aerobic", "Swimming.png", "Swimming", null, 2, null, null, null },
                    { 63, "Better Built Systems", null, "aerobic", "JoggingOrRunning.png", "Jogging or Running", null, 2, null, null, null },
                    { 64, "Better Built Systems", null, "streching", "HipFlexorsStretch.png", "Hip Flexors Stretch", null, 3, null, null, null },
                    { 65, "Better Built Systems", null, "streching", "KneeToChestStretch.png", "Knee-to-Chest Stretch", null, 3, null, null, null },
                    { 67, "Better Built Systems", null, "streching", "NeckStretch.png", "Neck Stretch", null, 3, null, null, null },
                    { 66, "Better Built Systems", null, "streching", "ShoulderStretch.png", "Shoulder Stretch", null, 3, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "fceaf3a3-ff99-42e6-8d10-b11b42288c96" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "9c40a624-6363-4272-aadc-4925653e6d23" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d17830-47a0-40fe-a89b-05ffe4a901f8", "263913a3-9deb-4331-85c7-d0db39175713" });
        }
    }
}
