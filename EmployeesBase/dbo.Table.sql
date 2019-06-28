
CREATE TABLE[dbo].[People] (
                                    [Id] INT IDENTITY(1, 1) NOT NULL,
                                    [SURENAME] NVARCHAR(MAX) COLLATE Cyrillic_General_CI_AS NULL,
                                    [FIRSTNAME] NVARCHAR(MAX) NULL,
                                    [DEPARTMENT]    NVARCHAR(MAX) NULL,
                                    [AGE]    NVARCHAR(MAX) NULL,
									[SALARY]    NVARCHAR(MAX) NULL,
                                    CONSTRAINT[PK_dbo.People] PRIMARY KEY CLUSTERED([Id] ASC)
                                );
