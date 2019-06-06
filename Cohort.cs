using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Cohort {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Students> StudentList { get; set; } = new List<Students>();
        public List<Instructors> InstructorList { get; set; } = new List<Instructors>();
        
    }
}