using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Exercises_ADONET.Models
{
    class Exercise
    {
        //TODO: This is the same as StudentExercises
        //Need to delete

        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }

        public List<Student> assignedStudnets { get; set; } = new List<Student>();
    }
}
