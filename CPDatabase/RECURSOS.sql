﻿CREATE TABLE [dbo].[RECURSOS]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [pessoa] INT NOT NULL, 
    [sistema] INT NOT NULL, 
    [tipo] INT NOT NULL, 
    CONSTRAINT [FK_RECURSOS_PESSOA] FOREIGN KEY ([pessoa]) REFERENCES [PESSOAS]([id]), 
    CONSTRAINT [FK_RECURSOS_SISTEMA] FOREIGN KEY ([sistema]) REFERENCES [SISTEMAS]([id]), 
    CONSTRAINT [FK_RECURSOS_TIPO] FOREIGN KEY ([tipo]) REFERENCES [TIPO_RECURSO]([id])
)