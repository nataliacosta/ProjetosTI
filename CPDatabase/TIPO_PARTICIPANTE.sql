CREATE TABLE [dbo].[TIPO_PARTICIPANTE]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [titulo] VARCHAR(50) NULL, 
    [insere_documentos] BIT NULL DEFAULT 1
)
