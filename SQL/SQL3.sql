--1.List all cities that have both Employees and Customers.
select distinct c.City
from dbo.Customers c join dbo.Employees e
on c.City = e.City 

--select distinct c.City from dbo.Customers c

--select distinct e.City from dbo.Employees e

--2.List all cities that have Customers but no Employee.
--a.      Use sub-query

select distinct c.City
from dbo.Customers c 
where c.City not in (
select distinct e.City
 from dbo.Employees e)

--b.      Do not use sub-query
select distinct c.City
from dbo.Customers c left join dbo.Employees e
on c.City = e.City
where e.City is null

--3.List all products and their total order quantities throughout all orders.
select p.ProductName, sum(od.Quantity) as Quantity
from dbo.Products p join [dbo].[Order Details] od
on p.ProductID = od.ProductID
group by p.ProductName

--4.List all Customer Cities and total products ordered by that city.
select c.City, sum(od.Quantity)
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID join [dbo].[Order Details] od
on od.OrderID = o.OrderID
group by c.City

--5.List all Customer Cities that have at least two customers.
select c.City
from dbo.Customers c
group by c.City
having count(c.CustomerID) >= 2

--6.List all Customer Cities that have ordered at least two different kinds of products.
select c.City
from dbo.Customers c join dbo.Orders o
on o.CustomerID = c.CustomerID join [dbo].[Order Details] od 
on o.OrderID = od.OrderID
group by c.City
having count(distinct od.ProductID) >= 2

--7. List all Customers who have ordered products, 
--but have the ‘ship city’ on the order different from their own customer cities.
select distinct c.ContactName
from dbo.Customers c join dbo.Orders o
on o.CustomerID = c.CustomerID
where c.City <>  o.ShipCity

--8.List 5 most popular products, 
--their average price, and the customer city that ordered most quantity of it.
select dt.ProductName, dt.AvgPrice,
(select top 1 c.City
from [dbo].[Order Details] od1 join dbo.Orders o1
on od1.OrderID = o1.OrderID join dbo.Customers c 
on c.CustomerID = o1.CustomerID
where od1.ProductID = dt.ProductID
group by c.City
order by sum(od1.Quantity) desc) as City
from (select top 5 p.ProductID, p.ProductName, avg(od.UnitPrice) as AvgPrice
from [dbo].[Order Details] od join dbo.Products p
on p.ProductID = od.ProductID
group by p.ProductID, p.ProductName
order by sum(od.Quantity) desc) dt



--9.List all cities that have never ordered something but we have employees there.
--a.      Use sub-query
select e.City
from dbo.Employees e 
where e.City not in (select distinct o.ShipCity
from dbo.Orders o)

--b.      Do not use sub-query
select e.City
from dbo.Employees e left join dbo.Orders o
on e.City = o.ShipCity
where o.ShipCity is null

--10.List one city, if exists, that is the city from where the employee sold most orders 
--(not the product quantity) is, and 
--also the city of most total quantity of products ordered from. (tip: join  sub-query)

select dt.City
from
(select top 1 e.City
from dbo.Employees e join dbo.Orders o 
on e.EmployeeID = o.EmployeeID
group by e.City
order by count(o.OrderID) desc) dt 
where dt.City = 
(select top 1 o.ShipCity
from dbo.Orders o join [dbo].[Order Details] od
on o.OrderID = od.OrderID
group by o.ShipCity
order by sum(od.Quantity) desc)

--11.How do you remove the duplicates record of a table?
--partition by all the fields and use row_number to assign the num and
--then delete the records that has row_number > 1 