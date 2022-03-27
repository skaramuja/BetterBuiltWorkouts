using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class DataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ExerciseExerciseType",
                columns: new[] { "ExerciseTypesExerciseTypeID", "ExercisesExerciseID" },
                values: new object[] { "balance", "d6014007-0233-4688-8496-8eb8dc257207" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseExerciseType",
                keyColumns: new[] { "ExerciseTypesExerciseTypeID", "ExercisesExerciseID" },
                keyValues: new object[] { "balance", "d6014007-0233-4688-8496-8eb8dc257207" });

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
