CREATE TABLE [dbo].[PARTICIPANTES]
(
	[pessoa] INT NOT NULL , 
    [projeto] INT NOT NULL, 
    [tipo] INT NOT NULL, 
    PRIMARY KEY ([pessoa], [projeto]), 
    CONSTRAINT [FK_PARTICIPANTES_PESSOA] FOREIGN KEY ([pessoa]) REFERENCES [PESSOAS]([id]) 
)
