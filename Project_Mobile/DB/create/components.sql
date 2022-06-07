USE [COMP_FIRM]
GO

/****** Object:  Table [dbo].[Components]    Script Date: 07.06.2022 12:07:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Components](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idC] [int] NOT NULL,
	[idM] [int] NOT NULL,
	[Model] [nvarchar](30) NULL,
	[Quantity] [int] NOT NULL,
	[Price_R] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Components] ADD  DEFAULT ((0)) FOR [Price_R]
GO

ALTER TABLE [dbo].[Components]  WITH CHECK ADD FOREIGN KEY([idC])
REFERENCES [dbo].[Category] ([id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Components]  WITH CHECK ADD FOREIGN KEY([idM])
REFERENCES [dbo].[Manufacturer] ([id])
ON DELETE CASCADE
GO

