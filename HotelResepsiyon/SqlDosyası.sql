USE [HotelResepsiyon]
GO
/****** Object:  Table [dbo].[MusteriBilgi]    Script Date: 31.12.2020 00:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriBilgi](
	[isim] [nvarchar](50) NULL,
	[soyisim] [nvarchar](50) NULL,
	[kimlikno] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[odacinsi] [nvarchar](50) NULL,
	[giristarihi] [datetime] NULL,
	[cikistarihi] [datetime] NULL,
	[gunsayisi] [nvarchar](50) NULL,
	[odeme] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 31.12.2020 00:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[tek] [int] NULL,
	[iki] [int] NULL,
	[uc] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResepsiyonGirisi]    Script Date: 31.12.2020 00:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResepsiyonGirisi](
	[kullaniciAdi] [nchar](10) NOT NULL,
	[sifre] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[MusteriBilgi] ([isim], [soyisim], [kimlikno], [telefon], [odacinsi], [giristarihi], [cikistarihi], [gunsayisi], [odeme]) VALUES (N'Feyza', N'Koç', N'123456789', N'123456789', N'Tek Kişilik Oda', CAST(N'2020-12-26T19:52:33.487' AS DateTime), CAST(N'2020-12-30T19:52:33.000' AS DateTime), N'4', N'400')
INSERT [dbo].[MusteriBilgi] ([isim], [soyisim], [kimlikno], [telefon], [odacinsi], [giristarihi], [cikistarihi], [gunsayisi], [odeme]) VALUES (N'Ahmet', N'Ümit', N'123456789', N'05602563312', N'Tek Kişilik Oda', CAST(N'2020-12-30T22:43:28.367' AS DateTime), CAST(N'2020-12-31T22:43:28.000' AS DateTime), N'1', N'100')
GO
INSERT [dbo].[ResepsiyonGirisi] ([kullaniciAdi], [sifre]) VALUES (N'          ', N'          ')
INSERT [dbo].[ResepsiyonGirisi] ([kullaniciAdi], [sifre]) VALUES (N'hotel     ', N'hotel1234 ')
GO
