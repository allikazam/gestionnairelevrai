CREATE TABLE [dbo].[Fournisseurs] (
    [ID]        INT           NOT NULL,
    [Nom]       VARCHAR (255) NULL,
    [Adresse]   VARCHAR (255) NULL,
    [Ville] VARCHAR (20)  NULL,
    [Email]     VARCHAR (255) NULL,
    [Telephone] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

