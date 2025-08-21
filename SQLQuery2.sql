CREATE TABLE Scores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Score INT NOT NULL,
    Time DATETIME NOT NULL
);
select * from Scores