--04. find all information about all departments
SELECT *
	FROM Departments

--05. find all department names
SELECT Name
	FROM Departments

--06. find the salary of each employee
SELECT FirstName,
	   LastName,
	   Salary
	FROM Employees

--07. find the full name of each employee
SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Employees

--08. find the email addresses of each employee
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses]
	FROM Employees

--09. find all different employee salaries
SELECT DISTINCT SALARY
	FROM Employees

--10. find all information about the employees whose job title is “Sales Representative“
SELECT *
	FROM Employees
	WHERE JobTitle = 'Sales Representative'

--11. find the names of all employees whose first name starts with "SA"
SELECT FirstName,
	   LastName
	FROM Employees
	WHERE FirstName LIKE 'SA%'

--12. find the names of all employees whose last name contains "ei"
SELECT FirstName,
	   LastName
	FROM Employees
	WHERE LastName LIKE '%ei%'

--13. find the salary of all employees whose salary is in the range [20000…30000]
SELECT FirstName + ' ' + LastName AS [Full Name],
	   Salary
	FROM Employees
	WHERE Salary BETWEEN  20000 AND 30000

--14. find the names of all employees whose salary is 25000, 14000, 12500 or 23600
SELECT FirstName + ' ' + LastName AS [Full Name],
	   Salary
	FROM Employees
	WHERE Salary IN (25000, 14000, 12500, 23600)

--15. find all employees that do not have manager
SELECT FirstName,
	   LastName,
	   JobTitle
	FROM Employees
	WHERE ManagerID IS NULL

--16. find all employees that have salary more than 50000. Order them in decreasing order by salary
SELECT FirstName + ' ' + LastName AS [Full Name],
	   JobTitle,
	   Salary
	FROM Employees
	WHERE Salary > 50000
	ORDER BY Salary DESC

--17. find the top 5 best paid employees
SELECT TOP 5 FirstName + ' ' + LastName AS [Full Name],
	   JobTitle,
	   Salary
	FROM Employees
	ORDER BY Salary DESC

--18. find all employees along with their address. Use inner join with ON clause.
SELECT FirstName + ' ' + LastName AS [Full Name],
	   a.AddressText AS [Address],
	   t.Name AS City
	FROM Employees AS e
	JOIN Addresses AS a
	ON e.AddressID = a.AddressID
	JOIN Towns AS t
	ON a.TownID = t.TownID

--19. find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT DISTINCT FirstName + ' ' + LastName AS [Full Name],
	   a.AddressText AS [Address]
	FROM Employees AS e,
	Addresses AS a
	WHERE e.AddressID = a.AddressID

--20. find all employees along with their manager
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   empM.FirstName + ' ' + empM.LastName AS [Employee Manager]
	FROM Employees AS e
	JOIN Employees AS empM
	ON e.ManagerID = empM.EmployeeID

--21. find all employees, along with their manager and their address
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
	   a.AddressText AS [Employee Address],
	   empM.FirstName + ' ' + empM.LastName AS [Employee Manager]
	FROM Employees AS e
	JOIN Addresses AS a
	ON e.AddressID = a.AddressID
	JOIN Employees AS empM
	ON e.ManagerID = empM.EmployeeID

--22. find all departments and all town names as a single list
SELECT Name FROM Departments
UNION
SELECT Name FROM Towns

--23. find all the employees and the manager for each of them along with the employees that do not have manager
--All of the following queries must be valid depends on the understanding of the task description
 SELECT e.FirstName + ' ' + e.LastName AS Employee,   
        m.FirstName + ' ' + m.LastName AS Manager   
    FROM Employees e   
        RIGHT OUTER JOIN Employees m   
            ON e.ManagerID = m.EmployeeID   

 SELECT e.FirstName + ' ' + e.LastName AS Employee,   
        m.FirstName + ' ' + m.LastName AS Manager   
    FROM Employees e   
        LEFT OUTER JOIN Employees m   
            ON e.ManagerID = m.EmployeeID   

SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
	   ISNULL(m.FirstName + ' ' + m.LastName, 'Chief Officer') AS [Manager Name]
	FROM Employees e
	LEFT JOIN Employees m 
	ON e.ManagerID = m.EmployeeID

--24. find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005
SELECT FirstName + ' ' + LastName AS [Full Name],
	   d.Name,
	   HireDate AS [Hire Date]
	FROM Employees AS e
	JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
	WHERE HireDate BETWEEN '01/01/1995' AND '01/01/2005' AND d.Name IN ('Sales', 'Finance')