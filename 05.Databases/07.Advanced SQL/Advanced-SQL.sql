USE TelerikAcademy
GO

--1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.
SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees)

--2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName, LastName, Salary
FROM Employees e
WHERE e.Salary <= (SELECT MIN(Salary) FROM Employees) * 1.1

--3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--Use a nested SELECT statement.
SELECT e.FirstName, e.LastName AS [Full Name], d.Name AS [Department Name], e.Salary AS [Min Department Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees em WHERE em.DepartmentID = d.DepartmentID)

--4.Write a SQL query to find the average salary in the department #1.
SELECT AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
WHERE d.DepartmentID = 1

--5.Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'

--6.Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*)
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'

--7.Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*)
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--8.Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*)
FROM Employees e
WHERE e.ManagerID IS NULL

--9.Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name AS [Department Name], AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

--10.Write a SQL query to find the count of all employees in each department and for each town.
SELECT d.Name AS [Department Name], t.Name AS [Town Name], COUNT(*) AS [Employees Count]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
JOIN Addresses a
ON a.AddressID = e.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name, d.Name

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT a.FirstName, a.LastName
FROM Employees e
JOIN Employees a
ON e.ManagerID = a.ManagerID
GROUP BY a.FirstName,a.LastName
HAVING COUNT(*) = 5

--12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name], ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager Full Name]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.ManagerID

--13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name]
FROM Employees e 
WHERE LEN(e.LastName) = 5

--14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
SELECT GETDATE() AS [CurrentDateTime]

--15.Search in Google to find how to format dates in SQL Server.
--This will result in format of date DD/MM/YYYY
SELECT Convert(varchar(10),CONVERT(date,GETDATE(),106),103)

--16.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
CREATE TABLE Users(
	UserId int IDENTITY(1,1) PRIMARY KEY,
	Username nvarchar(30),
	Password nvarchar(30),
	FullName nvarchar(50),
	LastLogin datetime 
);

--17.Define unique constraint to avoid repeating usernames.
ALTER TABLE Users
 ADD UNIQUE (Username)

--18.Define a check constraint to ensure the password is at least 5 characters long.
ALTER TABLE Users
ADD CHECK (LEN(Username) > 0)

--19.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
INSERT INTO Users(Username, Password, FullName, LastLogin)
VALUES('Evlogi', '8765463764', 'Viktor Ivanov', GETDATE()),
	  ('Doncho', '8765463764', 'Evlogi Ivanov', GETDATE()),
	  ('Viktor', '8765463764', 'Doncho Ivanov', GETDATE())
GO

CREATE VIEW [UsersLoggedToday] AS
SELECT *
FROM Users
WHERE CONVERT(NVARCHAR(20),LastLogin,104) = CONVERT(NVARCHAR(20),GETDATE(),104)
GO

--20.Test if the view works correctly.
SELECT * 
FROM UsersLoggedToday

--21.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
--Define primary key and identity column.
CREATE TABLE Groups
(
	GroupId int identity(1,1) PRIMARY KEY,
	Name nvarchar(30) NOT NULL UNIQUE
);

--21.Write a SQL statement to add a column GroupID to the table Users.
ALTER TABLE Users
ADD GroupId int 

--22.Fill some data in this new column and as well in the `Groups table.
INSERT INTO Users(GroupId)
VALUES (2)

--23.Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users
ADD FOREIGN KEY (GroupId)
REFERENCES Groups(GroupId)

--24.Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users(Username, Password, FullName, LastLogin)
VALUES('Evasdlogi', '8765463764', 'Viktor Ivanov', GETDATE()),
	  ('asdasd', '8765463764', 'Evlogi Ivanov', GETDATE()),
	  ('Viktdasdasor', '8765463764', 'Doncho Ivanov', GETDATE())
GO

INSERT INTO Groups(Name)
VALUES('Group of trainers'),
	  ('Group of programmers'),
	  ('Group of testers'),
	  ('Not a group')
GO

--25.Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET GroupId = 1
WHERE Username = 'Doncho'
GO

UPDATE Users
SET GroupId = 1
WHERE Username = 'Viktor'
GO

UPDATE Users
SET GroupId = 3
WHERE UserId BETWEEN 4 AND 8
GO

--26.Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Username IS NULL
OR Username = 'Viktdasdasor'
GO

DELETE FROM Groups
WHERE Name = 'Not a group'
GO

--27.Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.
INSERT INTO Users(Username, Password, FullName)
SELECT 
	SUBSTRING (e.FirstName, 1, 1) + LOWER(e.LastName) +  ISNULL(e.MiddleName, '2'), 
	--I add 2 here for the glory of satan
	SUBSTRING (e.FirstName, 1, 1) + LOWER(e.LastName),
	e.FirstName + ' ' + e.LastName
FROM dbo.Employees e

--28.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET Password = NULL
WHERE LastLogin <= '10.03.2010'

--29.Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE Password IS NULL

--30.Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name AS Department, e.JobTitle AS [Job]
, MIN(e.Salary) AS [Minimal Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID=d.DepartmentID
GROUP BY d.Name, e.JobTitle

--31.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT d.Name AS Department, e.JobTitle AS [Job]
, MIN(e.FirstName+e.LastName) AS Name
, MIN(e.Salary) AS [Minimal Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID=d.DepartmentID
GROUP BY d.Name, e.JobTitle

--32.Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name, COUNT(*) as [Employees Count]
FROM Employees e
JOIN Addresses a
ON e.AddressID=a.AddressID
JOIN Towns t
ON a.TownID=t.TownID
GROUP BY t.Name
ORDER BY [Employees Count] DESC

--33.Write a SQL query to display the number of managers from each town.
SELECT TOP 1 t.Name, COUNT(*) as [Employees Count]
FROM Employees e
JOIN Addresses a
ON e.AddressID=a.AddressID
JOIN Towns t
ON a.TownID=t.TownID
GROUP BY t.Name
ORDER BY [Employees Count] DESC
