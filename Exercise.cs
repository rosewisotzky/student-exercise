using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Exercise
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string Language { get; set; }
        public List<Students> Students {get; set; } = new List<Students>();
    }
}