using Microsoft.EntityFrameworkCore.Migrations;

namespace BetterBuiltWorkouts.Migrations
{
    public partial class Singletypeperexercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseExerciseTypes");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseTypeID",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "0263b2d1-2156-42c9-b6d8-b74dfd77d15c",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "07ee99cb-a437-4c5a-9c63-5ed0b8881b88",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "09225d37-099c-4d92-b92f-573238275e60",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "0b73db3e-79c5-4c39-84a2-73202e2a50d1",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "0fbdd46c-2c1c-4714-8862-1027a1507d48",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "1a10b635-7f7d-48f8-8210-b98ca0ba3593",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "21feedca-86d0-4e15-8c03-8b1cff77d111",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "263da85f-11cb-40b8-a46c-4d44e0de4b61",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "2a859216-92b9-4c45-abe3-c1d62d3c7386",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "2c4892b6-bd35-4721-9ee0-7390aca29aa4",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "3398a21b-d450-4729-84ff-91c587e791fb",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "36a710ed-e131-4109-a9ea-68b5103ded88",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "383e3184-0f0f-4f10-aa9e-617f3310c487",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "39809ec8-a82b-4018-98eb-0262c7ff6ab5",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "4b24d8d2-17cc-48f9-bbfb-9806558382bd",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "50c8dd43-1e2c-4d69-bba8-26b7449e04cd",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "55aaa08a-f24c-45ab-beeb-b205e8715cee",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "593fe2ab-25b9-411e-bcd3-509278f4ca75",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "5bd3fb30-c732-4a13-8c50-11436d9699cb",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "5ce15d39-13c8-44bb-8777-606dd75eb1b6",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "5f996ce4-7c42-4372-8cc2-6905d9f855bc",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "6003b0eb-5412-4331-98ad-9f9a31f64d87",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "6492c5d9-e870-4272-b671-d9dcd2d5e753",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "6d12aeff-cb64-491f-8ffb-88aeec6f28d2",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "70f3bf4f-b8c3-4575-ad10-9b5abcc9f403",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "784c99bc-3f3d-447f-bbc5-047073e72ede",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "7bb1fc0d-d4b7-49c1-a194-1071a505447d",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "7d547024-da6b-428e-b75c-b3dd9010dc7a",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "850f15cf-73f5-469b-a370-53f37c5af815",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "97ec7f49-4e07-45a0-8dbf-d0a378fe2ff5",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "9bf9b6a5-cbaa-44fd-9041-fea6eaf4c00b",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "9f0ff33e-6300-449c-9312-ead13bfd7f54",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "a2602232-9e81-4426-9534-1fa28ed46f03",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "a6a7fd68-ddd4-4ec5-8669-1bc1d860f142",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "a81e3b79-b91c-47a1-be30-445f816e8acc",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "a859c8ee-1611-4c36-ba33-65431b9ea5be",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "ba826abd-0faa-47c2-800f-14c892c6a6cf",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "bf068445-0818-450d-a7f8-54b3479756d8",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "c37dbdbc-4c80-4eba-812b-2532d079f51d",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "c71c6641-4ba3-4e7e-94ce-5cd352ca9dc7",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "c9e43654-3fea-447a-9005-a9677e30ea0a",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "cea68f5f-f97d-4dd3-9f66-39ea0d5e2647",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "d1954921-5890-450f-901a-a5d3781e2064",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "d3a5d568-cc64-4ac2-a8cf-89ba7e6ac313",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "d6014007-0233-4688-8496-8eb8dc257207",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "d80a3240-b7cf-49ce-b9f4-5c5f28674bd0",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "dbe8ec95-55c0-458c-88b4-3f498489571f",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "ddf87e95-6025-4575-b6e0-3be747a21f7a",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "eb2cfc73-9935-428f-9bbf-3873f8899b48",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "ee02fbc6-5c17-4193-a407-acd1a16d97db",
                column: "ExerciseTypeID",
                value: "streching");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "f01f30f6-0545-4419-aa56-33deda68e4f2",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "f659ebec-9196-424b-8245-d83200ddf1c1",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "fba7c5db-62b0-498c-ae50-d71cdc8bc03d",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "fcc18a2a-c8a4-481f-bdf7-ff0f0c3dd572",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "fcf92528-8837-4ec8-a3fe-fc69131122cc",
                column: "ExerciseTypeID",
                value: "aerobic");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "fd455b61-f96f-4463-9d8d-a250644b66f2",
                column: "ExerciseTypeID",
                value: "balance");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseID",
                keyValue: "ff720fa6-a4c6-4cbb-a04b-44a5f776869d",
                column: "ExerciseTypeID",
                value: "strength_training");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises",
                column: "ExerciseTypeID",
                principalTable: "ExerciseTypes",
                principalColumn: "ExerciseTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseTypes_ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseTypeID",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "ExerciseExerciseTypes",
                columns: table => new
                {
                    ExerciseTypesExerciseTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExercisesExerciseID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseExerciseTypes", x => new { x.ExerciseTypesExerciseTypeID, x.ExercisesExerciseID });
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseTypes_Exercises_ExercisesExerciseID",
                        column: x => x.ExercisesExerciseID,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExerciseTypes_ExerciseTypes_ExerciseTypesExerciseTypeID",
                        column: x => x.ExerciseTypesExerciseTypeID,
                        principalTable: "ExerciseTypes",
                        principalColumn: "ExerciseTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExerciseExerciseTypes",
                columns: new[] { "ExerciseTypesExerciseTypeID", "ExercisesExerciseID" },
                values: new object[] { "balance", "d6014007-0233-4688-8496-8eb8dc257207" });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExerciseTypes_ExercisesExerciseID",
                table: "ExerciseExerciseTypes",
                column: "ExercisesExerciseID");
        }
    }
}
