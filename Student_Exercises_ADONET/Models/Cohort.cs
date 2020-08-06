using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Exercises_ADONET.Models
{
    class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Creating a list of Students in the Cohort using the Student Class
        public List<Student> Students { get; set; } = new List<Student>();
        //Creating a list of Instructors in the Cohort using the Instructor class
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
