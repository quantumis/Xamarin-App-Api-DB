USE [COMP_FIRM]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 07.06.2022 12:09:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[id] [int] NOT NULL,
	[idCus] [int] NOT NULL,
	[idC] [int] NOT NULL,
	[DateS] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([idC])
REFERENCES [dbo].[Components] ([id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([idCus])
REFERENCES [dbo].[Customer] ([id])
ON DELETE CASCADE
GO
