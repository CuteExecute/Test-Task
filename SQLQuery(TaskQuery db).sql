Create database TaskQuery
Use TaskQuery

Create table Product
(
Product_id int primary key identity(1,1),
ProductName varchar(100)
)

Create table Category
(
Category_id int primary key identity(1,1),
CategoryName varchar(100)
)

-- A table representing a many to many relationship
Create table ProductsCategories
(
Product_id int,
Category_id int,
Foreign key (Product_id) references Product(Product_id),
Foreign key (Category_id) references Category(Category_id)
)

-- Populating tables and creating a many to many relationship
Insert into Product (ProductName) values
('product_1'),
('product_2'),
('product_3'),
('prodyct_4')

Insert into Category(CategoryName) values
('category_1'),
('category_2'),
('category_3'),
('category_4')

Insert into ProductsCategories(Product_id, Category_id) values
(1, 1),
(1, 2),
(2, 3),
(4, 2),
(4, 3),
(4, 4)

-- Query to select all pairs "Product name - Category name"
Select ProductName, CategoryName
From Product
Left Join ProductsCategories On ProductsCategories.Product_id = Product.Product_id
Left Join Category On Category.Category_id = ProductsCategories.Category_id