

USE EcommAppDb

--1. Retrieve customer first name, last name, order_id, order_date, and order_status.--
    select 
        c.customer_id, 
        c.first_name,
        c.last_name,
        o.order_id,
        o.order_date,
        o.order_status 
    from customers c inner join orders o on c.customer_id = o.customer_id

--2. Display only orders with status Pending (1) or Completed (4).--

     select * from orders where order_status=1 or order_status=4;

--3. Sort the results by order_date in descending order.--
     
     select * from orders order by order_date desc;

-- Combine Three Requirements -- 

select 
    c.customer_id, 
    c.first_name,
    c.last_name,
    o.order_id,
    o.order_date,
    o.order_status 
from customers c inner join orders o on c.customer_id = o.customer_id
Where o.order_status = 1 or o.order_status = 4  order by  o.order_date DESC;
