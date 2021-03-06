﻿using Student_Exercises_ADONET.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Student_Exercises_ADONET.Data
{
    class Repository
    {
        ///Tunnel to connect the application to the database.
        public SqlConnection Connection
        {
            get
            {
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }
        //Exercise 1:
        //Query the database for all the Exercises
        public List<Exercise> GetAllExercises()
        {
            using (SqlConnection conn = Connection)
            {
                // Note, we must Open() the connection
                conn.Open();

                // We must "use" commands too.
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // Here we setup the command with the SQL we want to execute before we execute it.
                    cmd.CommandText = "SELECT Id, Name FROM Exercise";

                    // Execute the SQL in the database and get a "reader" that will give us access to the data.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // A list to hold the exercises we retrieve from the database.
                    List<Exercise> Exercises = new List<Exercise>();

                    // Read() will return true if there's more data to read
                    while (reader.Read())
                    {
                        // The "ordinal" is the numeric position of the column in the query results.
                        //  For our query, "Id" has an ordinal value of 0 and "DeptName" is 1.
                        int idColumnPosition = reader.GetOrdinal("Id");

                        // We user the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(idColumnPosition);

                        int NameColumnPosition = reader.GetOrdinal("Name");
                        string NameValue = reader.GetString(NameColumnPosition);

                        // Now let's create a new exercise object using the data from the database.
                        Exercise Exercise = new Exercise
                        {
                            Id = idValue,
                            Name = NameValue
                        };

                        // ...and add that exercise object to our list.
                        Exercises.Add(Exercise);
                    }

                    // We should Close() the reader
                    reader.Close();

                    // Return the list of exercises
                    return Exercises;
                }
            }
        }

        //Exercise 2: 
        //Find all the exercises in the database where the language is JavaScript.
        public List<Exercise> GetExercisesByLanguage(string language)
        {
            using (SqlConnection conn = Connection)
            {
                // Note, we must Open() the connection
                conn.Open();

                // We must "use" commands too.
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // Here we setup the command with the SQL we want to execute before we execute it.
                    cmd.CommandText = "SELECT Id, Name FROM Exercise WHERE Language = @language";
                    cmd.Parameters.Add(new SqlParameter("@language", language));

                    // Execute the SQL in the database and get a "reader" that will give us access to the data.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // A list to hold the exercises we retrieve from the database.
                    List<Exercise> Exercises = new List<Exercise>();

                    // Read() will return true if there's more data to read
                    while (reader.Read())
                    {
                        // The "ordinal" is the numeric position of the column in the query results.
                        //  For our query, "Id" has an ordinal value of 0 and "DeptName" is 1.
                        int idColumnPosition = reader.GetOrdinal("Id");

                        // We user the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(idColumnPosition);

                        int NameColumnPosition = reader.GetOrdinal("Name");
                        string NameValue = reader.GetString(NameColumnPosition);

                        // Now let's create a new exercise object using the data from the database.
                        Exercise Exercise = new Exercise
                        {
                            Id = idValue,
                            Name = NameValue
                        };

                        // ...and add that exercise object to our list.
                        Exercises.Add(Exercise);
                    }

                    // We should Close() the reader
                    reader.Close();

                    // Return the list of exercises
                    return Exercises;
                }
            }
        }

        //Exercise 3: 
        //Insert a new exercise into the database.
        public void AddExercise(Exercise exercise)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Exercise (Name, Language) OUTPUT INSERTED.Id Values (@Name, @Language)";
                    cmd.Parameters.Add(new SqlParameter("@Name", exercise.Name));
                    cmd.Parameters.Add(new SqlParameter("@Language", exercise.Language));
                    int Id = (int)cmd.ExecuteScalar();

                    exercise.Id = Id;
                }
            }
        }

        //Exercise 4:
        //Find all instructors in the database. Include each instructor's cohort.
        public List<Instructor> GetAllInstructors()
        {
            using (SqlConnection conn = Connection)
            {
                // Note, we must Open() the connection
                conn.Open();

                // We must "use" commands too.
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // Here we setup the command with the SQL we want to execute before we execute it.
                    cmd.CommandText = "SELECT i.Id,i.FirstName,i.LastName,c.Name FROM Instructor i LEFT JOIN Cohort c on i.CohortId = c.Id";

                    // Execute the SQL in the database and get a "reader" that will give us access to the data.
                    SqlDataReader reader = cmd.ExecuteReader();

                    // A list to hold the instructors we retrieve from the database.
                    List<Instructor> Instructors = new List<Instructor>();

                    // Read() will return true if there's more data to read
                    while (reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");

                        // We user the reader's GetXXX methods to get the value for a particular ordinal.
                        int idValue = reader.GetInt32(idColumnPosition);
                        int FirstNameColumnPosition = reader.GetOrdinal("FirstName");
                        string FirstNameValue = reader.GetString(FirstNameColumnPosition);
                        int LastNameColumnPosition = reader.GetOrdinal("LastName");
                        string LastNameValue = reader.GetString(LastNameColumnPosition);
                        int CohortNameColumnPosition = reader.GetOrdinal("Name");
                        string CohortNameValue = reader.GetString(CohortNameColumnPosition);

                        // New instructor object
                        Instructor  instructor = new Instructor
                        {
                            Id = idValue,
                            FirstName = FirstNameValue,
                            LastName = LastNameValue, 
                            Cohort = CohortNameValue
                        };
                        Instructors.Add(instructor);
                    }
                    reader.Close();

                    // Return the list of instructors
                    return Instructors;
                }
            }
        }
    }
}
