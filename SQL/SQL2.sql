--1.How many products can you find in the Production.Product table?

select count(distinct p.Name)
from Production.Product p

--2.  Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
select count(ps.Name)
from Production.Product p inner join Production.ProductSubcategory ps
on p.ProductSubcategoryID = ps.ProductSubcategoryID

--3. How many Products reside in each SubCategory? 
--Write a query to display the results with the following titles.
--ProductSubcategoryID CountedProducts
select p.ProductSubcategoryID, count(ProductSubcategoryID) as CountedProducts
from Production.Product p
group by p.ProductSubcategoryID


--4.How many products that do not have a product subcategory.
select count(*)
from Production.Product p where p.ProductSubcategoryID is null; 

--5.Write a query to list the sum of products quantity in the Production.ProductInventory table.
select p.ProductID, sum(p.Quantity)
from Production.ProductInventory p
group by p.ProductID


--select *
--from Production.ProductInventory p where p.LocationID = 40

--6.Write a query to list the sum of products in the Production.ProductInventory table 
--and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

 --             ProductID    TheSum

  --            -----------        ----------

select p.ProductID, sum(p.Quantity) as TheSum
from Production.ProductInventory p 
where p.LocationID in (40) 
group by p.ProductID
having sum(p.Quantity) < 100


--7.Write a query to list the sum of products with the shelf information in the Production.ProductInventory 
--table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

--    Shelf      ProductID    TheSum

 --   ----------   -----------        -----------

select p.Shelf, p.ProductID, sum(p.Quantity) as TheSum
from Production.ProductInventory p 
where p.LocationID in (40) 
group by p.ProductID, p.Shelf
having sum(p.Quantity) < 100


--8.Write the query to list the average quantity for products where column LocationID 
--has the value of 10 from the table Production.ProductInventory table.
select p.ProductID, avg(p.Quantity)
from Production.ProductInventory p
where p.LocationID in (10)
group by p.ProductID

--9.Write query  to see the average quantity  of  products by shelf  from the 
--table Production.ProductInventory

  --  ProductID   Shelf      TheAvg

    ----------- ---------- -----------
select p.ProductID, p.Shelf, avg(p.Quantity) as TheAvg 
from Production.ProductInventory p
group by p.ProductID, p.Shelf

--10.Write query  to see the average quantity  of  products by shelf excluding rows 
--that has the value of N/A in the column Shelf from the table Production.ProductInventory

 --   ProductID   Shelf      TheAvg

    ----------- ---------- -----------

select p.ProductID, p.Shelf, avg(p.Quantity) as TheAvg 
from Production.ProductInventory p
group by p.ProductID, p.Shelf
having p.Shelf not in ('N/A')

--11.List the members (rows) and average list price in the Production.Product table. 
--This should be grouped independently over the Color and the Class column. 
--Exclude the rows where Color or Class are null.

 --   Color                        Class              TheCount          AvgPrice

    -------------- - -----    -----------            ---------------------
select p.Color, null as Class, count(*) as TheCount, avg(p.ListPrice) as AvgPrice
from Production.Product p 
where p.Color is not null and p.Class is not null
group by p.Color
union
select null as Color, p.Class, count(*) as TheCount, avg(p.ListPrice) as AvgPrice
from Production.Product p 
where p.Color is not null and p.Class is not null
group by p.Class

--12.Write a query that lists the country and province names from person. CountryRegion 
--and person. StateProvince tables. Join them and produce a result set similar to the following.

 --   Country                        Province

    ---------                          ----------------------

select pc.Name as Country, ps.Name as Province
from Person.CountryRegion pc inner join Person.StateProvince ps
on pc.CountryRegionCode = ps.CountryRegionCode

--13.Write a query that lists the country and province names from person. CountryRegion 
--and person. StateProvince tables and list the countries filter them by 
--Germany and Canada. Join them and produce a result set similar to the following.

--    Country                        Province

    ---------                          ----------------------
select pc.Name as Country, ps.Name as Province
from Person.CountryRegion pc inner join Person.StateProvince ps
on pc.CountryRegionCode = ps.CountryRegionCode
where pc.Name in ('Germany', 'Canada')

