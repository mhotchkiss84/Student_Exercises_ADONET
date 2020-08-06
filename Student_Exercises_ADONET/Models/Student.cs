using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Exercises_ADONET.Models
{
    class Student
    {
        //TODO ??
        //public Student(string firstNameParam)
        //{
        //    FirstName = firstNameParam;
        //}

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public double Grade { get; set; }
        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }

        //Creating a List of Assigned Exercises for the student using the Exercise Model
        public List<Exercise> AssignedExercises { get; set; } = new List<Exercise>();
    }
}
