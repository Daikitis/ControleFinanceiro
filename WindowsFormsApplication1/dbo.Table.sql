CREATE TABLE [Rendas]
(
	[IdRenda] INT NOT NULL PRIMARY KEY IDENTITY DEFAULT NEXT VALUE FOR [dbo].[Rendas_IdRenda_Sequence], 
    [NmRenda] NVARCHAR(50) NOT NULL, 
    [ValorRenda] DECIMAL NOT NULL, 
    [DiaEntrada] INT NULL, 
    [Obs] NVARCHAR(MAX) NULL
);