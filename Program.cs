using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercise
{
    public class StudentReport
    {
        public string StudentName { get; set; }
        public string ExerciseName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hot dog! Look at you go!");
            Console.WriteLine(" ");
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
                Language = "JavaScript"
            };
            Exercise Types = new Exercise()
            {
                Id = 4,
                ExerciseName = "Types",
                Language = "C#"
            };
            // Ya gotta make a new cohort buddy before u can utilize that List method!!!!
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

            Rose.Cohort = c31;
            Ira.Cohort = c31;
            Hallie.Cohort = c31;
            Travis.Cohort = c31;

            foreach (Students student in c31.StudentList)
            {
                Console.WriteLine($"{student.FirstName} is in this class.");
            }

            Console.WriteLine(" ");

            // We are adding the instructor object named Ro to the cohort c31. Since both of these entities are joined, we also must add c31 to the object Ro's cohort property. This allows us to access the name of that cohort when we're writing it in our console.

            c31.InstructorList.Add(Ro);
            Ro.Cohort = c31;
            c31.InstructorList.Add(Gina);
            Gina.Cohort = c31;

            foreach (Instructors instructor in c31.InstructorList)
            {
                Console.WriteLine($"{instructor.FirstName} is teaching {instructor.Cohort.Name}");
            }
            // Have each instructor assign 2 exercises to each of the students.
            Gina.AssignExercise(Rose, Dictionaries);
            Gina.AssignExercise(Rose, Lists);
            Ro.AssignExercise(Rose, Objects);
            Ro.AssignExercise(Rose, Types);
            Gina.AssignExercise(Ira, Dictionaries);
            Gina.AssignExercise(Ira, Lists);
            Ro.AssignExercise(Ira, Objects);
            Ro.AssignExercise(Ira, Types);
            Gina.AssignExercise(Travis, Dictionaries);
            Gina.AssignExercise(Travis, Lists);
            Ro.AssignExercise(Travis, Objects);
            Ro.AssignExercise(Travis, Types);
            Gina.AssignExercise(Hallie, Dictionaries);
            Gina.AssignExercise(Hallie, Lists);
            Ro.AssignExercise(Hallie, Objects);
            Ro.AssignExercise(Hallie, Types);

            List<Students> students = new List<Students>() {
                Rose,
                Ira,
                Travis,
                Hallie
            };
            List<Instructors> instructors = new List<Instructors>() {
                Ro,
                Gina
            };
            List<Cohort> cohort = new List<Cohort>() {
                c31,
                c32,
                c33
            };
            List<Exercise> exercises = new List<Exercise>() {
                Dictionaries,
                Lists,
                Types,
                Objects
            };

            List<Exercise> JavaScriptExercise = exercises.Where(e => e.Language == "JavaScript").ToList();
            foreach (Exercise exercise in JavaScriptExercise)
            {
                Console.WriteLine($"{exercise.ExerciseName} is written in {exercise.Language}");
                // List students in a particular cohort by using the Where() LINQ method.
                
            }
             IEnumerable<Students>StudentsIn31 = students.Where(s => s.Cohort == c31).ToList();
                Console.WriteLine("These students are in Cohort 31");
                foreach (var student in StudentsIn31)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} ");
                }
        }



    }
}

