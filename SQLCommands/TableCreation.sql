CREATE TABLE items(
	id INT auto_increment Primary Key,
    Name varchar(255) NOT NULL,
    Description TEXT,
    Quantity INT DEFAULT 0
);