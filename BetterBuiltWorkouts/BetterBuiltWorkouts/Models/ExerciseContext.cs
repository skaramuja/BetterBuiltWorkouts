using Microsoft.EntityFrameworkCore;

namespace BetterBuiltWorkouts.Models
{
    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options)
            : base(options)
        { }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseType>().HasData(
                new ExerciseType { ExerciseTypeID = "aerobic", Name = "Aerobic" },
                new ExerciseType { ExerciseTypeID = "strength_training", Name = "Strength Training" },
                new ExerciseType { ExerciseTypeID = "streching", Name = "Stretching" },
                new ExerciseType { ExerciseTypeID = "balance", Name = "Balance" }
            );
            modelBuilder.Entity<Exercise>().HasData(
                new {
                    ExerciseID = "50c8dd43-1e2c-4d69-bba8-26b7449e04cd",
                    Name = "Back Extension",
                    ExerciseTypeID = "strength_training",
                    Image = "BackExtension.png"
                },
                new
                {
                    ExerciseID = "0fbdd46c-2c1c-4714-8862-1027a1507d48",
                    Name = "Basketball",
                    ExerciseTypeID = "aerobic",
                    Image = "Basketball.png"
                },
                new
                {
                    ExerciseID = "36a710ed-e131-4109-a9ea-68b5103ded88",
                    Name = "Bench Press",
                    ExerciseTypeID = "strength_training",
                    Image = "BenchPress.png"
                },
                new
                {
                    ExerciseID = "c37dbdbc-4c80-4eba-812b-2532d079f51d",
                    Name = "Bicep Curl",
                    ExerciseTypeID = "strength_training",
                    Image = "BicepCurl.png"
                },
                new {
                    ExerciseID = "a2602232-9e81-4426-9534-1fa28ed46f03", 
                    Name = "Biking",
                    ExerciseTypeID = "aerobic", 
                    Image = "Biking.png" 
                },
                new
                {
                    ExerciseID = "d3a5d568-cc64-4ac2-a8cf-89ba7e6ac313",
                    Name = "Brisk Walking",
                    ExerciseTypeID = "aerobic",
                    Image = "BriskWalking.png"
                },
                new {
                    ExerciseID = "7bb1fc0d-d4b7-49c1-a194-1071a505447d", 
                    Name = "Cardio Class",
                    ExerciseTypeID = "aerobic", 
                    Image = "CardioClass.png" 
                },
                new {
                    ExerciseID = "2c4892b6-bd35-4721-9ee0-7390aca29aa4", 
                    Name = "Cardio Machine",
                    ExerciseTypeID = "aerobic", 
                    Image = "CardioMachine.png" 
                },
                new
                {
                    ExerciseID = "fba7c5db-62b0-498c-ae50-d71cdc8bc03d",
                    Name = "Chest Fly",
                    ExerciseTypeID = "strength_training",
                    Image = "ChestFly.png"
                },
                new
                {
                    ExerciseID = "09225d37-099c-4d92-b92f-573238275e60",
                    Name = "Crunches",
                    ExerciseTypeID = "strength_training",
                    Image = "Crunches.png"
                },
                new {
                    ExerciseID = "263da85f-11cb-40b8-a46c-4d44e0de4b61", 
                    Name = "Dancing",
                    ExerciseTypeID = "aerobic", 
                    Image = "Dancing.png" 
                },
                new
                {
                    ExerciseID = "4b24d8d2-17cc-48f9-bbfb-9806558382bd",
                    Name = "Deadlift",
                    ExerciseTypeID = "strength_training",
                    Image = "Deadlift.png"
                },
                new {
                    ExerciseID = "fcf92528-8837-4ec8-a3fe-fc69131122cc", 
                    Name = "Gardening and Weeding",
                    ExerciseTypeID = "aerobic", 
                    Image = "GardeningAndWeeding.png" 
                },
                new {
                    ExerciseID = "593fe2ab-25b9-411e-bcd3-509278f4ca75", 
                    Name = "Golf",
                    ExerciseTypeID = "aerobic", 
                    Image = "Golf.png" 
                },
                new {
                    ExerciseID = "6492c5d9-e870-4272-b671-d9dcd2d5e753", 
                    Name = "High-Intensity Interval Training",
                    ExerciseTypeID = "aerobic", 
                    Image = "HighIntensityIntervalTraining.png" 
                },
                new {
                    ExerciseID = "5bd3fb30-c732-4a13-8c50-11436d9699cb", 
                    Name = "Hiking",
                    ExerciseTypeID = "aerobic", 
                    Image = "Hiking.png" 
                },
                new {
                    ExerciseID = "ddf87e95-6025-4575-b6e0-3be747a21f7a", 
                    Name = "Jogging or Running",
                    ExerciseTypeID = "aerobic", 
                    Image = "JoggingOrRunning.png" 
                },
                new
                {
                    ExerciseID = "21feedca-86d0-4e15-8c03-8b1cff77d111",
                    Name = "Lateral Raise",
                    ExerciseTypeID = "strength_training",
                    Image = "LateralRaise.png"
                },
                new
                {
                    ExerciseID = "97ec7f49-4e07-45a0-8dbf-d0a378fe2ff5",
                    Name = "Leg Curl",
                    ExerciseTypeID = "strength_training",
                    Image = "LegCurl.png"
                },
                new
                {
                    ExerciseID = "850f15cf-73f5-469b-a370-53f37c5af815",
                    Name = "Leg Extension",
                    ExerciseTypeID = "strength_training",
                    Image = "LegExtension.png"
                },
                new
                {
                    ExerciseID = "0263b2d1-2156-42c9-b6d8-b74dfd77d15c",
                    Name = "Leg Press",
                    ExerciseTypeID = "strength_training",
                    Image = "LegPress.png"
                },
                new
                {
                    ExerciseID = "a6a7fd68-ddd4-4ec5-8669-1bc1d860f142",
                    Name = "Lunge",
                    ExerciseTypeID = "strength_training",
                    Image = "Lunge.png"
                },
                new {
                    ExerciseID = "1a10b635-7f7d-48f8-8210-b98ca0ba3593", 
                    Name = "Lifting Weights",
                    ExerciseTypeID = "aerobic", 
                    Image = "LiftingWeights.png" 
                },
                new {
                    ExerciseID = "a859c8ee-1611-4c36-ba33-65431b9ea5be", 
                    Name = "Pilates",
                    ExerciseTypeID = "balance", 
                    Image = "Pilates.png" 
                },
                new
                {
                    ExerciseID = "9f0ff33e-6300-449c-9312-ead13bfd7f54",
                    Name = "Pull-down",
                    ExerciseTypeID = "strength_training",
                    Image = "PullDown.png"
                },
                new
                {
                    ExerciseID = "ff720fa6-a4c6-4cbb-a04b-44a5f776869d",
                    Name = "Pull-up",
                    ExerciseTypeID = "strength_training",
                    Image = "PullUp.png"
                },
                new
                {
                    ExerciseID = "bf068445-0818-450d-a7f8-54b3479756d8",
                    Name = "Push-ups",
                    ExerciseTypeID = "strength_training",
                    Image = "PushUps.png"
                },
                new {
                    ExerciseID = "cea68f5f-f97d-4dd3-9f66-39ea0d5e2647", 
                    Name = "Resistance Exercise with Elastic Bands or Tubes",
                    ExerciseTypeID = "aerobic", 
                    Image = "ResistanceExercise.png" 
                },
                new {
                    ExerciseID = "5ce15d39-13c8-44bb-8777-606dd75eb1b6", 
                    Name = "Rowing",
                    ExerciseTypeID = "aerobic", 
                    Image = "Rowing.png" 
                },
                new
                {
                    ExerciseID = "c71c6641-4ba3-4e7e-94ce-5cd352ca9dc7",
                    Name = "Seated Calf Raise",
                    ExerciseTypeID = "strength_training",
                    Image = "SeatedCalfRaise.png"
                },
                new
                {
                    ExerciseID = "70f3bf4f-b8c3-4575-ad10-9b5abcc9f403",
                    Name = "Shoulder Press",
                    ExerciseTypeID = "strength_training",
                    Image = "ShoulderPress.png"
                },
                new
                {
                    ExerciseID = "2a859216-92b9-4c45-abe3-c1d62d3c7386",
                    Name = "Shoulder Shrug",
                    ExerciseTypeID = "strength_training",
                    Image = "ShoulderShrug.png"
                },
                new {
                    ExerciseID = "0b73db3e-79c5-4c39-84a2-73202e2a50d1", 
                    Name = "Soccer",
                    ExerciseTypeID = "aerobic", 
                    Image = "Soccer.png" 
                },
                new
                {
                    ExerciseID = "dbe8ec95-55c0-458c-88b4-3f498489571f",
                    Name = "Squat",
                    ExerciseTypeID = "strength_training",
                    Image = "Squat.png"
                },
                new {
                    ExerciseID = "383e3184-0f0f-4f10-aa9e-617f3310c487", 
                    Name = "Stairs",
                    ExerciseTypeID = "aerobic", 
                    Image = "Stairs.png" 
                },
                new
                {
                    ExerciseID = "d80a3240-b7cf-49ce-b9f4-5c5f28674bd0",
                    Name = "Standing Calf Raise",
                    ExerciseTypeID = "strength_training",
                    Image = "StandingCalfRaise.png"
                },
                new {
                    ExerciseID = "a81e3b79-b91c-47a1-be30-445f816e8acc", 
                    Name = "Strength Class",
                    ExerciseTypeID = "aerobic", 
                    Image = "StrengthClass.png" 
                },
                new {
                    ExerciseID = "9bf9b6a5-cbaa-44fd-9041-fea6eaf4c00b", 
                    Name = "Swimming",
                    ExerciseTypeID = "aerobic", 
                    Image = "Swimming.png" 
                },
                new
                {
                    ExerciseID = "fd455b61-f96f-4463-9d8d-a250644b66f2",
                    Name = "Tai Chi",
                    ExerciseTypeID = "balance",
                    Image = "TaiChi.png"
                },
                new
                {
                    ExerciseID = "f01f30f6-0545-4419-aa56-33deda68e4f2",
                    Name = "Tennis",
                    ExerciseTypeID = "aerobic",
                    Image = "Tennis.png"
                },
                new
                {
                    ExerciseID = "3398a21b-d450-4729-84ff-91c587e791fb",
                    Name = "Tricep Extension",
                    ExerciseTypeID = "strength_training",
                    Image = "TricepExtension.png"
                },
                new
                {
                    ExerciseID = "6d12aeff-cb64-491f-8ffb-88aeec6f28d2",
                    Name = "Ultimate Frisbee",
                    ExerciseTypeID = "aerobic",
                    Image = "UltimateFrisbee.png"
                },
                new
                {
                    ExerciseID = "55aaa08a-f24c-45ab-beeb-b205e8715cee",
                    Name = "Upright Row",
                    ExerciseTypeID = "strength_training",
                    Image = "UprightRow.png"
                },
                new
                {
                    ExerciseID = "fcc18a2a-c8a4-481f-bdf7-ff0f0c3dd572",
                    Name = "Volleyball",
                    ExerciseTypeID = "aerobic",
                    Image = "Volleyball.png"
                },
                new
                {
                    ExerciseID = "5f996ce4-7c42-4372-8cc2-6905d9f855bc",
                    Name = "Walking with a Stroller",
                    ExerciseTypeID = "aerobic",
                    Image = "WalkingWithStroller.png"
                },
                new
                {
                    ExerciseID = "d1954921-5890-450f-901a-a5d3781e2064",
                    Name = "Yoga",
                    ExerciseTypeID = "aerobic",
                    Image = "Yoga.png"
                },
                new
                {
                    ExerciseID = "784c99bc-3f3d-447f-bbc5-047073e72ede",
                    Name = "Calf Stretch",
                    ExerciseTypeID = "streching",
                    Image = "CalfStretch.png"
                },
                new
                {
                    ExerciseID = "07ee99cb-a437-4c5a-9c63-5ed0b8881b88",
                    Name = "Hamstring Stretch",
                    ExerciseTypeID = "streching",
                    Image = "HamstringStretch.png"
                },
                new
                {
                    ExerciseID = "39809ec8-a82b-4018-98eb-0262c7ff6ab5",
                    Name = "Quadriceps Stretch",
                    ExerciseTypeID = "streching",
                    Image = "QuadricepsStretch.png"
                },
                new
                {
                    ExerciseID = "ee02fbc6-5c17-4193-a407-acd1a16d97db",
                    Name = "Hip Flexors Stretch",
                    ExerciseTypeID = "streching",
                    Image = "HipFlexorsStretch.png"
                },
                new
                {
                    ExerciseID = "c9e43654-3fea-447a-9005-a9677e30ea0a",
                    Name = "Knee-to-Chest Stretch",
                    ExerciseTypeID = "streching",
                    Image = "KneeToChestStretch.png"
                },
                new
                {
                    ExerciseID = "ba826abd-0faa-47c2-800f-14c892c6a6cf",
                    Name = "Shoulder Stretch",
                    ExerciseTypeID = "streching",
                    Image = "ShoulderStretch.png"
                },
                new
                {
                    ExerciseID = "eb2cfc73-9935-428f-9bbf-3873f8899b48",
                    Name = "Neck Stretch",
                    ExerciseTypeID = "streching",
                    Image = "NeckStretch.png"
                },
                new
                {
                    ExerciseID = "f659ebec-9196-424b-8245-d83200ddf1c1",
                    Name = "Tightrope Walk",
                    ExerciseTypeID = "balance",
                    Image = "TightropeWalk.png"
                },
                new
                {
                    ExerciseID = "7d547024-da6b-428e-b75c-b3dd9010dc7a",
                    Name = "Flamingo Stand",
                    ExerciseTypeID = "balance",
                    Image = "FlamingoStand.png"
                },
                new
                {
                    ExerciseID = "6003b0eb-5412-4331-98ad-9f9a31f64d87",
                    Name = "Heel-to-Toe Walk",
                    ExerciseTypeID = "balance",
                    Image = "HeelToToeWalk.png"
                },
                new
                {
                    ExerciseID = "d6014007-0233-4688-8496-8eb8dc257207",
                    Name = "Banded Triplanar Toe Taps",
                    ExerciseTypeID = "balance",
                    Image = "BandedTriplanarToeTaps.png"
                }
            );
        }
    }
}
