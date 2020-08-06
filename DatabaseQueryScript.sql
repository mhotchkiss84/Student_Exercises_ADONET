DROP TABLE StudentExercise;
DROP TABLE Student;
DROP TABLE Instructor;
DROP TABLE Exercise;
DROP TABLE Cohort;
CREATE TABLE Cohort (
Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
[Name] VARCHAR(55) NOT NULL,
);
CREATE TABLE Instructor (
Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
FirstName VARCHAR(55) NOT NULL,
LastName VARCHAR(55) NOT NULL,
SlackHandle VARCHAR(55) NOT NULL,
CohortId INTEGER NOT NULL,
Specialty VARCHAR(55),
CONSTRAINT FK_INSTRUCTOR_COHORT FOREIGN KEY (CohortId) REFERENCES Cohort(Id)
);
CREATE TABLE Student (
Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
FirstName VARCHAR(55) NOT NULL,
LastName VARCHAR(55) NOT NULL,
SlackHandle VARCHAR(55) NOT NULL,
CohortId INTEGER NOT NULL,
CONSTRAINT FK_STUDENT_COHORT FOREIGN KEY (CohortId) REFERENCES Cohort(Id)
);
CREATE TABLE Exercise (
Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
[Name] VARCHAR(55) NOT NULL,
[Language] VARCHAR(55) NOT NULL,
);
CREATE TABLE StudentExercise (
Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
StudentId INTEGER NOT NULL,
ExerciseId INTEGER NOT NULL,
CONSTRAINT FK_STUDENTEXERCISE_STUDENT FOREIGN KEY (StudentId) REFERENCES Student(Id),
CONSTRAINT FK_STUDENTEXERCISE_EXERCISE FOREIGN KEY (ExerciseId) REFERENCES Exercise(Id)
);
INSERT INTO Cohort (Name) VALUES ('Cohort 1');
INSERT INTO Cohort (Name) VALUES ('Cohort 2');
INSERT INTO Cohort (Name) VALUES ('Cohort 3');
INSERT INTO Instructor(FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Jordan', 'Castelloe', 'JDawg', 2, 'Teaching');
INSERT INTO Instructor(FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Kim', 'Preece', 'KimmyP', 1, 'CSS');
INSERT INTO Instructor(FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Jennifer', 'Johnson', 'JJforPrez', 3, 'C#.')
INSERT INTO Instructor(FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Tommy', 'Spurlock', 'Spurman', 2, 'CSS');
INSERT INTO Instructor(FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Jacob', 'Perry', 'JP_Diddy', 3,'Javascript');
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Sarah ', 'Brooks', 'SaraBoogie1', 3);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Dylan ', 'Bishop', 'ChessMoves', 3);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Barry ', 'Griffith', 'GettinGriffyWitIt', 3);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Caleb ', 'Meadows', 'MrMeadows21', 2);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Ryan ', 'Clay', 'CaptainClayMan', 2);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Nick ', 'Miller', 'DnDMill', 1);
INSERT INTO Student(FirstName, LastName, SlackHandle, CohortId) VALUES ('Dale ', 'Saul', 'SweetDale', 1);
INSERT INTO Exercise([Name], [Language]) Values ('Kennel','Javascript');
INSERT INTO Exercise([Name], [Language]) Values ('Nutshell','Javascript');
INSERT INTO Exercise([Name], [Language]) Values ('Travel Planner','C#');
INSERT INTO Exercise([Name], [Language]) Values ('Bangazon','C#');
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(1,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(1,2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(1,3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(2,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(2,4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(2,3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(3,4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(3,2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(3,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(4,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(4,4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(4,3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(5,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(5,2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(5,3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(6,3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(6,2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(6,4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(7,1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(7,2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES	(7,3);
