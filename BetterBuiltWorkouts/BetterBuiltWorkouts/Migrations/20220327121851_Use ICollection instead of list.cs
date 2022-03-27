using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class UseICollectioninsteadoflist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTypes_Exercises_ExerciseID",
                table: "ExerciseTypes");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseTypes_ExerciseID",
                table: "ExerciseTypes");

            migrationBuilder.DropColumn(
                name: "ExerciseID",
                table: "ExerciseTypes");

            migrationBuilder.CreateTable(
                name: "ExerciseExerciseType",
                columns: table => new
                {
                    ExerciseTypesExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExercisesExerciseID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseExerciseType", x => new { x.ExerciseTypesExerciseTypeID, x.ExercisesExerciseID });
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseType_Exercises_ExercisesExerciseID",
                        column: x => x.ExercisesExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseType_ExerciseTypes_ExerciseTypesExerciseTypeID",
                        column: x => x.ExerciseTypesExerciseTypeID,
                        principalTable: "ExerciseTypes",
                        principalColumn: "ExerciseTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExerciseType_ExercisesExerciseID",
                table: "ExerciseExerciseType",
                column: "ExercisesExerciseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseExerciseType");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseID",
                table: "ExerciseTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTypes_ExerciseID",
                table: "ExerciseTypes",
                column: "ExerciseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTypes_Exercises_ExerciseID",
                table: "ExerciseTypes",
                column: "ExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
