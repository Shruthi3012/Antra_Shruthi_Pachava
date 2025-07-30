
--1.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product as p

--2.Write a query that retrieves the columns ProductID, Name, 
--Color and ListPrice from the Production.Product table, excludes the rows that ListPrice is 0.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p where p.ListPrice <> 0

--3.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, 
--the rows that are NULL for the Color column
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p where p.Color is null

--4.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, 
--the rows that are not NULL for the Color column.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p where p.Color is not null

--5.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, 
--the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
select p.ProductID, p.Name, p.Color, p.ListPrice
from Production.Product p where p.Color is not null and p.ListPrice > 0

--6.Write a query that concatenates the columns Name and Color from the Production.Product table 
--by excluding the rows that are null for color.
select p.Name + ' ' + p.Color
from Production.Product p where p.Color is not null

--7.Write a query that generates the following result set  from Production.Product:
--NAME: LL Crankarm  --  COLOR: Black
--NAME: ML Crankarm  --  COLOR: Black
--NAME: HL Crankarm  --  COLOR: Black
--NAME: Chainring Bolts  --  COLOR: Silver
--NAME: Chainring Nut  --  COLOR: Silver
--NAME: Chainring  --  COLOR: Black
select 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color
from Production.Product p where p.Name like '%Crankarm' or p.Name like 'Chainring%' 
order by p.SafetyStockLevel, p.ProductNumber 

--select * from Production.Product p where p.Name like '%Crankarm' or p.Name like 'Chainring%' 

--8.Write a query to retrieve the to the columns ProductID and Name from the Production.Product table 
--filtered by ProductID from 400 to 500
select p.ProductID, p.Name
from Production.Product p where p.ProductID between 400 and 500

--9.Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table
--restricted to the colors black and blue
select p.ProductID, p.Name, p.Color
from Production.Product p where p.Color in ('black', 'blue')

--10.Write a query to get a result set on products that begins with the letter S. 
select * from Production.Product p where p.Name like 'S%'

--11.Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. Order the result set by the Name column. 
--Name                                               ListPrice
--Seat Lug                                              0,00
--Seat Post                                             0,00
--Seat Stays                                            0,00
--Seat Tube                                            0,00
--Short-Sleeve Classic Jersey, L           53,99
--Short-Sleeve Classic Jersey, M          53,99

select p.Name, p.ListPrice
from Production.Product p where p.Name like 'Seat%' or p.Name like 'S%, L' or p.Name like 'S%, M'
order by p.Name

--12. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. 
--Order the result set by the Name column. The products name should start with either 'A' or 'S'
--Name                                               ListPrice
--Adjustable Race                                   0,00
--All-Purpose Bike Stand                       159,00
--AWC Logo Cap                                      8,99
--Seat Lug                                                 0,00
--Seat Post                                                0,00
select p.Name, p.ListPrice
from Production.Product p where p.Name like 'A%' or p.Name like 'S%'
order by p.Name

--13.Write a query so you retrieve rows that have a Name that begins with the letters SPO, 
--but is then not followed by the letter K. After this zero or more letters can exists. 
--Order the result set by the Name column.
select *
from Production.Product p where p.Name like 'SPO[^K]%'
order by p.Name

--14.Write a query that retrieves unique colors from the table Production.Product. 
--Order the results  in descending  manner.
select distinct p.Color
from Production.Product p
order by p.Color desc

