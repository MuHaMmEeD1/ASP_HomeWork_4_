CREATE DATABASE ProductDB 
GO
USE ProductDB
GO
CREATE TABLE Products(

	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX),
	[Description] NVARCHAR(MAX),

)
GO
INSERT INTO Products ([Name], [Description]) VALUES 
('Apple', 'Red apple, sweet, organic'),
('Banana', 'Fresh banana, dry, high quality'),
('Orange', 'Local orange, sweet and juicy'),
('Grapes', 'Sweet grapes, fresh, available in various types'),
('Peach', 'Fresh peach, sweet, high in vitamin C'),
('Mango', 'Sweet mango, tropical fruit, very tasty'),
('Pineapple', 'Fresh pineapple, sweet and tangy, tropical fruit'),
('Strawberry', 'Fresh strawberry, sweet and rich in vitamin C'),
('Watermelon', 'Fresh watermelon, very juicy, summer fruit'),
('Kiwi', 'Fresh kiwi, sweet and tangy, rich in vitamin C');

SELECT * FROM Products


