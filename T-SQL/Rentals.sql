﻿CREATE TABLE Rentals (
    Id INT IDENTITY PRIMARY KEY NOT NULL,
	CarId INT  NOT NULL,
    CustomerId INT  NOT NULL,
	RentDate DATETIME DEFAULT(getdate()),
	ReturnDate DATETIME DEFAULT(getdate()),
	CONSTRAINT fkCustomerIdd FOREIGN KEY(CustomerId) REFERENCES Customer(CustomerId),
	CONSTRAINT fkCarIdd FOREIGN KEY(CarId) REFERENCES Car(CarId),
);