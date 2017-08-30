Create Database GeoLocationDb;

Create Table Locations(
	Id			INT				IDENTITY(1,1)	NOT NULL,
	Latitude	NVARCHAR(MAX)	NOT NULL,
	Longitude	NVARCHAR(MAX)	NOT NULL,
	GeoLocation	GEOGRAPHY		NOT NULL,
	Primary Key(Id)
);