Create Login mylogin with password='mylogin', CHECK_POLICY = OFF;

Create Database DVDLibrary;

Use DVDLibrary;
sp_changedbowner mylogin;

Create Table DVDLibrary( 
	DVDCodeNo int Primary Key, 
	DVDTitle nvarchar(100) Not Null, 
	[Language] nvarchar(20) Not Null, 
	SubTitle bit Not Null, 
	Price Money Not Null 
)SELECT * FROM DVDLibrary;DELETE FROM DVDLibrary;