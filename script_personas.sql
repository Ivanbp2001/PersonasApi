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

CREATE TABLE [Personas] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Apellido] nvarchar(max) NOT NULL,
    [FechaNacimiento] datetime2 NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Telefono] nvarchar(max) NULL,
    [Direccion] nvarchar(max) NULL,
    [FechaRegistro] datetime2 NOT NULL,
    CONSTRAINT [PK_Personas] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260207003039_InitialCreate', N'7.0.20');
GO

COMMIT;
GO

