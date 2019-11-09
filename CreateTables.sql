
GO
CREATE TABLE [dbo].[PARTICIPANTES] (
    [pessoa]  INT         NOT NULL,
    [projeto] INT         NOT NULL,
    [tipo]    VARCHAR (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([pessoa] ASC, [projeto] ASC)
);


GO
PRINT N'Creating [dbo].[PESSOAS]...';


GO
CREATE TABLE [dbo].[PESSOAS] (
    [id]     INT          NOT NULL,
    [nome]   VARCHAR (50) NOT NULL,
    [gestor] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[PROJETOS]...';


GO
CREATE TABLE [dbo].[PROJETOS] (
    [id]            INT          NOT NULL,
    [sistema]       INT          NOT NULL,
    [responsavel]   INT          NOT NULL,
    [aprovador]     INT          NULL,
    [aprovado_em]   DATE         NULL,
    [criado_em]     DATE         NOT NULL,
    [titulo]        VARCHAR (50) NOT NULL,
    [descricao]     NTEXT        NULL,
    [solicitacao]   INT          NULL,
    [finalizado_em] DATE         NULL,
    [status]        VARCHAR (1)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[RECURSOS]...';


GO
CREATE TABLE [dbo].[RECURSOS] (
    [id]      INT NOT NULL,
    [pessoa]  INT NOT NULL,
    [sistema] INT NOT NULL,
    [tipo]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[SISTEMAS]...';


GO
CREATE TABLE [dbo].[SISTEMAS] (
    [id]   INT          NOT NULL,
    [nome] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[SOLICITACOES]...';


GO
CREATE TABLE [dbo].[SOLICITACOES] (
    [id]          INT          NOT NULL,
    [sistema]     INT          NOT NULL,
    [solicitante] INT          NOT NULL,
    [aprovador]   INT          NULL,
    [titulo]      VARCHAR (50) NOT NULL,
    [descricao]   NTEXT        NULL,
    [criado_em]   DATE         NOT NULL,
    [aprovado_em] DATE         NULL,
    [status]      VARCHAR (1)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[TIPO_PARTICIPANTE]...';


GO
CREATE TABLE [dbo].[TIPO_PARTICIPANTE] (
    [id]                INT          NOT NULL,
    [titulo]            VARCHAR (50) NULL,
    [insere_documentos] BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating [dbo].[TIPO_RECURSO]...';


GO
CREATE TABLE [dbo].[TIPO_RECURSO] (
    [id]                 INT          NOT NULL,
    [titulo]             VARCHAR (50) NULL,
    [cria_solicitacao]   BIT          NULL,
    [cria_projeto]       BIT          NULL,
    [aprova_solicitacao] BIT          NULL,
    [aprova_projeto]     BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[PROJETOS]...';


GO
ALTER TABLE [dbo].[PROJETOS]
    ADD DEFAULT 'E' FOR [status];


GO
PRINT N'Creating unnamed constraint on [dbo].[SOLICITACOES]...';


GO
ALTER TABLE [dbo].[SOLICITACOES]
    ADD DEFAULT 'E' FOR [status];


GO
PRINT N'Creating unnamed constraint on [dbo].[TIPO_PARTICIPANTE]...';


GO
ALTER TABLE [dbo].[TIPO_PARTICIPANTE]
    ADD DEFAULT 1 FOR [insere_documentos];


GO
PRINT N'Creating unnamed constraint on [dbo].[TIPO_RECURSO]...';


GO
ALTER TABLE [dbo].[TIPO_RECURSO]
    ADD DEFAULT 0 FOR [cria_solicitacao];


GO
PRINT N'Creating unnamed constraint on [dbo].[TIPO_RECURSO]...';


GO
ALTER TABLE [dbo].[TIPO_RECURSO]
    ADD DEFAULT 0 FOR [cria_projeto];


GO
PRINT N'Creating unnamed constraint on [dbo].[TIPO_RECURSO]...';


GO
ALTER TABLE [dbo].[TIPO_RECURSO]
    ADD DEFAULT 0 FOR [aprova_solicitacao];


GO
PRINT N'Creating unnamed constraint on [dbo].[TIPO_RECURSO]...';


GO
ALTER TABLE [dbo].[TIPO_RECURSO]
    ADD DEFAULT 0 FOR [aprova_projeto];


GO
PRINT N'Creating [dbo].[FK_PARTICIPANTES_PESSOA]...';


GO
ALTER TABLE [dbo].[PARTICIPANTES] WITH NOCHECK
    ADD CONSTRAINT [FK_PARTICIPANTES_PESSOA] FOREIGN KEY ([pessoa]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_PESSOAS_GESTOR]...';


GO
ALTER TABLE [dbo].[PESSOAS] WITH NOCHECK
    ADD CONSTRAINT [FK_PESSOAS_GESTOR] FOREIGN KEY ([gestor]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_PROJETOS_SISTEMA]...';


GO
ALTER TABLE [dbo].[PROJETOS] WITH NOCHECK
    ADD CONSTRAINT [FK_PROJETOS_SISTEMA] FOREIGN KEY ([sistema]) REFERENCES [dbo].[SISTEMAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_PROJETOS_RESPONSAVEL]...';


GO
ALTER TABLE [dbo].[PROJETOS] WITH NOCHECK
    ADD CONSTRAINT [FK_PROJETOS_RESPONSAVEL] FOREIGN KEY ([responsavel]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_PROJETOS_APROVADOR]...';


GO
ALTER TABLE [dbo].[PROJETOS] WITH NOCHECK
    ADD CONSTRAINT [FK_PROJETOS_APROVADOR] FOREIGN KEY ([aprovador]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_PROJETOS_SOLICITACAO]...';


GO
ALTER TABLE [dbo].[PROJETOS] WITH NOCHECK
    ADD CONSTRAINT [FK_PROJETOS_SOLICITACAO] FOREIGN KEY ([solicitacao]) REFERENCES [dbo].[SOLICITACOES] ([id]);


GO
PRINT N'Creating [dbo].[FK_RECURSOS_PESSOA]...';


GO
ALTER TABLE [dbo].[RECURSOS] WITH NOCHECK
    ADD CONSTRAINT [FK_RECURSOS_PESSOA] FOREIGN KEY ([pessoa]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_RECURSOS_SISTEMA]...';


GO
ALTER TABLE [dbo].[RECURSOS] WITH NOCHECK
    ADD CONSTRAINT [FK_RECURSOS_SISTEMA] FOREIGN KEY ([sistema]) REFERENCES [dbo].[SISTEMAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_RECURSOS_TIPO]...';


GO
ALTER TABLE [dbo].[RECURSOS] WITH NOCHECK
    ADD CONSTRAINT [FK_RECURSOS_TIPO] FOREIGN KEY ([tipo]) REFERENCES [dbo].[TIPO_RECURSO] ([id]);


GO
PRINT N'Creating [dbo].[FK_SOLICITACOES_SISTEMA]...';


GO
ALTER TABLE [dbo].[SOLICITACOES] WITH NOCHECK
    ADD CONSTRAINT [FK_SOLICITACOES_SISTEMA] FOREIGN KEY ([sistema]) REFERENCES [dbo].[SISTEMAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_SOLICITACOES_SOLICITANTE]...';


GO
ALTER TABLE [dbo].[SOLICITACOES] WITH NOCHECK
    ADD CONSTRAINT [FK_SOLICITACOES_SOLICITANTE] FOREIGN KEY ([solicitante]) REFERENCES [dbo].[PESSOAS] ([id]);


GO
PRINT N'Creating [dbo].[FK_SOLICITACOES_APROVADOR]...';


GO
ALTER TABLE [dbo].[SOLICITACOES] WITH NOCHECK
    ADD CONSTRAINT [FK_SOLICITACOES_APROVADOR] FOREIGN KEY ([aprovador]) REFERENCES [dbo].[PESSOAS] ([id]);

	
GO
ALTER TABLE [dbo].[PARTICIPANTES] WITH CHECK CHECK CONSTRAINT [FK_PARTICIPANTES_PESSOA];

ALTER TABLE [dbo].[PESSOAS] WITH CHECK CHECK CONSTRAINT [FK_PESSOAS_GESTOR];

ALTER TABLE [dbo].[PROJETOS] WITH CHECK CHECK CONSTRAINT [FK_PROJETOS_SISTEMA];

ALTER TABLE [dbo].[PROJETOS] WITH CHECK CHECK CONSTRAINT [FK_PROJETOS_RESPONSAVEL];

ALTER TABLE [dbo].[PROJETOS] WITH CHECK CHECK CONSTRAINT [FK_PROJETOS_APROVADOR];

ALTER TABLE [dbo].[PROJETOS] WITH CHECK CHECK CONSTRAINT [FK_PROJETOS_SOLICITACAO];

ALTER TABLE [dbo].[RECURSOS] WITH CHECK CHECK CONSTRAINT [FK_RECURSOS_PESSOA];

ALTER TABLE [dbo].[RECURSOS] WITH CHECK CHECK CONSTRAINT [FK_RECURSOS_SISTEMA];

ALTER TABLE [dbo].[RECURSOS] WITH CHECK CHECK CONSTRAINT [FK_RECURSOS_TIPO];

ALTER TABLE [dbo].[SOLICITACOES] WITH CHECK CHECK CONSTRAINT [FK_SOLICITACOES_SISTEMA];

ALTER TABLE [dbo].[SOLICITACOES] WITH CHECK CHECK CONSTRAINT [FK_SOLICITACOES_SOLICITANTE];

ALTER TABLE [dbo].[SOLICITACOES] WITH CHECK CHECK CONSTRAINT [FK_SOLICITACOES_APROVADOR];