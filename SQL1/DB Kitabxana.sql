CREATE DATABASE KitabxanaDB
USE KitabxanaDB

CREATE TABLE Authors (
Id int identity primary key,
Name nvarchar(40) not null,
Surname nvarchar(70) not null
)
INSERT INTO Authors (Name , Surname)
Values ('George' , 'Orwell'),
('Mark', 'Twain'),
('Rovsen', 'Abdullaoglu')

SELECT * FROM Authors
---Delete from Authors

CREATE TABLE Books (
BookId int identity primary key,
AuthorId int foreign key references Authors(Id),
Name nvarchar(100) not null check(LEN(Name) >= 2),
PageCount int check (PageCount >= 10)
)

INSERT INTO Books (AuthorId ,Name, PageCount)
Values (7,'1984' , 328),
(8, 'The Adventures of Tom Sawyer', 274),
(9, 'Reelsler uzerinde uzanmis adam', 380)

SELECT * FROM Books
---Delete from Books

CREATE VIEW BooksAuthors_view
AS
SELECT Books.BookId as BI, Books.Name as BN, Books.PageCount as BPC,
Authors.Name + ' ' + Authors.Surname as AuthorFullName
FROM Books
JOIN Authors
ON Books.AuthorId = Authors.Id

SELECT * FROM BooksAuthors_view
---drop view  BooksAuthors_view


CREATE PROCEDURE GetBooksAuthor 
@SearchTeam nvarchar(200)
AS
BEGIN
SELECT Books.BookId as Id,
Books.Name as Bookname,
Books.PageCount as PageCount,
Authors.Name + ' ' + Authors.Surname as AuthorFullName
FROm Books
JOIN Authors on Books.AuthorId = Authors.Id
WHERE Books.Name LIKE @SearchTeam 
OR Authors.Name LIKE   @SearchTeam 
END

--- DROP procedure GetBooksAuthor 
EXEC GetBooksAuthor 'George'
EXEC GetBooksAuthor 'Mark'
EXEC GetBooksAuthor  'Reelsler uzerinde uzanmis adam'

CREATE FUNCTION CountBooksPage(
@MinPageCount int = 10
)
RETURNS int AS
BEGIN
DECLARE @BookCount int
SELECT @BookCount  = COUNT(*)
FROM Books
WHERE PageCount > @MinPageCount
RETURN @BookCount
END

SELECT dbo.CountBooksPage(100)