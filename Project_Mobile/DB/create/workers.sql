USE [COMP_FIRM]
GO

/****** Object:  Table [dbo].[Workers]    Script Date: 07.06.2022 12:09:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Workers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Salary] [decimal](12, 2) NOT NULL,
	[Post] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Workers] ADD  DEFAULT ((1)) FOR [Post]
GO

ALTER TABLE [dbo].[Workers]  WITH CHECK ADD FOREIGN KEY([Post])
REFERENCES [dbo].[Posts] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

