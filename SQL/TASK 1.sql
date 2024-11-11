USE Task1DB

CREATE TABLE Regions(
Region_Id int identity primary key,
Region_Name nvarchar(25)
)

CREATE TABLE Countries(
Country_Id char(2) primary key,
Country_Name nvarchar(40),
Region_Id int,
FOREIGN KEY (Region_Id) REFERENCES Regions(Region_Id)
)



CREATE TABLE Locations(
Location_Id int identity primary key,
Street_adress nvarchar(25),
Postal_code nvarchar(12),
City nvarchar(30),
State_province nvarchar(12),
Country_Id char(2),
FOREIGN KEY (Country_Id) REFERENCES Countries(Country_Id)
)



CREATE TABLE Departments(
Department_Id int identity primary key,
Department_Name nvarchar(30),
Manager_Id int,
Location_Id int,
FOREIGN KEY (Location_Id) REFERENCES Locations(Location_Id)
)


CREATE TABLE Jobs(
Job_id nvarchar(10) primary key,
Job_title nvarchar(35),
Min_salary int,
Max_salary int
)



CREATE TABLE Job_History(
Id int identity primary key,
Start_Date date,
End_Date date,
Job_Id nvarchar(10),
FOREIGN KEY (Job_Id) REFERENCES Jobs(Job_id),
Department_Id int,
FOREIGN KEY (Department_Id) REFERENCES Departments(Department_Id)
)

CREATE TABLE Employees(
Employee_Id int,
FOREIGN KEY (Employee_Id) REFERENCES Job_History(Id),
First_name nvarchar(20),
Last_name nvarchar(25),
Email nvarchar(25),
Phone_number nvarchar(20),
Hire_date date,
Job_id nvarchar(10),
FOREIGN KEY (Job_id) REFERENCES Jobs(Job_id),
Salary int,
Commision_pct int,
Manager_Id int,
Department_Id int,
FOREIGN KEY (Department_Id) REFERENCES Departments (Department_Id)
)




CREATE TABLE Job_Grades(
Grade_lvel nvarchar(2) primary key,
Lowest_sal int,
Highest_sal int
)


