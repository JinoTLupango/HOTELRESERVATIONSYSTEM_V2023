USE [HotelReservationDB]
GO

/****** Object:  Table [dbo].[tblRoomBooked]    Script Date: 20/12/2023 10:16:41 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblRoomBooked](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[room_id] [int] NULL,
	[check_in_date] [date] NULL,
	[check_out_date] [date] NULL,
	[check_in_time] [time](7) NULL,
	[Check_out_time] [time](7) NULL,
	[status] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
	[is_delete] [bit] NULL,
	[is_booked] [bit] NULL,
	[delete_datetime] [datetime] NULL,
	[cancel_datetime] [datetime] NULL,
	[approved_by] [int] NULL,
	[approved_datetime] [datetime] NULL,
	[remarks] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblRoomBooked] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblRoomBooked]  WITH CHECK ADD FOREIGN KEY([approved_by])
REFERENCES [dbo].[tblUsers] ([id])
GO

ALTER TABLE [dbo].[tblRoomBooked]  WITH CHECK ADD FOREIGN KEY([room_id])
REFERENCES [dbo].[tblRoom] ([id])
GO

ALTER TABLE [dbo].[tblRoomBooked]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[tblUsers] ([id])
GO


