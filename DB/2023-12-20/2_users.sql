USE [HotelReservationDB]
GO

/****** Object:  Table [dbo].[tblUsers]    Script Date: 20/12/2023 10:15:59 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](150) NULL,
	[name] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
	[is_deleted] [bit] NULL,
	[tdt] [datetime] NULL,
	[udt] [datetime] NULL,
	[role_id] [int] NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblUsers]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[tblRole] ([id])
GO


