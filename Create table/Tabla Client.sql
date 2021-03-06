SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Client](
	[Id] [bigint] NOT NULL,
	[Identification] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[SecondName] [nvarchar](100) NULL,
	[Surname] [nvarchar](100) NULL,
	[SecondSurname] [nvarchar](100) NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


