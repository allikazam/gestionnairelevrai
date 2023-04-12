CREATE TABLE [dbo].[Produits] (
    [ID]              INT           NOT NULL,
    [Nom]             VARCHAR (255) NOT NULL,
    [Description]     VARCHAR (255) NOT NULL,
    [NumeroSerie]     VARCHAR (255) NOT NULL,
    [QuantiteEnStock] INT           NOT NULL,
    [QuantiteMin]     INT           NOT NULL,
    [QuantiteMax]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

