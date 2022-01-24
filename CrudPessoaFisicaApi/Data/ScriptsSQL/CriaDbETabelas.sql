BEGIN
CREATE DATABASE CrudPessoaFisicaApi
END;
GO

use CrudPessoaFisicaApi;

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [PessoaFisica] (
    [Id] int NOT NULL IDENTITY,
    [Cpf] nvarchar(max) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    [NomeCompleto] nvarchar(200) NOT NULL,
    [DataNascimento] datetime2 NOT NULL,
    [ValorRenda] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_PessoaFisica] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220121042850_CriandoBd', N'6.0.1');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PessoaFisica]') AND [c].[name] = N'ValorRenda');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [PessoaFisica] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [PessoaFisica] ALTER COLUMN [ValorRenda] nvarchar(max) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220123185937_MudandoTipoDaRenda', N'6.0.1');
GO

COMMIT;
GO

