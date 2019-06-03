using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hot dog! Look at you go!");
            // Here we're creating our new Students from our class in Student.cs .
            Students Rose = new Students()
            {
                Id = 1,
                FirstName = "Rose",
                LastName = "Wisotzky",
                SlackHandle = "@rose"
            };
            Students Ira = new Students()
            {
                Id = 2,
                FirstName = "Ira",
                LastName = "Wiz",
                SlackHandle = "@Ira"
            };
            Students Hallie = new Students()
            {
                Id = 3,
                FirstName = "Hallie",
                LastName = "Kent",
                SlackHandle = "@Hallie"
            };
            Students Travis = new Students()
            {
                Id = 4,
                FirstName = "Travis",
                LastName = "Weitzman",
                SlackHandle = "@trav"
            };
            // Instructors
            Instructors Ro = new Instructors()
            {
                Id = 1,
                FirstName = "Ro",
                LastName = "Wizzy",
                Specialty = "Being cool"
            };
            Instructors Gina = new Instructors()
            {
                Id = 2,
                FirstName = "Gina",
                LastName = "Franks",
                Specialty = "Being TOO cool"
            };
            Instructors Garol = new Instructors()
            {
                Id = 3,
                FirstName = "Garol",
                LastName = "G",
                Specialty = "Yogurt"
            };
            // Exercises
            Exercise Lists = new Exercise()
            {
                Id = 1,
                ExerciseName = "Lists",
                Language = "C#"
            };
            Exercise Dictionaries = new Exercise()
            {
                Id = 2,
                ExerciseName = "Dictionaries",
                Language = "C#"
            };
            Exercise Objects = new Exercise()
            {
                Id = 3,
                ExerciseName = "Objects",
                Language = "C#"
            };
            Exercise Types = new Exercise()
            {
                Id = 4,
                ExerciseName = "Types",
                Language = "C#"
            };
            // Ya gotta make a new cohort buddy before u can utilize that List!!!!
            Cohort c31 = new Cohort()
            {
                Id = 1,
                Name = "Cohort 31"
            };
            Cohort c32 = new Cohort()
            {
                Id = 2,
                Name = "Cohort 32"
            };
            Cohort c33 = new Cohort()
            {
                Id = 3,
                Name = "Cohort 33"
            };


            c31.StudentList.Add(Rose);
            c31.StudentList.Add(Ira);
            c31.StudentList.Add(Hallie);
            c31.StudentList.Add(Travis);

            foreach (Students student in c31.StudentList) {
                Console.WriteLine($"{student.FirstName} is in this class.");
            }

            c31.InstructorList.Add(Ro);
            // Instructors Cohort = ;
            c31.InstructorList.Add(Gina);
            
            foreach (Instructors instructor in c31.InstructorList) {
                Console.WriteLine($"{instructor.FirstName} is teaching {instructor.Cohort}");

            }
        }
    }
}
