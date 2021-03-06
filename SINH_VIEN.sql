CREATE database SINH_VIEN;
USE [SINH_VIEN]
GO
/****** Object:  Table [dbo].[DiemSV]    Script Date: 21/10/2020 16:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemSV](
	[MSSV] [nchar](12) NOT NULL,
	[IDMH] [nchar](50) NULL,
	[MaGV] [nchar](12) NULL,
	[Ma_HK] [nchar](10) NULL,
	[DiemLan1] [float] NULL,
	[DiemLan2] [float] NULL,
	[DiemTichLuy] [float] NULL,
	[DiemChu] [nchar](50) NULL,
 CONSTRAINT [PK_Table_3] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 21/10/2020 16:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [nchar](12) NULL,
	[TenGV] [nchar](30) NULL,
	[GioiTinhGV] [int] NULL,
	[NamSinhGV] [datetime] NULL,
	[TrinhDoGV] [nchar](15) NOT NULL,
	[EmailGV] [nchar](30) NULL,
	[SDT] [nchar](12) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 21/10/2020 16:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[IDMH] [nchar](10) NULL,
	[MA_HK] [nchar](10) NULL,
	[TenMH] [nchar](50) NULL,
	[SoTC] [int] NULL,
	[LyThuyet] [int] NULL,
	[ThucHanh] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DiemSV] ([MSSV], [IDMH], [MaGV], [Ma_HK], [DiemLan1], [DiemLan2], [DiemTichLuy], [DiemChu]) VALUES (N'CE140085    ', N'LAB211                                            ', N'GV005       ', N'FA19      ', 9, 9, 0.5, N'Chin cham nam                                     ')
INSERT [dbo].[DiemSV] ([MSSV], [IDMH], [MaGV], [Ma_HK], [DiemLan1], [DiemLan2], [DiemTichLuy], [DiemChu]) VALUES (N'CE140273    ', N'PRN292                                            ', N'GV003       ', N'SP20      ', 7, 8, 1, N'Tam cham nam                                      ')
INSERT [dbo].[DiemSV] ([MSSV], [IDMH], [MaGV], [Ma_HK], [DiemLan1], [DiemLan2], [DiemTichLuy], [DiemChu]) VALUES (N'CE140337    ', N'PRJ321                                            ', N'GV002       ', N'FA20      ', 5, 5, 1, N'Sau                                               ')
INSERT [dbo].[DiemSV] ([MSSV], [IDMH], [MaGV], [Ma_HK], [DiemLan1], [DiemLan2], [DiemTichLuy], [DiemChu]) VALUES (N'CE140350    ', N'PRJ311                                            ', N'GV001       ', N'SP19      ', 8, 9, 0.5, N'Chin cham khong                                   ')
INSERT [dbo].[DiemSV] ([MSSV], [IDMH], [MaGV], [Ma_HK], [DiemLan1], [DiemLan2], [DiemTichLuy], [DiemChu]) VALUES (N'CE140435    ', N'JPD121                                            ', N'GV004       ', N'SU19      ', 3, 6, 0.5, N'Nam                                               ')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NamSinhGV], [TrinhDoGV], [EmailGV], [SDT]) VALUES (N'GV001       ', N'Quach Luyl Da                 ', 0, CAST(N'1980-08-16T00:00:00.000' AS DateTime), N'Tien Si        ', N'Daql@gmail.com                ', N'0956845215  ')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NamSinhGV], [TrinhDoGV], [EmailGV], [SDT]) VALUES (N'GV002       ', N'Vo Hong Khanh                 ', 0, CAST(N'1980-02-07T00:00:00.000' AS DateTime), N'Thac Si        ', N'Khanh@gmail.com               ', N'0947744409  ')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NamSinhGV], [TrinhDoGV], [EmailGV], [SDT]) VALUES (N'GV003       ', N'Luong Hoang Huong             ', 0, CAST(N'1990-06-13T00:00:00.000' AS DateTime), N'Tien Si        ', N'Huong@gmail.com               ', N'0789532458  ')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NamSinhGV], [TrinhDoGV], [EmailGV], [SDT]) VALUES (N'GV004       ', N'Huynh Cong Tuoc               ', 0, CAST(N'1989-07-01T00:00:00.000' AS DateTime), N'Thac Si        ', N'Tuoc@gmail.com                ', N'0852117648  ')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [NamSinhGV], [TrinhDoGV], [EmailGV], [SDT]) VALUES (N'GV005       ', N'Nguyen Thi Thuy An            ', 1, CAST(N'1989-11-20T00:00:00.000' AS DateTime), N'Tien Si        ', N'Anntt@gmail.com               ', N'0984215224  ')
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'PRN292    ', N'SU20      ', N'C# và .NET                                        ', 3, 20, 10)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'PRJ311    ', N'SP19      ', N'Desktop Java Applications                         ', 3, 20, 15)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'PRJ321    ', N'SP20      ', N'Web-based Java                                    ', 3, 25, 10)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'LAB211    ', N'FA19      ', N'OOP with Java Lab                                 ', 3, 0, 30)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'LAB101    ', N'SP18      ', N'C Lab                                             ', 3, 0, 30)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'JPD131    ', N'FA20      ', N'Japanese Elementery (Part 3/4)                    ', 3, 30, 0)
INSERT [dbo].[MonHoc] ([IDMH], [MA_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'JPD121    ', N'SU19      ', N'Japanese Elementery (Part 2/4)                    ', 3, 30, 0)
