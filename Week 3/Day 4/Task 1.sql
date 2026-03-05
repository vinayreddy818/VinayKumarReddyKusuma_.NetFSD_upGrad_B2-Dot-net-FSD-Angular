USE EcommAppDb

/*--1. Retrieve product details (product_name, model_year, list_price).
2. Compare each product’s price with the average price of products in the same category
using a nested query.
3. Display only those products whose price is greater than the category average.
4. Show calculated difference between product price and category average.
5. Concatenate product name and model year as a single column (e.g., 'ProductName
(2017)')*/

select 
	p.product_name +'('+ cast( p.model_year as varchar)+')' as product_info, 
	p.list_price, 
	p.list_price - 
	( select avg(list_price) 
		from products 
		where category_id=p.category_id 
	  ) as  price_difference 
	  from products p
	where p.list_price > 
	(
		select avg(list_price) 
		from products 
		where category_id= p.category_id
	)
