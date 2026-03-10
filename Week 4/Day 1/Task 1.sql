USE EcommAppDb

-- 1. to generate total sales amount per store

CREATE PROCEDURE TotalSalesPerStore
AS
BEGIN
    SELECT 
        s.store_id,
        SUM(oi.quantity * oi.list_price) AS total_sales
    FROM orders o
    JOIN order_items oi ON o.order_id = oi.order_id
    JOIN stores s ON o.store_id = s.store_id
    GROUP BY s.store_id;
END;

EXEC TotalSalesPerStore;

--2.to retrieve orders by date range. --

CREATE PROCEDURE GetOrdersByDateRange
    @start_date DATE,
    @end_date DATE
AS
BEGIN
    SELECT *
    FROM orders
    WHERE order_date BETWEEN @start_date AND @end_date;
END;

EXEC GetOrdersByDateRange '2016-01-01', '2016-01-08';

 -- 3. to calculate total price after discount

CREATE FUNCTION CalculateDiscountPrice
(
    @price DECIMAL(10,2),
    @quantity INT,
    @discount DECIMAL(5,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @final_price DECIMAL(10,2);

    SET @final_price = @price*@quantity - (@price * @discount*@quantity);

    RETURN @final_price;
END;

SELECT dbo.CalculateDiscountPrice(1000,2,0.10) AS final_price;

--4.table-valued function to return top 5 selling products.

CREATE FUNCTION Top5SellingProducts()
RETURNS TABLE
AS
RETURN
(
    SELECT TOP 5
        p.product_id,
        p.product_name,
        SUM(oi.quantity) AS total_sold
    FROM order_items oi
    JOIN products p ON oi.product_id = p.product_id
    GROUP BY p.product_id, p.product_name
    ORDER BY total_sold DESC
);

SELECT * FROM Top5SellingProducts();