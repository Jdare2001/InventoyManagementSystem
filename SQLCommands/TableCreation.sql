Use IMSystem;

CREATE TABLE Items(
	Id INT auto_increment Primary Key,
    Name varchar(255) NOT NULL,
    Description TEXT,
    Quantity INT DEFAULT 0
);
CREATE TABLE Deliveries(
	Id Int auto_increment Primary Key,
    ItemID int,
    Quantity int,
    DeliveryDate DATE,
    FOREIGN KEY (ItemId) REFERENCES Items(Id)
)