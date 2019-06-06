using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}