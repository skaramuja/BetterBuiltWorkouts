using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BetterBuiltWorkouts.Data
{
    // IdentityDbContext inherits from the normal DbContext class but add additional items needed for AA 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string adminRoleId = Guid.NewGuid().ToString("D");
            string suspendedRoleId = Guid.NewGuid().ToString("D");
            string user1Id = Guid.NewGuid().ToString("D");
            string user2Id = Guid.NewGuid().ToString("D");
            string user3Id = Guid.NewGuid().ToString("D");

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = "Suspended",
                    NormalizedName = "SUSPENDED",
                    Id = suspendedRoleId,
                    ConcurrencyStamp = suspendedRoleId
                });

            ApplicationUser user1 = new ApplicationUser
            {
                Id = user1Id,
                Email = "drewxcom@gmail.com",
                NormalizedEmail = "DREWXCOM@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Drew",
                LastName = "Crawford",
                UserName = "drewxcom",
                NormalizedUserName = "DREWXCOM"
            };

            ApplicationUser user2 = new ApplicationUser
            {
                Id = user2Id,
                Email = "hale.l.c91@gmail.com",
                NormalizedEmail = "HALE.L.C91@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Cody",
                LastName = "Hale",
                UserName = "chale",
                NormalizedUserName = "CHALE"
            };

            ApplicationUser user3 = new ApplicationUser
            {
                Id = user3Id,
                Email = "Karamuja.sabina@gmail.com",
                NormalizedEmail = "KARAMUJA.SABINA@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Sabina",
                LastName = "Johnson",
                UserName = "skaramuja",
                NormalizedUserName = "SKARAMUJA"
            };

            PasswordHasher<ApplicationUser> u1 = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = u1.HashPassword(user1, "crawford1!Drew");

            PasswordHasher<ApplicationUser> u2 = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = u2.HashPassword(user2, "hale1!Cody");

            PasswordHasher<ApplicationUser> u3 = new PasswordHasher<ApplicationUser>();
            user3.PasswordHash = u1.HashPassword(user3, "karamuja1!Sabina");

            builder.Entity<ApplicationUser>().HasData(user1);
            builder.Entity<ApplicationUser>().HasData(user2);
            builder.Entity<ApplicationUser>().HasData(user3);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user1Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user2Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user3Id
                }
                );

            builder.Entity<ExerciseType>().HasData(
              new ExerciseType { ExerciseTypeID = "aerobic", Name = "Aerobic" },
              new ExerciseType { ExerciseTypeID = "strength_training", Name = "Strength Training" },
              new ExerciseType { ExerciseTypeID = "streching", Name = "Stretching" },
              new ExerciseType { ExerciseTypeID = "balance", Name = "Balance" },
              new ExerciseType { ExerciseTypeID = "other", Name = "Other" }

          );
            builder.Entity<Exercise>().HasData(
                new
                {
                    ExerciseId = 1,
                    Name = "Back Extension",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "BackExtension.png"
                },
                new
                {
                    ExerciseId = 2,
                    Name = "Basketball",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Basketball.png"
                },
                new
                {
                    ExerciseId = 3,
                    Name = "Bench Press",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "BenchPress.png"
                },
                new
                {
                    ExerciseId = 4,
                    Name = "Bicep Curl",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "BicepCurl.png"
                },
                new
                {
                    ExerciseId = 5,
                    Name = "Biking",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Biking.png"
                },
                new
                {
                    ExerciseId = 6,
                    Name = "Brisk Walking",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "BriskWalking.png"
                },
                new
                {
                    ExerciseId = 7,
                    Name = "Cardio Class",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "CardioClass.png"
                },
                new
                {
                    ExerciseId = 8,
                    Name = "Cardio Machine",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "CardioMachine.png"
                },
                new
                {
                    ExerciseId = 9,
                    Name = "Chest Fly",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "ChestFly.png"
                },
                new
                {
                    ExerciseId = 10,
                    Name = "Crunches",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "Crunches.png"
                },
                new
                {
                    ExerciseId = 11,
                    Name = "Dancing",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Dancing.png"
                },
                new
                {
                    ExerciseId = 12,
                    Name = "Deadlift",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "Deadlift.png"
                },
                new
                {
                    ExerciseId = 13,
                    Name = "Gardening and Weeding",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "GardeningAndWeeding.png"
                },
                new
                {
                    ExerciseId = 14,
                    Name = "Golf",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Golf.png"
                },
                new
                {
                    ExerciseId = 15,
                    Name = "High-Intensity Interval Training",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "HighIntensityIntervalTraining.png"
                },
                new
                {
                    ExerciseId = 16,
                    Name = "Hiking",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Hiking.png"
                },
                new
                {
                    ExerciseId = 17,
                    Name = "Jogging or Running",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "JoggingOrRunning.png"
                },
                new
                {
                    ExerciseId = 18,
                    Name = "Lateral Raise",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "LateralRaise.png"
                },
                new
                {
                    ExerciseId = 19,
                    Name = "Leg Curl",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "LegCurl.png"
                },
                new
                {
                    ExerciseId = 20,
                    Name = "Leg Extension",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "LegExtension.png"
                },
                new
                {
                    ExerciseId = 21,
                    Name = "Leg Press",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "LegPress.png"
                },
                new
                {
                    ExerciseId = 22,
                    Name = "Lunge",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "Lunge.png"
                },
                new
                {
                    ExerciseId = 23,
                    Name = "Lifting Weights",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "LiftingWeights.png"
                },
                new
                {
                    ExerciseId = 24,
                    Name = "Pilates",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "Pilates.png"
                },
                new
                {
                    ExerciseId = 25,
                    Name = "Pull-down",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "PullDown.png"
                },
                new
                {
                    ExerciseId = 26,
                    Name = "Pull-up",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "PullUp.png"
                },
                new
                {
                    ExerciseId = 27,
                    Name = "Push-ups",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "PushUps.png"
                },
                new
                {
                    ExerciseId = 28,
                    Name = "Resistance Exercise with Elastic Bands or Tubes",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "ResistanceExercise.png"
                },
                new
                {
                    ExerciseId = 29,
                    Name = "Rowing",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Rowing.png"
                },
                new
                {
                    ExerciseId = 30,
                    Name = "Seated Calf Raise",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "SeatedCalfRaise.png"
                },
                new
                {
                    ExerciseId = 31,
                    Name = "Shoulder Press",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "ShoulderPress.png"
                },
                new
                {
                    ExerciseId = 32,
                    Name = "Shoulder Shrug",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "ShoulderShrug.png"
                },
                new
                {
                    ExerciseId = 33,
                    Name = "Soccer",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Soccer.png"
                },
                new
                {
                    ExerciseId = 34,
                    Name = "Squat",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "Squat.png"
                },
                new
                {
                    ExerciseId = 35,
                    Name = "Stairs",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Stairs.png"
                },
                new
                {
                    ExerciseId = 36,
                    Name = "Standing Calf Raise",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "StandingCalfRaise.png"
                },
                new
                {
                    ExerciseId = 37,
                    Name = "Strength Class",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "StrengthClass.png"
                },
                new
                {
                    ExerciseId = 38,
                    Name = "Swimming",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Swimming.png"
                },
                new
                {
                    ExerciseId = 39,
                    Name = "Tai Chi",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "TaiChi.png"
                },
                new
                {
                    ExerciseId = 40,
                    Name = "Tennis",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Tennis.png"
                },
                new
                {
                    ExerciseId = 41,
                    Name = "Tricep Extension",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "TricepExtension.png"
                },
                new
                {
                    ExerciseId = 42,
                    Name = "Ultimate Frisbee",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "UltimateFrisbee.png"
                },
                new
                {
                    ExerciseId = 43,
                    Name = "Upright Row",
                    ExerciseTypeID = "strength_training",
                    IsPublic = true,
                    Image = "UprightRow.png"
                },
                new
                {
                    ExerciseId = 44,
                    Name = "Volleyball",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Volleyball.png"
                },
                new
                {
                    ExerciseId = 45,
                    Name = "Walking with a Stroller",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "WalkingWithStroller.png"
                },
                new
                {
                    ExerciseId = 46,
                    Name = "Yoga",
                    ExerciseTypeID = "aerobic",
                    IsPublic = true,
                    Image = "Yoga.png"
                },
                new
                {
                    ExerciseId = 47,
                    Name = "Calf Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "CalfStretch.png"
                },
                new
                {
                    ExerciseId = 48,
                    Name = "Hamstring Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "HamstringStretch.png"
                },
                new
                {
                    ExerciseId = 49,
                    Name = "Quadriceps Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "QuadricepsStretch.png"
                },
                new
                {
                    ExerciseId = 50,
                    Name = "Hip Flexors Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "HipFlexorsStretch.png"
                },
                new
                {
                    ExerciseId = 51,
                    Name = "Knee-to-Chest Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "KneeToChestStretch.png"
                },
                new
                {
                    ExerciseId = 52,
                    Name = "Shoulder Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "ShoulderStretch.png"
                },
                new
                {
                    ExerciseId = 53,
                    Name = "Neck Stretch",
                    ExerciseTypeID = "streching",
                    IsPublic = true,
                    Image = "NeckStretch.png"
                },
                new
                {
                    ExerciseId = 54,
                    Name = "Tightrope Walk",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "TightropeWalk.png"
                },
                new
                {
                    ExerciseId = 55,
                    Name = "Flamingo Stand",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "FlamingoStand.png"
                },
                new
                {
                    ExerciseId = 56,
                    Name = "Heel-to-Toe Walk",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "HeelToToeWalk.png"
                },
                new
                {
                    ExerciseId = 57,
                    Name = "Banded Triplanar Toe Taps",
                    ExerciseTypeID = "balance",
                    IsPublic = true,
                    Image = "BandedTriplanarToeTaps.png"
                }
            );

        }
    }
}
