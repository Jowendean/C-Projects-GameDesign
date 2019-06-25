﻿CREATE TABLE [dbo].ZooAnimal
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ZooID] INT NOT NULL, 
    [AnimalID] INT NOT NULL, 
    CONSTRAINT ZooFK FOREIGN KEY (ZooID) REFERENCES Zoo(Id),
	CONSTRAINT AnimalFK FOREIGN KEY (AnimalId) REFERENCES Animal(Id)
)