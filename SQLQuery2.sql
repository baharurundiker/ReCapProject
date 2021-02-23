INSERT INTO Customers(UserId) VALUES
(2),
(3),
(4);

INSERT INTO Rentals(RentalId,CarId,CustomerId,RentDate,ReturnDate) VALUES
(1,1,3,14-02-21,14-02-21),
(2,3,2,02-02-21,05-02-21),
(3,2,1,10-02-21,12-02-21);

DELETE FROM Customers WHERE UserId= null;