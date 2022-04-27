using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BetterBuiltWorkouts.Data
{
    // IdentityDbContext inherits from the normal DbContext class but adds additional items needed for AA 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }

        public DbSet<Workout> Workouts { get; set; }

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
            user1.PasswordHash = u1.HashPassword(user1, "Drew");

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
                });

            builder.Entity<Plan>().HasData(
                new Plan { PlanId = 1, Image = "LiftingPlan.png", Name = "Sample Strength Plan", CreatedBy = "Better Built Systems" },
                new Plan { PlanId = 2, Image = "CardioPlan.png", Name = "Sample Cardio Plan", CreatedBy = "Better Built Systems" },
                new Plan { PlanId = 3, Image = "StretchingPlan.png", Name = "Sample Streching Plan", CreatedBy = "Better Built Systems" }
                );

            builder.Entity<Exercise>()
                .HasOne<Plan>(p => p.Plan)
                .WithMany(e => e.Exercises)
                .HasForeignKey(p => p.PlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Exercise>().HasData(
                new
                {
                    ExerciseId = 1,
                    Name = "Back Extension",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "BackExtension.png"
                },
                new
                {
                    ExerciseId = 2,
                    Name = "Banded Triplanar Toe Taps",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "BandedTriplanarToeTaps.png"
                },
                new
                {
                    ExerciseId = 3,
                    Name = "Basketball",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Basketball.png"
                },
                new
                {
                    ExerciseId = 4,
                    Name = "Bench Press",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "BenchPress.png",
                    PlanId = 1
                },
                new
                {
                    ExerciseId = 5,
                    Name = "Bicep Curl",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "BicepCurl.png",
                    PlanId = 1
                },
                new
                {
                    ExerciseId = 6,
                    Name = "Biking",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Biking.png",
                    PlanId = 2
                },
                new
                {
                    ExerciseId = 7,
                    Name = "Brisk Walking",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "BriskWalking.png"
                },
                new
                {
                    ExerciseId = 8,
                    Name = "Calf Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "CalfStretch.png",
                    PlanId = 3
                },
                new
                {
                    ExerciseId = 9,
                    Name = "Cardio Class",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "CardioClass.png"
                },
                new
                {
                    ExerciseId = 10,
                    Name = "Cardio Machine",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "CardioMachine.png"
                },
                new
                {
                    ExerciseId = 11,
                    Name = "Chest Fly",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "ChestFly.png",
                    
                },
                new
                {
                    ExerciseId = 12,
                    Name = "Crunches",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "Crunches.png"
                },
                new
                {
                    ExerciseId = 13,
                    Name = "Dancing",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Dancing.png"
                },
                new
                {
                    ExerciseId = 14,
                    Name = "Deadlift",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "Deadlift.png"
                },
                new
                {
                    ExerciseId = 15,
                    Name = "Flamingo Stand",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "FlamingoStand.png"
                },
                new
                {
                    ExerciseId = 16,
                    Name = "Gardening",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "GardeningAndWeeding.png"
                },
                new
                {
                    ExerciseId = 17,
                    Name = "Golf",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Golf.png"
                },
                new
                {
                    ExerciseId = 18,
                    Name = "Hamstring Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "HamstringStretch.png",
                    PlanId = 3
                },
                new
                {
                    ExerciseId = 19,
                    Name = "Heel-to-Toe Walk",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "HeelToToeWalk.png"
                },
                new
                {
                    ExerciseId = 20,
                    Name = "HIIT",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "HighIntensityIntervalTraining.png"
                },
                new
                {
                    ExerciseId = 21,
                    Name = "Hiking",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Hiking.png"
                },
                new
                {
                    ExerciseId = 22,
                    Name = "Hip Flexors Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "HipFlexorsStretch.png"
                },
                new
                {
                    ExerciseId = 23,
                    Name = "Jogging or Running",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "JoggingOrRunning.png",
                    PlanId = 2
                },
                new
                {
                    ExerciseId = 24,
                    Name = "Knee-to-Chest Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "KneeToChestStretch.png"
                },
                new
                {
                    ExerciseId = 25,
                    Name = "Lateral Raise",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "LateralRaise.png",
                    PlanId = 1
                },
                new
                {
                    ExerciseId = 26,
                    Name = "Leg Curl",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "LegCurl.png"
                },
                new
                {
                    ExerciseId = 27,
                    Name = "Leg Extension",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "LegExtension.png"
                },
                new
                {
                    ExerciseId = 28,
                    Name = "Leg Press",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "LegPress.png"
                },
                new
                {
                    ExerciseId = 29,
                    Name = "Lunge",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "Lunge.png"
                },
                new
                {
                    ExerciseId = 30,
                    Name = "Lifting Weights",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "LiftingWeights.png"
                },
                new
                {
                    ExerciseId = 31,
                    Name = "Neck Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "NeckStretch.png",
                    PlanId = 3
                },
                new
                {
                    ExerciseId = 32,
                    Name = "Pilates",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "Pilates.png"
                },
                new
                {
                    ExerciseId = 33,
                    Name = "Pull-down",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "PullDown.png"
                },
                new
                {
                    ExerciseId = 34,
                    Name = "Pull-up",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "PullUp.png"
                },
                new
                {
                    ExerciseId = 35,
                    Name = "Push-ups",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "PushUps.png"
                },
                new
                {
                    ExerciseId = 36,
                    Name = "Quadriceps Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "QuadricepsStretch.png"
                },
                new
                {
                    ExerciseId = 37,
                    Name = "Elastic Bands or Tubes",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "ResistanceExercise.png"
                },
                new
                {
                    ExerciseId = 38,
                    Name = "Rowing",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Rowing.png"
                },
                new
                {
                    ExerciseId = 39,
                    Name = "Seated Calf Raise",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "SeatedCalfRaise.png"
                },
                new
                {
                    ExerciseId = 40,
                    Name = "Shoulder Press",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "ShoulderPress.png"
                },
                new
                {
                    ExerciseId = 41,
                    Name = "Shoulder Shrug",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "ShoulderShrug.png"
                },
                new
                {
                    ExerciseId = 42,
                    Name = "Shoulder Stretch",
                    ExerciseTypeID = "streching",
                    CreatedBy = "Better Built Systems",
                    Image = "ShoulderStretch.png"
                },
                new
                {
                    ExerciseId = 43,
                    Name = "Soccer",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Soccer.png"
                },
                new
                {
                    ExerciseId = 44,
                    Name = "Squat",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "Squat.png"
                },
                new
                {
                    ExerciseId = 45,
                    Name = "Stairs",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Stairs.png"
                },
                new
                {
                    ExerciseId = 46,
                    Name = "Standing Calf Raise",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "StandingCalfRaise.png"
                },
                new
                {
                    ExerciseId = 47,
                    Name = "Strength Class",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "StrengthClass.png"
                },
                new
                {
                    ExerciseId = 48,
                    Name = "Swimming",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Swimming.png",
                    PlanId = 2
                },
                new
                {
                    ExerciseId = 49,
                    Name = "Tai Chi",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "TaiChi.png"
                },
                new
                {
                    ExerciseId = 50,
                    Name = "Tennis",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Tennis.png"
                },
                new
                {
                    ExerciseId = 51,
                    Name = "Tightrope Walk",
                    ExerciseTypeID = "balance",
                    CreatedBy = "Better Built Systems",
                    Image = "TightropeWalk.png"
                },
                new
                {
                    ExerciseId = 52,
                    Name = "Tricep Extension",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "TricepExtension.png"
                },
                new
                {
                    ExerciseId = 53,
                    Name = "Ultimate Frisbee",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "UltimateFrisbee.png"
                },
                new
                {
                    ExerciseId = 54,
                    Name = "Upright Row",
                    ExerciseTypeID = "strength_training",
                    CreatedBy = "Better Built Systems",
                    Image = "UprightRow.png"
                },
                new
                {
                    ExerciseId = 55,
                    Name = "Volleyball",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Volleyball.png"
                },
                new
                {
                    ExerciseId = 56,
                    Name = "Walking with a Stroller",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "WalkingWithStroller.png"
                },
                new
                {
                    ExerciseId = 57,
                    Name = "Yoga",
                    ExerciseTypeID = "aerobic",
                    CreatedBy = "Better Built Systems",
                    Image = "Yoga.png"
                });

                  builder.Entity<ExerciseType>().HasData(
                      new ExerciseType { ExerciseTypeID = "aerobic", Name = "Aerobic" },
                      new ExerciseType { ExerciseTypeID = "strength_training", Name = "Strength Training" },
                      new ExerciseType { ExerciseTypeID = "streching", Name = "Stretching" },
                      new ExerciseType { ExerciseTypeID = "balance", Name = "Balance" },
                      new ExerciseType { ExerciseTypeID = "other", Name = "Other" }
                );


        }
    }
}
