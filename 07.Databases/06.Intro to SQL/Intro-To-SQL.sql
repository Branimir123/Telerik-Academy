USE TelerikAcademy
GO

--01.Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT * FROM Departments

--02.Write a SQL query to find all department names.
SELECT Name FROM Departments

--03.Write a SQL query to find the salary of each employee.
SELECT Salary FROM Employees

--04.Write a SQL to find the full name of each employee.
SELECT FirstName,LastName FROM Employees

--05.Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like �John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
SELECT FirstName +  '.' + LastName + '@telerik.com' 
AS [Full Email Address]
FROM Employees

--06.Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary
FROM Employees

--07.Write a SQL query to find all information about the employees whose job title is �Sales Representative�.
SELECT * 
FROM Employees
WHERE JobTitle = 'Sales Representative'

--08.Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT FirstName,LastName
FROM Employees
WHERE FirstName LIKE 'SA%' 

--09.Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT FirstName,LastName
FROM Employees
WHERE LastName LIKE '%ei%'

--10.Write a SQL query to find the salary of all employees whose salary is in the range [20000�30000].
SELECT Salary
FROM Employees
WHERE Salary 
BETWEEN 20000
AND 30000

--11.Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT FirstName, LastName
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

--12.Write a SQL query to find all employees that do not have manager.
SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL

--13.Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--14.Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 * 
FROM Employees
ORDER BY Salary DESC

--15.Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT * 
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

--16.Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT *
FROM Employees, Addresses
WHERE Employees.AddressID = Addresses.AddressID

--17.Write a SQL query to find all employees along with their manager.
SELECT *
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID 

--18.Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT * 
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Employees m
ON e.ManagerID = m.EmployeeID 

--19.Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT Name
FROM Departments
UNION
SELECT Name
FROM Towns

--20.Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT *
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID;

--21.Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT * 
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN('Sales', 'Finance')
AND e.HireDate BETWEEN '1995-01-01 00:00:00' AND '2005-01-01 00:00:00'