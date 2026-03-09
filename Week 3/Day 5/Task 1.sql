USE EcommAppDb
SELECT * FROM categories
SELECT * FROM brands
SELECT * FROM products
SELECT * FROM customers

INSERT INTO categories (category_name)
VALUES
('Mountain Bikes'),
('Road Bikes'),
('Electric Bikes'),
('Accessories'),
('Kids Bikes');

INSERT INTO brands (brand_name)
VALUES
('Trek'),
('Giant'),
('Specialized'),
('Cannondale'),
('Scott');

INSERT INTO products (product_name, brand_id, category_id, model_year, list_price)
VALUES
('Marlin 7',1,1,2023,1200),
('Defy Advanced',2,2,2024,2200),
('Turbo Vado',3,3,2023,3500),
('Trail 5',4,1,2022,950),
('Aspect 940',5,1,2024,1100);

INSERT INTO customers
(first_name,last_name,phone,email,street,city,state,zip_code)
VALUES
('Rohit','Sharma','8848244234','rohit@gmail.com','MG Road','Delhi','DL','11000'),
('Anita','Verma','5542424242','anita@gmail.com','Link Road','Mumbai','MH','40000'),
('Ravi','Kumar','8675674534','ravi@gmail.com','Banjara Hills','Hyderabad','TS','50008'),
('Sneha','Reddy','9656764646','sneha@gmail.com','Indiranagar','Bangalore','KA','56000'),
('Amit','Patel','9867564646','amit@gmail.com','Navrangpura','Ahmedabad','GJ','38000');


INSERT INTO stores
(store_name,phone,email,street,city,state,zip_code)
VALUES
('pune Store','8954585945','delhi@bike.com','pune road','pune','PU','11000'),
('Mumbai store','8584854858','mumbai@bike.com','Andheri','Mumbai','MH','40000'),
('Hyderabad store','8554588535','hyd@bike.com','Madhapur','Hyderabad','TS','50008'),
('Bangalore store','8584854855','blr@bike.com','Whitefield','Bangalore','KA','56006'),
('Delhi Store','959959258','chn@bike.com','T Nagar','delhi','DL','60501');

---1. RETIEVE PRODUCTS WITH BRAND AND CATEGORY---
SELECT
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
FROM products p
JOIN brands b
ON p.brand_id=b.brand_id
JOIN categories c
ON p.category_id=c.category_id;

----2. RETRIVE CUSTOMERS FROM SPECIFIC CITY---
SELECT * FROM customers
WHERE city='Hyderabad';

----3. TOTAL PRODUCTS IN EACH CATEGORY---
SELECT 
c.category_name,
COUNT(p.product_id) AS total_products
FROM categories c
LEFT JOIN products p
ON c.category_id=p.category_id
GROUP BY c.category_name;