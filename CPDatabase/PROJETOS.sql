CREATE TABLE [dbo].[PROJETOS]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [sistema] INT NOT NULL, 
    [responsavel] INT NOT NULL, 
    [aprovador] INT NULL, 
    [aprovado_em] DATE NULL, 
    [criado_em] DATE NOT NULL, 
    [titulo] VARCHAR(50) NOT NULL, 
    [descricao] NTEXT NULL, 
    [solicitacao] INT NULL, 
    [finalizado_em] DATE NULL, 
    [status] VARCHAR NOT NULL DEFAULT 'E', 
    CONSTRAINT [FK_PROJETOS_SISTEMA] FOREIGN KEY ([sistema]) REFERENCES [SISTEMAS]([id]), 
    CONSTRAINT [FK_PROJETOS_RESPONSAVEL] FOREIGN KEY ([responsavel]) REFERENCES [PESSOAS]([id]), 
    CONSTRAINT [FK_PROJETOS_APROVADOR] FOREIGN KEY ([aprovador]) REFERENCES [PESSOAS]([id]), 
    CONSTRAINT [FK_PROJETOS_SOLICITACAO] FOREIGN KEY ([solicitacao]) REFERENCES [SOLICITACOES]([id])
)
