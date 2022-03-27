using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class DataUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseExerciseType_Exercises_ExercisesExerciseID",
                table: "ExerciseExerciseType");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseExerciseType_ExerciseTypes_ExerciseTypesExerciseTypeID",
                table: "ExerciseExerciseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseExerciseType",
                table: "ExerciseExerciseType");

            migrationBuilder.RenameTable(
                name: "ExerciseExerciseType",
                newName: "ExerciseExerciseTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseExerciseType_ExercisesExerciseID",
                table: "ExerciseExerciseTypes",
                newName: "IX_ExerciseExerciseTypes_ExercisesExerciseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseExerciseTypes",
                table: "ExerciseExerciseTypes",
                columns: new[] { "ExerciseTypesExerciseTypeID", "ExercisesExerciseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseExerciseTypes_Exercises_ExercisesExerciseID",
                table: "ExerciseExerciseTypes",
                column: "ExercisesExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseExerciseTypes_ExerciseTypes_ExerciseTypesExerciseTypeID",
                table: "ExerciseExerciseTypes",
                column: "ExerciseTypesExerciseTypeID",
                principalTable: "ExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseExerciseTypes_Exercises_ExercisesExerciseID",
                table: "ExerciseExerciseTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseExerciseTypes_ExerciseTypes_ExerciseTypesExerciseTypeID",
                table: "ExerciseExerciseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseExerciseTypes",
                table: "ExerciseExerciseTypes");

            migrationBuilder.RenameTable(
                name: "ExerciseExerciseTypes",
                newName: "ExerciseExerciseType");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseExerciseTypes_ExercisesExerciseID",
                table: "ExerciseExerciseType",
                newName: "IX_ExerciseExerciseType_ExercisesExerciseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseExerciseType",
                table: "ExerciseExerciseType",
                columns: new[] { "ExerciseTypesExerciseTypeID", "ExercisesExerciseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseExerciseType_Exercises_ExercisesExerciseID",
                table: "ExerciseExerciseType",
                column: "ExercisesExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseExerciseType_ExerciseTypes_ExerciseTypesExerciseTypeID",
                table: "ExerciseExerciseType",
                column: "ExerciseTypesExerciseTypeID",
                principalTable: "ExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
