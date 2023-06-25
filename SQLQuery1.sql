CREATE TABLE Persons (
    PersonID int primary key,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);
CREATE TABLE Orders (
    orderid int,
    PersonID int references Persons(Personid),
    EventDate Date,
    sumDresses int,
    ArrivalHour date
);

