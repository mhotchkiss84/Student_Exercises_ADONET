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

            // Exercise 2: Find all the exercises in the database where the language is JavaScript.
            Console.WriteLine("Getting exercises by language: javascript");
            Console.WriteLine();

            //Creating a list to store the exercises
            List<Exercise> ExerciseByLanguage = Repo.GetExercisesByLanguage("Javascript");

            foreach (Exercise exer in ExerciseByLanguage)
            {
                Console.WriteLine($"{exer.Id} {exer.Name}");
            }
        }
    }
}
