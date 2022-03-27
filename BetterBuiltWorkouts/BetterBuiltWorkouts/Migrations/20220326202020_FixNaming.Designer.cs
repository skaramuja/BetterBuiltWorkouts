﻿// <auto-generated />
using BetterBuiltWorkouts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BetterBuiltWorkouts.Migrations
{
    [DbContext(typeof(ExerciseContext))]
    [Migration("20220326202020_FixNaming")]
    partial class FixNaming
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BetterBuiltWorkouts.Models.Exercise", b =>
                {
                    b.Property<string>("ExerciseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseID");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            ExerciseID = "50c8dd43-1e2c-4d69-bba8-26b7449e04cd",
                            Image = "BackExtension.png",
                            Name = "Back Extension"
                        },
                        new
                        {
                            ExerciseID = "0fbdd46c-2c1c-4714-8862-1027a1507d48",
                            Image = "Basketball.png",
                            Name = "Basketball"
                        },
                        new
                        {
                            ExerciseID = "36a710ed-e131-4109-a9ea-68b5103ded88",
                            Image = "BenchPress.png",
                            Name = "Bench Press"
                        },
                        new
                        {
                            ExerciseID = "c37dbdbc-4c80-4eba-812b-2532d079f51d",
                            Image = "BicepCurl.png",
                            Name = "Bicep Curl"
                        },
                        new
                        {
                            ExerciseID = "a2602232-9e81-4426-9534-1fa28ed46f03",
                            Image = "Biking.png",
                            Name = "Biking"
                        },
                        new
                        {
                            ExerciseID = "d3a5d568-cc64-4ac2-a8cf-89ba7e6ac313",
                            Image = "BriskWalking.png",
                            Name = "Brisk Walking"
                        },
                        new
                        {
                            ExerciseID = "7bb1fc0d-d4b7-49c1-a194-1071a505447d",
                            Image = "CardioClass.png",
                            Name = "Cardio Class"
                        },
                        new
                        {
                            ExerciseID = "2c4892b6-bd35-4721-9ee0-7390aca29aa4",
                            Image = "CardioMachine.png",
                            Name = "Cardio Machine"
                        },
                        new
                        {
                            ExerciseID = "fba7c5db-62b0-498c-ae50-d71cdc8bc03d",
                            Image = "ChestFly.png",
                            Name = "Chest Fly"
                        },
                        new
                        {
                            ExerciseID = "09225d37-099c-4d92-b92f-573238275e60",
                            Image = "Crunches.png",
                            Name = "Crunches"
                        },
                        new
                        {
                            ExerciseID = "263da85f-11cb-40b8-a46c-4d44e0de4b61",
                            Image = "Dancing.png",
                            Name = "Dancing"
                        },
                        new
                        {
                            ExerciseID = "4b24d8d2-17cc-48f9-bbfb-9806558382bd",
                            Image = "Deadlift.png",
                            Name = "Deadlift"
                        },
                        new
                        {
                            ExerciseID = "fcf92528-8837-4ec8-a3fe-fc69131122cc",
                            Image = "GardeningAndWeeding.png",
                            Name = "Gardening and Weeding"
                        },
                        new
                        {
                            ExerciseID = "593fe2ab-25b9-411e-bcd3-509278f4ca75",
                            Image = "Golf.png",
                            Name = "Golf"
                        },
                        new
                        {
                            ExerciseID = "6492c5d9-e870-4272-b671-d9dcd2d5e753",
                            Image = "HighIntensityIntervalTraining.png",
                            Name = "High-Intensity Interval Training"
                        },
                        new
                        {
                            ExerciseID = "5bd3fb30-c732-4a13-8c50-11436d9699cb",
                            Image = "Hiking.png",
                            Name = "Hiking"
                        },
                        new
                        {
                            ExerciseID = "ddf87e95-6025-4575-b6e0-3be747a21f7a",
                            Image = "JoggingOrRunning.png",
                            Name = "Jogging or Running"
                        },
                        new
                        {
                            ExerciseID = "21feedca-86d0-4e15-8c03-8b1cff77d111",
                            Image = "LateralRaise.png",
                            Name = "Lateral Raise"
                        },
                        new
                        {
                            ExerciseID = "97ec7f49-4e07-45a0-8dbf-d0a378fe2ff5",
                            Image = "LegCurl.png",
                            Name = "Leg Curl"
                        },
                        new
                        {
                            ExerciseID = "850f15cf-73f5-469b-a370-53f37c5af815",
                            Image = "LegExtension.png",
                            Name = "Leg Extension"
                        },
                        new
                        {
                            ExerciseID = "0263b2d1-2156-42c9-b6d8-b74dfd77d15c",
                            Image = "LegPress.png",
                            Name = "Leg Press"
                        },
                        new
                        {
                            ExerciseID = "a6a7fd68-ddd4-4ec5-8669-1bc1d860f142",
                            Image = "Lunge.png",
                            Name = "Lunge"
                        },
                        new
                        {
                            ExerciseID = "1a10b635-7f7d-48f8-8210-b98ca0ba3593",
                            Image = "LiftingWeights.png",
                            Name = "Lifting Weights"
                        },
                        new
                        {
                            ExerciseID = "a859c8ee-1611-4c36-ba33-65431b9ea5be",
                            Image = "Pilates.png",
                            Name = "Pilates"
                        },
                        new
                        {
                            ExerciseID = "9f0ff33e-6300-449c-9312-ead13bfd7f54",
                            Image = "PullDown.png",
                            Name = "Pull-down"
                        },
                        new
                        {
                            ExerciseID = "ff720fa6-a4c6-4cbb-a04b-44a5f776869d",
                            Image = "PullUp.png",
                            Name = "Pull-up"
                        },
                        new
                        {
                            ExerciseID = "bf068445-0818-450d-a7f8-54b3479756d8",
                            Image = "PushUps.png",
                            Name = "Push-ups"
                        },
                        new
                        {
                            ExerciseID = "cea68f5f-f97d-4dd3-9f66-39ea0d5e2647",
                            Image = "ResistanceExercise.png",
                            Name = "Resistance Exercise with Elastic Bands or Tubes"
                        },
                        new
                        {
                            ExerciseID = "5ce15d39-13c8-44bb-8777-606dd75eb1b6",
                            Image = "Rowing.png",
                            Name = "Rowing"
                        },
                        new
                        {
                            ExerciseID = "c71c6641-4ba3-4e7e-94ce-5cd352ca9dc7",
                            Image = "SeatedCalfRaise.png",
                            Name = "Seated Calf Raise"
                        },
                        new
                        {
                            ExerciseID = "70f3bf4f-b8c3-4575-ad10-9b5abcc9f403",
                            Image = "ShoulderPress.png",
                            Name = "Shoulder Press"
                        },
                        new
                        {
                            ExerciseID = "2a859216-92b9-4c45-abe3-c1d62d3c7386",
                            Image = "ShoulderShrug.png",
                            Name = "Shoulder Shrug"
                        },
                        new
                        {
                            ExerciseID = "0b73db3e-79c5-4c39-84a2-73202e2a50d1",
                            Image = "Soccer.png",
                            Name = "Soccer"
                        },
                        new
                        {
                            ExerciseID = "dbe8ec95-55c0-458c-88b4-3f498489571f",
                            Image = "Squat.png",
                            Name = "Squat"
                        },
                        new
                        {
                            ExerciseID = "383e3184-0f0f-4f10-aa9e-617f3310c487",
                            Image = "Stairs.png",
                            Name = "Stairs"
                        },
                        new
                        {
                            ExerciseID = "d80a3240-b7cf-49ce-b9f4-5c5f28674bd0",
                            Image = "StandingCalfRaise.png",
                            Name = "Standing Calf Raise"
                        },
                        new
                        {
                            ExerciseID = "a81e3b79-b91c-47a1-be30-445f816e8acc",
                            Image = "StrengthClass.png",
                            Name = "Strength Class"
                        },
                        new
                        {
                            ExerciseID = "9bf9b6a5-cbaa-44fd-9041-fea6eaf4c00b",
                            Image = "Swimming.png",
                            Name = "Swimming"
                        },
                        new
                        {
                            ExerciseID = "fd455b61-f96f-4463-9d8d-a250644b66f2",
                            Image = "TaiChi.png",
                            Name = "Tai Chi"
                        },
                        new
                        {
                            ExerciseID = "f01f30f6-0545-4419-aa56-33deda68e4f2",
                            Image = "Tennis.png",
                            Name = "Tennis"
                        },
                        new
                        {
                            ExerciseID = "3398a21b-d450-4729-84ff-91c587e791fb",
                            Image = "TricepExtension.png",
                            Name = "Tricep Extension"
                        },
                        new
                        {
                            ExerciseID = "6d12aeff-cb64-491f-8ffb-88aeec6f28d2",
                            Image = "UltimateFrisbee.png",
                            Name = "Ultimate Frisbee"
                        },
                        new
                        {
                            ExerciseID = "55aaa08a-f24c-45ab-beeb-b205e8715cee",
                            Image = "UprightRow.png",
                            Name = "Upright Row"
                        },
                        new
                        {
                            ExerciseID = "fcc18a2a-c8a4-481f-bdf7-ff0f0c3dd572",
                            Image = "Volleyball.png",
                            Name = "Volleyball"
                        },
                        new
                        {
                            ExerciseID = "5f996ce4-7c42-4372-8cc2-6905d9f855bc",
                            Image = "WalkingWithStroller.png",
                            Name = "Walking with a Stroller"
                        },
                        new
                        {
                            ExerciseID = "d1954921-5890-450f-901a-a5d3781e2064",
                            Image = "Yoga.png",
                            Name = "Yoga"
                        },
                        new
                        {
                            ExerciseID = "784c99bc-3f3d-447f-bbc5-047073e72ede",
                            Image = "CalfStretch.png",
                            Name = "Calf Stretch"
                        },
                        new
                        {
                            ExerciseID = "07ee99cb-a437-4c5a-9c63-5ed0b8881b88",
                            Image = "HamstringStretch.png",
                            Name = "Hamstring Stretch"
                        },
                        new
                        {
                            ExerciseID = "39809ec8-a82b-4018-98eb-0262c7ff6ab5",
                            Image = "QuadricepsStretch.png",
                            Name = "Quadriceps Stretch"
                        },
                        new
                        {
                            ExerciseID = "ee02fbc6-5c17-4193-a407-acd1a16d97db",
                            Image = "HipFlexorsStretch.png",
                            Name = "Hip Flexors Stretch"
                        },
                        new
                        {
                            ExerciseID = "c9e43654-3fea-447a-9005-a9677e30ea0a",
                            Image = "KneeToChestStretch.png",
                            Name = "Knee-to-Chest Stretch"
                        },
                        new
                        {
                            ExerciseID = "ba826abd-0faa-47c2-800f-14c892c6a6cf",
                            Image = "ShoulderStretch.png",
                            Name = "Shoulder Stretch"
                        },
                        new
                        {
                            ExerciseID = "eb2cfc73-9935-428f-9bbf-3873f8899b48",
                            Image = "NeckStretch.png",
                            Name = "Neck Stretch"
                        },
                        new
                        {
                            ExerciseID = "f659ebec-9196-424b-8245-d83200ddf1c1",
                            Image = "TightropeWalk.png",
                            Name = "Tightrope Walk"
                        },
                        new
                        {
                            ExerciseID = "7d547024-da6b-428e-b75c-b3dd9010dc7a",
                            Image = "FlamingoStand.png",
                            Name = "Flamingo Stand"
                        },
                        new
                        {
                            ExerciseID = "6003b0eb-5412-4331-98ad-9f9a31f64d87",
                            Image = "HeelToToeWalk.png",
                            Name = "Heel-to-Toe Walk"
                        },
                        new
                        {
                            ExerciseID = "d6014007-0233-4688-8496-8eb8dc257207",
                            Image = "BandedTriplanarToeTaps.png",
                            Name = "Banded Triplanar Toe Taps"
                        });
                });

            modelBuilder.Entity("BetterBuiltWorkouts.Models.ExerciseType", b =>
                {
                    b.Property<string>("ExerciseTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExerciseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseTypeID");

                    b.HasIndex("ExerciseID");

                    b.ToTable("ExerciseTypes");

                    b.HasData(
                        new
                        {
                            ExerciseTypeID = "aerobic",
                            Name = "Aerobic"
                        },
                        new
                        {
                            ExerciseTypeID = "strength_training",
                            Name = "Strength Training"
                        },
                        new
                        {
                            ExerciseTypeID = "streching",
                            Name = "Stretching"
                        },
                        new
                        {
                            ExerciseTypeID = "balance",
                            Name = "Balance"
                        });
                });

            modelBuilder.Entity("BetterBuiltWorkouts.Models.ExerciseType", b =>
                {
                    b.HasOne("BetterBuiltWorkouts.Models.Exercise", null)
                        .WithMany("ExerciseTypes")
                        .HasForeignKey("ExerciseID");
                });

            modelBuilder.Entity("BetterBuiltWorkouts.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseTypes");
                });
#pragma warning restore 612, 618
        }
    }
}