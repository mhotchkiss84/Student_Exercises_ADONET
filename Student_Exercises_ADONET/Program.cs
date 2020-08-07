using Student_Exercises_ADONET.Data;
using Student_Exercises_ADONET.Models;
using System;
using System.Collections.Generic;

namespace Student_Exercises_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1:
            //Query the database for all the Exercises

            //Creating new instance of Repository
            Repository Repo = new Repository();

            
            Console.WriteLine("Getting All Exercises:");
            Console.WriteLine();
            
            //Creating a new list to store the exercises
            List<Exercise> allExercises = Repo.GetAllExercises();

            //Using a loop to go through the list and print the exercise Id and the exercise name
            foreach (Exercise exer in allExercises)
            {
                Console.WriteLine($"{exer.Id} {exer.Name}");
            }

            // Exercise 2: 
            //Find all the exercises in the database where the language is JavaScript.
            Console.WriteLine("Getting exercises by language: javascript");
            Console.WriteLine();

            //Creating a list to store the exercises
            List<Exercise> ExerciseByLanguage = Repo.GetExercisesByLanguage("Javascript");

            foreach (Exercise exer in ExerciseByLanguage)
            {
                Console.WriteLine($"{exer.Id} {exer.Name}");
            }

            //Exercise 3: 
            //Insert a new exercise into the database.

            //Exercise NewExercise = new Exercise
            //{
            //    Name = "ADONET",
            //    Language = "C#"
            //};

            //Repo.AddExercise(NewExercise);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Added the new exercise!");

            //Exercise 4:
            //Find all instructors in the database. Include each instructor's cohort.
            Console.WriteLine("Getting All Instructors:");
            Console.WriteLine();

            //Creating a new list to store the instructors
            List<Instructor> allInstructors = Repo.GetAllInstructors();

            //Using a loop to go through the list and print the instructor Id and the name their Cohort
            foreach (Instructor instr in allInstructors)
            {
                Console.WriteLine($"{instr.Id} {instr.FirstName} {instr.LastName} {instr.Cohort}");
            }

        }
    }
}
