using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class FixNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcersiseType_Exercise_ExerciseID",
                table: "ExcersiseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcersiseType",
                table: "ExcersiseType");

            migrationBuilder.RenameTable(
                name: "Exercise",
                newName: "Exercises");

            migrationBuilder.RenameTable(
                name: "ExcersiseType",
                newName: "ExerciseTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ExcersiseType_ExerciseID",
                table: "ExerciseTypes",
                newName: "IX_ExerciseTypes_ExerciseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises",
                column: "ExerciseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseTypes",
                table: "ExerciseTypes",
                column: "ExerciseTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTypes_Exercises_ExerciseID",
                table: "ExerciseTypes",
                column: "ExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTypes_Exercises_ExerciseID",
                table: "ExerciseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseTypes",
                table: "ExerciseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises");

            migrationBuilder.RenameTable(
                name: "ExerciseTypes",
                newName: "ExcersiseType");

            migrationBuilder.RenameTable(
                name: "Exercises",
                newName: "Exercise");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseTypes_ExerciseID",
                table: "ExcersiseType",
                newName: "IX_ExcersiseType_ExerciseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcersiseType",
                table: "ExcersiseType",
                column: "ExerciseTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise",
                column: "ExerciseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcersiseType_Exercise_ExerciseID",
                table: "ExcersiseType",
                column: "ExerciseID",
                principalTable: "Exercise",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
