use adventureworks2019;
go 

--select prints what executed like a console.WriteLine

select 1 + 1;
--select 'fred' + 1;
select 'Angelica ' + 'Jardine';

select * --star means all columns not all records/select clause is said to be an horizontal filter or a filter on columns
from SalesLT.Customer; -- from gives us all record

select firstname,lastname
from SalesLT.Customer;

select CustomerID, firstname, lastname
from SalesLT.Customer
where FirstName = 'john';
--null has two values 1. not given 2. not available
select CustomerID, firstname, lastname,middlename
from SalesLT.Customer
where (FirstName = 'john' or Firstname = 'james')and middlename is not null;

select CustomerID,firstname, lastname
from SalesLT.Customer
where Firstname = 'john' and lastname != 'beaver'; -- WE CAN also use <> to say lastname is less than or greater than beaver

select CustomerID, firstname,lastname
from SalesLT.Customer
where firstname > 'a' and firstname < 'b';


select CustomerID,firstname,lastname
from SalesLT.Customer
where firstname like 'a%';

select CustomerID, firstname,lastname
from SalesLT.Customer
where lastname like '%a'; --like reads the value and basically is pattern matching if I put the percentage before its going to find the character


select CustomerID,firstname,lastname,middlename
from SalesLT.Customer
where (firstname contains 'ber' or lastname contains 'ber' or middename contains 'ber');


-- second to last character is an e
--the underscore means starts with 0 or 1 
select CustomerID, firstname,lastname,middlename
from SalesLT.Customer
where lastname like '%e_';

select firstname + '' + isnull(middlename, '') + ''+ lastname -- says if middle name is null give the second value which in this case is empty 

from SalesLT.Customer;


select firstname + '' + coalesce(middlename,null,middlename, 'Minion') + '' + lastname -- is null and coalesce do the same thing, isnull is strictly for SQL server, Coalesce is for any 
from SalesLT.Customer;

select count(*), firstname,lastname --count is an algigator function / if i was to remoce firstname and lastname it would give me the count of all the johns. Since I am asking here for a count per last name
-- I have to group the first and last name.
from SalesLT.Customer
where firstname = 'john'
group by firstname,lastname;


--any name ending with R, Average , minimum, and max



select avg(CustomerID),min (CustomerID),max(CustomerID)
from SalesLT.Customer
where firstname like '%r'
--group by customerid;

select count(*)as Number,firstname,lastname
from SalesLT.Customer
where lastname like '[km]%' -- where is for physical records 
group by firstname,lastname
having count(*) = 1 -- having is on physical groups
order by firstname desc, lastname asc;
--Why less than 2? because you cant have a 0


--method of execution
--from
--where
--group by 
--having 
--select
--order by 

--All the states in the address table where the city contains T , minimum and maximum in order


select count(*) City,StateProvince
From SalesLT.Address
where city like '%t%' 



--all customers where their first name is someones last name
select CustomerId,firstname, lastname
From SalesLT.Customer;


select count (*),slc.firstname,sla.city,sla.stateprovince
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
inner join SalesLT.Address as sla on sla.AddressID = slca.AddressID
group by slc.CustomerID,firstname,sla.city,sla.StateProvince
having count(*) > 1;





