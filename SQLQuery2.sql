CREATE TABLE notes (
    NoteId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME NOT NULL,
    ReminderDate DATETIME NULL
);
INSERT INTO notes (Title, Category, CreatedDate, ReminderDate)
VALUES
('Meeting with client', 'Work', GETDATE(), DATEADD(DAY, 1, GETDATE())),
('Buy groceries', 'Personal', GETDATE(), NULL),
('Dentist Appointment', 'Health', GETDATE(), DATEADD(DAY, 3, GETDATE())),
('Read C# Book', 'Learning', GETDATE(), NULL);