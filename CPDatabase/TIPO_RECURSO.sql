CREATE TABLE [dbo].[TIPO_RECURSO]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [titulo] VARCHAR(50) NULL, 
    [cria_solicitacao] BIT NULL DEFAULT 0, 
    [cria_projeto] BIT NULL DEFAULT 0, 
    [aprova_solicitacao] BIT NULL DEFAULT 0, 
    [aprova_projeto] BIT NULL DEFAULT 0
)
