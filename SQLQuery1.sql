	CREATE TABLE  Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25)
	)
CREATE TABLE Brands (
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25)
	)

CREATE TABLE Cars (
    Id        INT   PRIMARY KEY IDENTITY(1,1),
	BrandId     INT,    
    ColorId     INT ,        
    ModelYear  VARCHAR (50), 
    DailyPrice  DECIMAL (18) ,
    Descriptions VARCHAR (250),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
	)

	

	INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) VALUES
	('6','5','2001','60000','1.Model'),
	('1','5','2005','50000','2.Model'),
	('7','1','2010','70000','3.Model'),
	('3','2','1995','65000','4.Model'),
	('9','2','2017','80000','5.Model'),
	('7','3','2012','64000','6.Model');


	INSERT INTO Colors(ColorName) VALUES
	('Yeşil'),
	('Siyah'),
	('Beyaz'),
	('Kırmızı'),
	('Gri');


	INSERT INTO Brands(BrandName) VALUES
	('Mercedes'),
	('Polo'),
	('Şahin'),
	('BMW'),
	('Renault'),
	('Audi'),
	('Cadillac'),
	('Aston Martin'),
	('Buick');

	Select * from Cars
	Select * from Colors
	Select * from Brands
