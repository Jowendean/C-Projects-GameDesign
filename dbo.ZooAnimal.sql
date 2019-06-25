CREATE TABLE [dbo].[ZooAnimal] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [ZooID]    INT NOT NULL,
    [AnimalID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AnimalFK] FOREIGN KEY ([AnimalID]) REFERENCES [dbo].[Animal] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [ZooFK] FOREIGN KEY ([ZooID]) REFERENCES [dbo].[Zoo] ([Id]) ON DELETE CASCADE
);

