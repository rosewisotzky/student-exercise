using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Instructors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        public List<Exercise> StudentExercises {get; set; } = new List<Exercise>();
        public void AssignExercise(Students student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            exercise.Students.Add(student);
        }
    }
}