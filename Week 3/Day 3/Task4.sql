
USE EcommAppDb


/***

1. Display product_name, store_name, available stock quantity, and total quantity sold.

2. Include products even if they have not been sold (use appropriate join).

3. Group results by product_name,quantity and store_name.

4. Sort results by product_name. 

**/

-- Combine 4 Requirements -- 

select 
    p.product_name,
    s.store_name,
    st.quantity as available_stock,
    sum(oi.quantity) as total_quantity_sold
from stocks st
inner join products p 
    on st.product_id = p.product_id
inner join stores s 
    on st.store_id = s.store_id
left join order_items oi 
    on st.product_id = oi.product_id
group by 
    p.product_name,
    s.store_name,
    st.quantity
order by p.product_name;