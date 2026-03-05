
USE EcommAppDb

/**** 1. Display store_name and total sales amount.

2. Calculate total sales using .

3. Include only completed orders (order_status = 4).

4. Group results by store_name.

5. Sort total sales in descending order. ****/


-- Combine Five Requirements -- 
select 
    s.store_name,
    sum(oi.quantity * oi.list_price) as total_sales_amount
from stores s
inner join orders o 
    on s.store_id = o.store_id
inner join order_items oi 
    on o.order_id = oi.order_id
where o.order_status = 4
group by s.store_name order by total_sales_amount desc;