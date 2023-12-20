USE [HotelReservationDB]
GO

/****** Object:  Table [dbo].[tblRoom]    Script Date: 20/12/2023 10:16:25 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblRoom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[floor_no] [int] NULL,
	[status] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
	[is_delete] [bit] NULL,
	[tdt] [datetime] NULL,
	[udt] [datetime] NULL,
	[ddt] [datetime] NULL,
 CONSTRAINT [PK_tblRoom] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


