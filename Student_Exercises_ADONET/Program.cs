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
            
            //Creating a new list to store
            List<Exercise> allExercises = Repo.GetAllExercises();

            //Using a loop to go through the list and print the exercise Id and the exercise name   
            foreach (Exercise exer in allExercises)
            {
                Console.WriteLine($"{exer.Id} {exer.Name}");
            }
        }
    }
}
