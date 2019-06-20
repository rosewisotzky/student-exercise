DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Exercises;
DROP TABLE IF EXISTS Instructors;
DROP TABLE IF EXISTS Cohort;

CREATE TABLE Cohort(
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL,
)
CREATE TABLE Students (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    SlackHandle VARCHAR(50) NOT NULL,
    CohortId INT NOT NULL
    CONSTRAINT FK_StudentsCohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
)
CREATE TABLE Exercises(
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    ExerciseName VARCHAR(50) NOT NULL,
    [Language] VARCHAR(50) NOT NULL,
)
CREATE TABLE Instructors(
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    SlackHandle VARCHAR(50) NOT NULL,
    Specialty VARCHAR(50),
    CohortId INT NOT NULL
    CONSTRAINT FK_InstructorsCohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
)
CREATE TABLE StudentExercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    StudentId INT NOT NULL,
    ExerciseId INT NOT NULL
)
INSERT INTO Cohort ([Name]) VALUES (N'Cohort 31');
INSERT INTO Cohort ([Name]) VALUES (N'Cohort 32');
INSERT INTO Cohort ([Name]) VALUES (N'Cohort 33');


INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Rose', 'Wisotzky', '@rose', 1);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Jameka', 'Echols', '@jameka', 1);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Hank', 'Williams', '@hank', 2);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Townes', 'Van Zandt', '@TVZ', 2);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Dolly', 'Parton', '@dollywood', 2);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Patsy', 'Cline', '@CoalMinersDaughter', 2);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Glent', 'Cucumber', '@glent', 3);
INSERT INTO Students (FirstName, LastName, SlackHandle, CohortId) VALUES ('Varnald', 'Van Fig', '@varnvanf', 3);


SELECT * FROM Students;

INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Shellfish', 'Warden', '@SALTLIFE', 1, 'Shucking oysters');
INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Reginald', 'Jackfruit', '@zesty', 1, 'Seasoning');
INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Blardus', 'Canteloupe', '@blardus', 2, 'Chess');
INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortId, Specialty) VALUES ('Kremple', 'Tangerine', '@spicelife', 3, ' ');

SELECT * FROM Instructors;

INSERT INTO Exercises (ExerciseName, [Language]) VALUES ('Kandy Korner', 'React');
INSERT INTO Exercises (ExerciseName, [Language]) VALUES ('Gary Garage', 'C#');
INSERT INTO Exercises (ExerciseName, [Language]) VALUES ('Student Exercises', 'C#');
INSERT INTO Exercises (ExerciseName, [Language]) VALUES ('National Parks and Monuments', 'JavaScript');
INSERT INTO Exercises (ExerciseName, [Language]) VALUES ('Kennel', 'React');

SELECT * FROM Exercises;

INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (1, 3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (1, 1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (1, 2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (2, 4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (2, 5);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (2, 2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (3, 4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (3, 1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (3, 5);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (4, 4);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (4, 2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (4, 3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (5, 5);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (5, 1);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (5, 2);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (6, 5);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (6, 3);
INSERT INTO StudentExercise (StudentId, ExerciseId) VALUES (6, 2);

SELECT 
        s.Id,
        e.Id,
        s.FirstName,
        s.LastName,
        s.CohortId,
        c.[Name],
        e.ExerciseName,
        e.[Language]
FROM  StudentExercise se
LEFT JOIN Exercises e ON se.ExerciseId = e.Id
RIGHT JOIN Students s ON se.StudentId = s.Id
LEFT JOIN Cohort c ON s.CohortId = c.Id








