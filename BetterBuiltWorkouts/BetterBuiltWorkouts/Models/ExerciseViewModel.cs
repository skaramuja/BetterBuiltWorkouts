namespace BetterBuiltWorkouts.Models
{
    public class ExerciseViewModel
    {
        public Exercise Exercise { get; set; }
        public ExerciseType ActiveExerciseType { get; set; } = new ExerciseType { ExerciseTypeID = "all", Name = "all" };
        public string selectedExerciseType { get; set; } = "all";
    }
}
