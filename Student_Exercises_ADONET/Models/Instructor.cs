using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Exercises_ADONET.Models
{
    class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int CohortId { get; set; }
        //TODO: Ask about this
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        //Add Method for assigning an exercise
    }
}
