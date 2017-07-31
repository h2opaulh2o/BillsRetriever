/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


CREATE TABLE Bill (
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProviderId INT NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	PayDate DATE NOT NULL,
	Price FLOAT NOT NULL,
	FOREIGN KEY (ProviderId) REFERENCES BillProvider(Id)
);