--14.List all Products that has been sold at least once in last 27 years.
select distinct p.ProductName
from dbo.Orders o join [dbo].[Order Details] od 
on o.OrderID = od.OrderID
join dbo.Products p on od.ProductID = p.ProductID
where o.OrderDate >= dateadd(year, -27, getdate())

--15.List top 5 locations (Zip Code) where the products sold most.
select top 5 o.ShipPostalCode
from dbo.Orders o 
group by o.ShipPostalCode
order by count(o.ShipPostalCode) desc

--16.List top 5 locations (Zip Code) where the products sold most in last 27 years.
select top 5 o.ShipPostalCode
from dbo.Orders o 
where o.OrderDate >= dateadd(year, -27, getdate())
group by o.ShipPostalCode
order by count(o.ShipPostalCode) desc

--17.List all city names and number of customers in that city.
select c.City, count(c.CustomerID) as [Customer Count]
from dbo.Customers c 
group by c.City

--18. List city names which have more than 2 customers, and number of customers in that city
select c.City, count(c.CustomerID) as [Customer Count]
from dbo.Customers c 
group by c.City
having count(c.CustomerID) > 2

--19. List the names of customers who placed orders after 1/1/98 with order date.
select distinct c.ContactName, o.OrderDate
from dbo.Customers c join dbo.Orders o 
on o.CustomerID = c.CustomerID
where o.OrderDate > '1998-01-01'

--20. List the names of all customers with most recent order dates
select dt.ContactName, dt.OrderDate
from
(select c.ContactName, o.OrderDate, row_number() over(partition by c.CustomerID order by o.OrderDate desc) RNK
from dbo.Customers c  join dbo.Orders o
on c.CustomerID = o.CustomerID) dt
where dt.RNK = 1

--21. Display the names of all customers  along with the  count of products they bought
select c.ContactName, count(od.ProductID) as [Product Count] 
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID
join [dbo].[Order Details] od
on od.OrderID = o.OrderID
group by c.ContactName

--22. Display the customer ids who bought more than 100 Products with count of products.
select c.CustomerID, count(od.ProductID) as [Product Count] 
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID
join [dbo].[Order Details] od
on od.OrderID = o.OrderID
group by c.CustomerID
having count(od.ProductID) > 100

--23. List all of the possible ways that suppliers can ship their products. 
--Display the results as below

  --  Supplier Company Name                Shipping Company Name

    ---------------------------------            ----------------------------------

select su.CompanyName as [Supplier Company Name], sh.CompanyName as [Shipping Company Name]
from dbo.Suppliers su cross join  dbo.Shippers sh 

--24. Display the products order each day. Show Order date and Product Name.
select p.ProductName, o.OrderDate 
from dbo.Orders o join [dbo].[Order Details] od 
on o.OrderID = od.OrderID
join dbo.Products p
on p.ProductID = od.ProductID
order by o.OrderDate desc

--25. Displays pairs of employees who have the same job title.
select e1.FirstName + ' ' + e1.LastName as [Emp Name1] , e2.FirstName + ' ' + e2.LastName as [Emp Name2]
from dbo.Employees e1 join dbo.Employees e2
on e1.Title = e2.Title and e1.EmployeeID < e2.EmployeeID

--26. Display all the Managers who have more than 2 employees reporting to them.
select e.FirstName + ' ' + e.LastName as 'Name' 
from dbo.Employees e 
where e.EmployeeID in 
(select e1.ReportsTo from dbo.Employees e1 
group by e1.ReportsTo
having count(e1.ReportsTo) > 2)

--27. Display the customers and suppliers by city. The results should have the following columns
--City
--Name
--Contact Name,
--Type (Customer or Supplier)

select c.City, c.CompanyName as [Name], c.ContactName, 'Customer' as Type 
from dbo.Customers c 
union
select s.City, s.CompanyName as [Name], s.ContactName, 'Supplier' as Type 
from dbo.Suppliers s

