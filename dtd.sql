USE [DtdLesson10]
GO
/****** Object:  Table [dbo].[DtdPost]    Script Date: 6/25/2025 3:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtdPost](
	[dtdId] [int] NOT NULL,
	[dtdTitle] [nvarchar](250) NOT NULL,
	[dtdImage] [nvarchar](250) NULL,
	[dtdContent] [ntext] NULL,
	[dtdStatus] [bit] NULL,
 CONSTRAINT [PK_DtdPost] PRIMARY KEY CLUSTERED 
(
	[dtdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
