CREATE TABLE [dbo].[Book] (
    [ID]            BIGINT        IDENTITY (1, 1) NOT NULL,
    [Title]         NVARCHAR (50) NULL,
    [Author]        NVARCHAR (50) NULL,
    [ISBN]          NVARCHAR (13) NULL,
    [PublishedDate] DATETIME      NULL,
    [DeletedOn]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

