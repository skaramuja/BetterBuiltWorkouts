using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class DatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    ExerciseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.ExerciseID);
                });

            migrationBuilder.CreateTable(
                name: "ExcersiseType",
                columns: table => new
                {
                    ExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcersiseType", x => x.ExerciseTypeID);
                    table.ForeignKey(
                        name: "FK_ExcersiseType_Exercise_ExerciseID",
                        column: x => x.ExerciseID,
                        principalTable: "Exercise",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ExcersiseType",
                columns: new[] { "ExerciseTypeID", "ExerciseID", "Name" },
                values: new object[,]
                {
                    { "balance", null, "Balance" },
                    { "aerobic", null, "Aerobic" },
                    { "streching", null, "Stretching" },
                    { "strength_training", null, "Strength Training" }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ExerciseID", "Image", "Name" },
                values: new object[,]
                {
                    { "d6014007-0233-4688-8496-8eb8dc257207", "BandedTriplanarToeTaps.png", "Banded Triplanar Toe Taps" },
                    { "0b73db3e-79c5-4c39-84a2-73202e2a50d1", "Soccer.png", "Soccer" },
                    { "dbe8ec95-55c0-458c-88b4-3f498489571f", "Squat.png", "Squat" },
                    { "383e3184-0f0f-4f10-aa9e-617f3310c487", "Stairs.png", "Stairs" },
                    { "d80a3240-b7cf-49ce-b9f4-5c5f28674bd0", "StandingCalfRaise.png", "Standing Calf Raise" },
                    { "a81e3b79-b91c-47a1-be30-445f816e8acc", "StrengthClass.png", "Strength Class" },
                    { "9bf9b6a5-cbaa-44fd-9041-fea6eaf4c00b", "Swimming.png", "Swimming" },
                    { "fd455b61-f96f-4463-9d8d-a250644b66f2", "TaiChi.png", "Tai Chi" },
                    { "f01f30f6-0545-4419-aa56-33deda68e4f2", "Tennis.png", "Tennis" },
                    { "3398a21b-d450-4729-84ff-91c587e791fb", "TricepExtension.png", "Tricep Extension" },
                    { "6d12aeff-cb64-491f-8ffb-88aeec6f28d2", "UltimateFrisbee.png", "Ultimate Frisbee" },
                    { "55aaa08a-f24c-45ab-beeb-b205e8715cee", "UprightRow.png", "Upright Row" },
                    { "fcc18a2a-c8a4-481f-bdf7-ff0f0c3dd572", "Volleyball.png", "Volleyball" },
                    { "2a859216-92b9-4c45-abe3-c1d62d3c7386", "ShoulderShrug.png", "Shoulder Shrug" },
                    { "784c99bc-3f3d-447f-bbc5-047073e72ede", "CalfStretch.png", "Calf Stretch" },
                    { "07ee99cb-a437-4c5a-9c63-5ed0b8881b88", "HamstringStretch.png", "Hamstring Stretch" },
                    { "39809ec8-a82b-4018-98eb-0262c7ff6ab5", "QuadricepsStretch.png", "Quadriceps Stretch" },
                    { "ee02fbc6-5c17-4193-a407-acd1a16d97db", "HipFlexorsStretch.png", "Hip Flexors Stretch" },
                    { "c9e43654-3fea-447a-9005-a9677e30ea0a", "KneeToChestStretch.png", "Knee-to-Chest Stretch" },
                    { "ba826abd-0faa-47c2-800f-14c892c6a6cf", "ShoulderStretch.png", "Shoulder Stretch" },
                    { "eb2cfc73-9935-428f-9bbf-3873f8899b48", "NeckStretch.png", "Neck Stretch" },
                    { "f659ebec-9196-424b-8245-d83200ddf1c1", "TightropeWalk.png", "Tightrope Walk" },
                    { "7d547024-da6b-428e-b75c-b3dd9010dc7a", "FlamingoStand.png", "Flamingo Stand" },
                    { "6003b0eb-5412-4331-98ad-9f9a31f64d87", "HeelToToeWalk.png", "Heel-to-Toe Walk" },
                    { "5f996ce4-7c42-4372-8cc2-6905d9f855bc", "WalkingWithStroller.png", "Walking with a Stroller" },
                    { "d1954921-5890-450f-901a-a5d3781e2064", "Yoga.png", "Yoga" },
                    { "70f3bf4f-b8c3-4575-ad10-9b5abcc9f403", "ShoulderPress.png", "Shoulder Press" },
                    { "5ce15d39-13c8-44bb-8777-606dd75eb1b6", "Rowing.png", "Rowing" },
                    { "0fbdd46c-2c1c-4714-8862-1027a1507d48", "Basketball.png", "Basketball" },
                    { "36a710ed-e131-4109-a9ea-68b5103ded88", "BenchPress.png", "Bench Press" },
                    { "c37dbdbc-4c80-4eba-812b-2532d079f51d", "BicepCurl.png", "Bicep Curl" },
                    { "a2602232-9e81-4426-9534-1fa28ed46f03", "Biking.png", "Biking" },
                    { "d3a5d568-cc64-4ac2-a8cf-89ba7e6ac313", "BriskWalking.png", "Brisk Walking" },
                    { "7bb1fc0d-d4b7-49c1-a194-1071a505447d", "CardioClass.png", "Cardio Class" },
                    { "2c4892b6-bd35-4721-9ee0-7390aca29aa4", "CardioMachine.png", "Cardio Machine" },
                    { "fba7c5db-62b0-498c-ae50-d71cdc8bc03d", "ChestFly.png", "Chest Fly" },
                    { "09225d37-099c-4d92-b92f-573238275e60", "Crunches.png", "Crunches" },
                    { "263da85f-11cb-40b8-a46c-4d44e0de4b61", "Dancing.png", "Dancing" }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ExerciseID", "Image", "Name" },
                values: new object[,]
                {
                    { "4b24d8d2-17cc-48f9-bbfb-9806558382bd", "Deadlift.png", "Deadlift" },
                    { "fcf92528-8837-4ec8-a3fe-fc69131122cc", "GardeningAndWeeding.png", "Gardening and Weeding" },
                    { "593fe2ab-25b9-411e-bcd3-509278f4ca75", "Golf.png", "Golf" },
                    { "6492c5d9-e870-4272-b671-d9dcd2d5e753", "HighIntensityIntervalTraining.png", "High-Intensity Interval Training" },
                    { "5bd3fb30-c732-4a13-8c50-11436d9699cb", "Hiking.png", "Hiking" },
                    { "ddf87e95-6025-4575-b6e0-3be747a21f7a", "JoggingOrRunning.png", "Jogging or Running" },
                    { "21feedca-86d0-4e15-8c03-8b1cff77d111", "LateralRaise.png", "Lateral Raise" },
                    { "97ec7f49-4e07-45a0-8dbf-d0a378fe2ff5", "LegCurl.png", "Leg Curl" },
                    { "850f15cf-73f5-469b-a370-53f37c5af815", "LegExtension.png", "Leg Extension" },
                    { "0263b2d1-2156-42c9-b6d8-b74dfd77d15c", "LegPress.png", "Leg Press" },
                    { "a6a7fd68-ddd4-4ec5-8669-1bc1d860f142", "Lunge.png", "Lunge" },
                    { "1a10b635-7f7d-48f8-8210-b98ca0ba3593", "LiftingWeights.png", "Lifting Weights" },
                    { "a859c8ee-1611-4c36-ba33-65431b9ea5be", "Pilates.png", "Pilates" },
                    { "9f0ff33e-6300-449c-9312-ead13bfd7f54", "PullDown.png", "Pull-down" },
                    { "ff720fa6-a4c6-4cbb-a04b-44a5f776869d", "PullUp.png", "Pull-up" },
                    { "bf068445-0818-450d-a7f8-54b3479756d8", "PushUps.png", "Push-ups" },
                    { "cea68f5f-f97d-4dd3-9f66-39ea0d5e2647", "ResistanceExercise.png", "Resistance Exercise with Elastic Bands or Tubes" },
                    { "c71c6641-4ba3-4e7e-94ce-5cd352ca9dc7", "SeatedCalfRaise.png", "Seated Calf Raise" },
                    { "50c8dd43-1e2c-4d69-bba8-26b7449e04cd", "BackExtension.png", "Back Extension" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExcersiseType_ExerciseID",
                table: "ExcersiseType",
                column: "ExerciseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcersiseType");

            migrationBuilder.DropTable(
                name: "Exercise");
        }
    }
}
