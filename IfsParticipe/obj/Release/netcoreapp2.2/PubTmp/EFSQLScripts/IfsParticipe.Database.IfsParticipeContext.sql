IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE TABLE [PDI] (
        [Id] int NOT NULL IDENTITY,
        [IdUsuario] int NOT NULL,
        [Situacao] int NOT NULL,
        [DataIniVig] datetime2 NOT NULL,
        [DataFimVig] datetime2 NOT NULL,
        [DataIniRecDem] datetime2 NULL,
        [DataFimRecDem] datetime2 NULL,
        [DataCadastro] datetime2 NOT NULL,
        [DataAtualizacao] datetime2 NOT NULL,
        CONSTRAINT [PK_PDI] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE TABLE [Usuario] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NULL,
        [Tipo] nvarchar(1) NOT NULL,
        [Email] nvarchar(max) NULL,
        [Telefone] nvarchar(max) NULL,
        [Login] nvarchar(10) NOT NULL,
        [Senha] nvarchar(10) NOT NULL,
        [DataCadastro] datetime2 NULL,
        CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE TABLE [Demanda] (
        [Id] int NOT NULL IDENTITY,
        [IdUsuario] int NOT NULL,
        [IdPDI] int NOT NULL,
        [Titulo] nvarchar(60) NOT NULL,
        [Descricao] nvarchar(500) NOT NULL,
        [Situacao] int NULL,
        [Categoria] int NOT NULL,
        [DataCadastro] datetime2 NOT NULL,
        [DataAtualizacao] datetime2 NOT NULL,
        CONSTRAINT [PK_Demanda] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Demanda_PDI_IdPDI] FOREIGN KEY ([IdPDI]) REFERENCES [PDI] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE TABLE [Comentario] (
        [Id] int NOT NULL IDENTITY,
        [IdUsuario] int NOT NULL,
        [IdDemanda] int NOT NULL,
        [Descricao] nvarchar(max) NOT NULL,
        [DataCadastro] datetime2 NOT NULL,
        [DataAtualizacao] datetime2 NOT NULL,
        CONSTRAINT [PK_Comentario] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Comentario_Demanda_IdDemanda] FOREIGN KEY ([IdDemanda]) REFERENCES [Demanda] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE TABLE [Avaliacao] (
        [Id] int NOT NULL IDENTITY,
        [IdUsuario] int NOT NULL,
        [Nota] int NOT NULL,
        [IdDemanda] int NULL,
        [IdComentario] int NULL,
        [Tipo] nvarchar(1) NOT NULL,
        [DataAtualizacao] datetime2 NOT NULL,
        CONSTRAINT [PK_Avaliacao] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Avaliacao_Comentario_IdComentario] FOREIGN KEY ([IdComentario]) REFERENCES [Comentario] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Avaliacao_Demanda_IdDemanda] FOREIGN KEY ([IdDemanda]) REFERENCES [Demanda] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE INDEX [IX_Avaliacao_IdComentario] ON [Avaliacao] ([IdComentario]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE INDEX [IX_Avaliacao_IdDemanda] ON [Avaliacao] ([IdDemanda]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE INDEX [IX_Comentario_IdDemanda] ON [Comentario] ([IdDemanda]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    CREATE INDEX [IX_Demanda_IdPDI] ON [Demanda] ([IdPDI]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506193714_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210506193714_Initial', N'2.2.6-servicing-10079');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210517235715_attcampologin')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Usuario]') AND [c].[name] = N'Login');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Usuario] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Usuario] ALTER COLUMN [Login] nvarchar(100) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210517235715_attcampologin')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210517235715_attcampologin', N'2.2.6-servicing-10079');
END;

GO

