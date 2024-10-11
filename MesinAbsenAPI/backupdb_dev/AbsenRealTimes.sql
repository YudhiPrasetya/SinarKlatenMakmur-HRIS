/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : MesinAbsenDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:11:48
*/


-- ----------------------------
-- Table structure for AbsenRealTimes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AbsenRealTimes]') AND type IN ('U'))
	DROP TABLE [dbo].[AbsenRealTimes]
GO

CREATE TABLE [dbo].[AbsenRealTimes] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [NIK] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Nama] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Gender] bit  NULL,
  [GroupKerja] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tanggal] datetime2(7)  NULL,
  [IpMesin] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Port] int  NULL,
  [NoMesin] int  NULL
)
GO

ALTER TABLE [dbo].[AbsenRealTimes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AbsenRealTimes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AbsenRealTimes] ON
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'1', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-14 13:49:27.1960541', N'192.168.94.94', N'4037', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'2', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-14 16:51:00.7894864', N'192.168.94.94', N'4037', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'3', N'240410163', N'WAHYUNI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:06:52.5035068', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'4', N'240410163', N'WAHYUNI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:06:52.4995081', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'5', N'240410387', N'HARFIANA NUR ROHMAH', N'0', N'QC ENDLINE', N'2024-08-15 09:15:32.3956415', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'6', N'240410190', N'ALAMSYAH SANDI PRADANA', N'1', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:16:41.5196188', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'7', N'240410206', N'LUTFIYANA WIDYANINGRUM', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:16:50.2102543', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'8', N'240410206', N'LUTFIYANA WIDYANINGRUM', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:16:52.1285766', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'9', N'240410294', N'FAUZIA INTAN SHOFIANA', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 09:21:50.3384949', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'10', N'240410421', N'SRI LESTARI/PULUHAN', N'1', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 09:26:51.9019935', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'11', N'240410343', N'DENY KRISTYANA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 09:26:57.5498745', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'12', N'240410214', N'FITRIA PUTRI HASANNAH', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:31:39.7364755', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'13', N'240410214', N'FITRIA PUTRI HASANNAH', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:31:42.0572589', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'14', N'240410179', N'SRI LESTARI / JOGOSETRAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:43:21.2048653', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'15', N'240410179', N'SRI LESTARI / JOGOSETRAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:43:23.4258170', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'16', N'240410179', N'SRI LESTARI / JOGOSETRAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:43:25.3998762', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'17', N'240410162', N'MARYANI', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 09:50:36.1597957', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'18', N'240410162', N'MARYANI', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 09:50:39.0370577', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'19', N'240410193', N'SUTRIYANI', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 09:57:20.9765921', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'20', N'240410158', N'MARETHA DWI WARDIYANTI', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 09:59:31.9173370', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'21', N'240410068', N'KHANA RURY ANDARIESTA', N'0', N'QC IN LINE', N'2024-08-15 09:59:42.1455444', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'22', N'240410068', N'KHANA RURY ANDARIESTA', N'0', N'QC IN LINE', N'2024-08-15 09:59:44.5831123', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'23', N'240410151', N'DEWI SUSANTI', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 09:59:59.7852304', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'24', N'240410152', N'INDAH WINARNI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 10:00:06.9861848', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'25', N'240410132', N'RUJIATI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 10:00:39.2577842', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'26', N'240410461', N'WANANG SETIAWAN', N'1', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:01:33.4901309', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'27', N'240410322', N'NINA NURJANAH', N'0', N'QC ENDLINE', N'2024-08-15 10:01:42.5816104', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'28', N'240410141', N'DWI ATMOJO', N'1', N'DRIVER', N'2024-08-15 10:05:22.5071759', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'29', N'240410141', N'DWI ATMOJO', N'1', N'DRIVER', N'2024-08-15 10:05:24.3721037', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'30', N'240410188', N'YESI WULANDARI', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 10:06:26.3211227', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'31', N'240410290', N'SATRIA DWI PRASETYO', N'1', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:07:14.1408534', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'32', N'240410290', N'SATRIA DWI PRASETYO', N'1', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:07:16.3533196', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'33', N'240410157', N'SURANI', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 10:07:29.5953499', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'34', N'240410157', N'SURANI', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 10:07:32.9437187', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'35', N'240410318', N'SASONGKO FEBRIAN NUGROHO', N'1', N'SHIFT 1 LINE DIKA', N'2024-08-15 10:13:16.1286764', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'36', N'240410318', N'SASONGKO FEBRIAN NUGROHO', N'1', N'SHIFT 1 LINE DIKA', N'2024-08-15 10:13:17.8026778', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'37', N'240410076', N'AGUS KRIS SUGIYANTO', N'1', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:14:10.8648423', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'38', N'240410415', N'DINA HARJANTI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-15 10:15:56.2006569', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'39', N'240410328', N'MUSLIHATUN HASANAH', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 10:17:08.6552434', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'40', N'240410328', N'MUSLIHATUN HASANAH', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 10:17:10.8911451', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'41', N'240410131', N'DANANG SUPRIYANTO', N'1', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 10:18:57.1731098', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'42', N'240410177', N'TITIK SETYOWATI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 10:19:02.5899827', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'43', N'240410153', N'IGNASIA FITRIA', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:19:22.1213141', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'44', N'240410153', N'IGNASIA FITRIA', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:19:23.5823849', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'45', N'240410198', N'SUPRAPTI / JOMBOR', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 10:19:29.6991764', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'46', N'240410043', N'DHIMAS ARIO WIBOWO', N'1', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:24:00.4674677', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'47', N'240410043', N'DHIMAS ARIO WIBOWO', N'1', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:24:02.8942885', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'48', N'240410186', N'AULIA LISTYANI', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:25:15.6962161', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'49', N'240410351', N'NOVIANA LUTFI NUR FADILLA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:25:19.6184820', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'50', N'240410351', N'NOVIANA LUTFI NUR FADILLA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 10:25:20.9775883', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'51', N'240410358', N'RISTIANI', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:25:29.6889423', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'52', N'240410358', N'RISTIANI', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:25:31.6741198', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'53', N'240410467', N'SUGIANTORO', N'1', N'SHIFT 1 LINE DIKA', N'2024-08-15 10:26:53.4751917', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'54', N'240410170', N'TRI RETNO ASIH', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 10:29:42.3291243', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'55', N'240410329', N'ELVINA CALLISTA PUTRI', N'0', N'SECURITY WANITA', N'2024-08-15 10:49:22.0655229', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'56', N'240410329', N'ELVINA CALLISTA PUTRI', N'0', N'SECURITY WANITA', N'2024-08-15 10:49:23.7800907', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'57', N'240410302', N'ARIZAL ROY ALBANA', N'1', N'SHIFT 1 LINE SUTARWI', N'2024-08-15 16:39:04.4263988', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'58', N'240410331', N'NUR SARIFAH', N'0', N'QC ENDLINE', N'2024-08-15 16:40:50.5903865', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'59', N'240410407', N'KARINA DWI HARTATI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:40:59.6515308', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'60', N'240410407', N'KARINA DWI HARTATI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:41:02.7660553', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'61', N'240410084', N'RATMI', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:41:05.3175619', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'62', N'240410084', N'RATMI', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:41:07.5214717', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'63', N'240410199', N'LASMINI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-15 16:41:23.3585255', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'64', N'240410525', N'UMI NURHAYATI', N'0', N'STAFF', N'2024-08-15 16:41:48.8138202', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'65', N'240410525', N'UMI NURHAYATI', N'0', N'STAFF', N'2024-08-15 16:41:54.3168585', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'66', N'240410269', N'AJI RAHMAD RAMADHAN', N'1', N'SHIFT 1 LINE KAMARI', N'2024-08-15 16:41:59.2342464', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'67', N'240410525', N'UMI NURHAYATI', N'0', N'STAFF', N'2024-08-15 16:41:59.4904873', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'68', N'240410479', N'KRISTANTI ERMASARI', N'0', N'STAFF', N'2024-08-15 16:42:05.7098904', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'69', N'240410479', N'KRISTANTI ERMASARI', N'0', N'STAFF', N'2024-08-15 16:42:06.4128901', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'70', N'240410525', N'UMI NURHAYATI', N'0', N'STAFF', N'2024-08-15 16:42:07.8538926', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'71', N'240410413', N'HENI PURNIAWAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-08-15 16:42:58.8615641', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'72', N'240410231', N'IIS SETYANI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 16:44:36.6461477', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'73', N'240410231', N'IIS SETYANI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 16:44:38.6203470', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'74', N'240410416', N'AGUSTINA IKA PANDU DEWANTI', N'0', N'QC IN LINE', N'2024-08-15 16:44:44.1522480', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'75', N'240410572', N'RISKY DEWI APRILAWATI', N'0', N'STAFF', N'2024-08-15 16:44:51.9201965', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'76', N'240410572', N'RISKY DEWI APRILAWATI', N'0', N'STAFF', N'2024-08-15 16:44:53.6037478', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'77', N'240410245', N'BIMANTARA SAPUTRA', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:45:30.0714838', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'78', N'240410257', N'DESI APRILIANI', N'0', N'SHIFT 1 LINE NUR', N'2024-08-15 16:45:57.0870930', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'79', N'240410257', N'DESI APRILIANI', N'0', N'SHIFT 1 LINE NUR', N'2024-08-15 16:45:59.0388197', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'80', N'240410211', N'SAMINEM', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:46:01.9050425', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'81', N'240410211', N'SAMINEM', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:46:04.6618973', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'82', N'240410192', N'TRI HANDAYANINGSIH', N'0', N'SHIFT 1 LINE SUTARWI', N'2024-08-15 16:46:21.2477620', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'83', N'240410192', N'TRI HANDAYANINGSIH', N'0', N'SHIFT 1 LINE SUTARWI', N'2024-08-15 16:46:23.5970832', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'84', N'240410163', N'WAHYUNI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:47:30.7788056', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'85', N'240410163', N'WAHYUNI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:47:33.2102665', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'86', N'240410506', N'AGUSTINUS HARY CAHYONO', N'1', N'STAFF', N'2024-08-15 16:47:36.4469377', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'87', N'240410335', N'JANEVA REVI MARISKA', N'0', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 16:47:46.6177080', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'88', N'240410081', N'HARSINI', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 16:47:59.8748359', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'89', N'240410244', N'DWI SANTOSO', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:48:03.8039243', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'90', N'240410244', N'DWI SANTOSO', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:48:06.0789691', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'91', N'240410213', N'SUPATMI/JATISARI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 16:48:12.5791063', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'92', N'240410213', N'SUPATMI/JATISARI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 16:48:14.9927882', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'93', N'240410138', N'SRI WAHYUNI / CAWAS', N'0', N'QC ENDLINE', N'2024-08-15 16:48:19.6824360', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'94', N'240410387', N'HARFIANA NUR ROHMAH', N'0', N'QC ENDLINE', N'2024-08-15 16:48:43.1112473', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'95', N'240410091', N'SURYANTI /TEGAL REJO ', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:49:02.1843801', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'96', N'240410203', N'AYU CAHYATI', N'0', N'SHIFT 1 LINE SUTARWI', N'2024-08-15 16:49:12.5575839', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'97', N'240410542', N'AGUNAWAN', N'1', N'STAFF', N'2024-08-15 16:49:21.4760425', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'98', N'240410175', N'PANGESTI WIDANING RINA', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:50:54.7042122', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'99', N'240410451', N'RESTU NUGROHO', N'1', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:51:01.2162106', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'100', N'240410023', N'VENDY HERMAWAN', N'1', N'SHIFT 1 LINE SUGIYANTI 1', N'2024-08-15 16:51:03.7634175', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'101', N'240410289', N'WINARNI', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:51:14.1463530', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'102', N'240410289', N'WINARNI', N'0', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:51:16.8357790', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'103', N'240410245', N'BIMANTARA SAPUTRA', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:51:28.1043459', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'104', N'240410245', N'BIMANTARA SAPUTRA', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:51:30.1052983', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'105', N'240410396', N'AMIR SOLIKIN', N'1', N'GENERAL MAINTENANCE', N'2024-08-15 16:51:54.0906603', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'106', N'240410396', N'AMIR SOLIKIN', N'1', N'GENERAL MAINTENANCE', N'2024-08-15 16:51:55.3799145', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'107', N'240410107', N'APPRILLIYA ZUDO WICAKSONO', N'1', N'SHIFT 1 LINE ANNA', N'2024-08-15 16:52:01.4672663', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'108', N'240410047', N'ALYA RAMADHANI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:52:29.2484094', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'109', N'240410378', N'DEWI MEILANI UTAMI', N'0', N'SHIFT 1 LINE DIKA', N'2024-08-15 16:52:33.4313728', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'110', N'240410180', N'SRI WINARSIH', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:52:41.7584176', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'111', N'240410180', N'SRI WINARSIH', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 16:52:44.1049516', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'112', N'240410368', N'ANAS TASYA CINTYA AGUSTINA', N'0', N'SHIFT 1 LINE NUR', N'2024-08-15 16:53:03.0993692', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'113', N'240510030', N'NOVI YANTI NUR RAHAYU', N'0', N'PACKING UNDERWEAR', N'2024-08-15 16:53:09.6875326', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'114', N'240510030', N'NOVI YANTI NUR RAHAYU', N'0', N'PACKING UNDERWEAR', N'2024-08-15 16:53:12.3288080', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'115', N'240410246', N'HARRIS WIDI PRADANA', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:53:42.1303161', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'116', N'240410246', N'HARRIS WIDI PRADANA', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 16:53:44.3734569', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'117', N'240410182', N'VIKA AL FITRIA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-15 16:56:18.9853706', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'118', N'240410418', N'WINDARSIH', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 16:57:21.6950891', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'119', N'240410418', N'WINDARSIH', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 16:57:24.4734240', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'120', N'240410418', N'WINDARSIH', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-15 16:57:27.1774575', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'121', N'240410133', N'SRI WIJI', N'0', N'SHIFT 1 LINE ARI TANTRI', N'2024-08-15 17:02:33.7332239', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'122', N'240410571', N'SURYANI', N'0', N'STAFF', N'2024-08-15 17:06:20.6736888', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'123', N'240510015', N'ADIK ARIFIANI KHASANAH', N'0', N'SHIFT 1 LINE NUR', N'2024-08-15 17:07:31.5090184', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'124', N'240410104', N'JUMINTEN', N'0', N'SHIFT 1 LINE PIPIT', N'2024-08-15 17:10:09.7066554', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'125', N'240410104', N'JUMINTEN', N'0', N'SHIFT 1 LINE PIPIT', N'2024-08-15 17:10:13.9939875', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'126', N'240410503', N'ISWANTO', N'1', N'STAFF', N'2024-08-15 17:12:18.1547418', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'127', N'240410503', N'ISWANTO', N'1', N'STAFF', N'2024-08-15 17:12:20.6186286', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'128', N'240410515', N'ERIQ RAJANI', N'1', N'STAFF', N'2024-08-15 17:12:32.9488385', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'129', N'240410486', N'KAMARI', N'1', N'STAFF', N'2024-08-15 17:13:14.2842126', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'130', N'240410312', N'BASUKI', N'1', N'SHIFT 1 LINE NUR', N'2024-08-15 17:13:47.2924476', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'131', N'240410481', N'SUBAGYO', N'1', N'STAFF', N'2024-08-15 17:14:23.9005483', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'132', N'240410481', N'SUBAGYO', N'1', N'STAFF', N'2024-08-15 17:14:27.9693661', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'256', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-23 16:35:57.8259246', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'257', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:36:01.0777884', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'258', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-23 16:36:01.4577902', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'259', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:36:01.6877909', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'260', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-23 16:36:02.4897928', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'261', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-23 16:37:11.1796568', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'262', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:37:11.4018651', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'263', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-23 16:37:11.6158676', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'264', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:37:11.8188635', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'265', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-23 16:37:12.0534787', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'266', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-23 16:38:09.6890862', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'267', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:38:11.9811304', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'268', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-23 16:38:13.9925738', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'269', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:38:15.0419936', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'270', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-23 16:38:16.0046019', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'271', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-23 16:38:43.7298932', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'272', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:38:43.8958800', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'273', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-23 16:38:44.0798760', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'274', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-23 16:38:44.2781587', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'275', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-23 16:38:44.5277647', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'276', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 00:44:54.5049395', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'277', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:44:55.5764885', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'278', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 00:44:55.9864851', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'279', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:44:56.1706076', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'280', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 00:44:57.4965439', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'281', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 00:45:51.0681683', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'282', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:45:51.3141676', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'283', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 00:45:51.5346086', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'284', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:45:51.7551291', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'285', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 00:45:51.9535858', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'286', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 00:47:31.9456258', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'287', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:47:32.1527748', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'288', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 00:47:32.3767728', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'289', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 00:47:32.5919504', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'290', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 00:47:32.7669465', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'291', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 10:01:48.4903490', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'292', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:01:49.7943518', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'293', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 10:01:50.2593557', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'294', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:01:50.5073573', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'295', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 10:01:52.1963556', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'296', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 10:30:38.4180542', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'297', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:30:40.5931058', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'298', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 10:37:52.3637524', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'299', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:37:55.7563986', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'300', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 10:37:56.2143965', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'301', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:37:56.5063949', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'302', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 10:37:57.3213946', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'303', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 10:38:41.9843827', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'304', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:38:42.2033830', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'305', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 10:38:42.4063803', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'306', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 10:38:42.6033852', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'307', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 10:38:42.8193866', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'308', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 16:41:18.8245700', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'309', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 16:41:20.0695737', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'310', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 16:41:20.5355720', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'311', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 16:41:20.8175755', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'312', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 16:41:21.8284119', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'313', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:42:32.2888407', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'314', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:42:32.5053125', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'315', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:42:33.0261974', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'316', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:42:33.4422008', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'317', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:42:33.6601986', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'318', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:45:37.7876033', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'319', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:45:37.9826056', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'320', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:45:38.1786046', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'321', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:45:38.3878298', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'322', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:45:38.6009948', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'323', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:50:26.5759030', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'324', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:50:27.7647237', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'325', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:50:28.1677274', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'326', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:50:29.3257273', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'327', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:50:30.3008438', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'328', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:53:04.2396014', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'329', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:53:06.4083331', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'330', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:53:07.4821570', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'331', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:53:09.5193311', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'332', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:53:10.5109169', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'333', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:54:04.5666595', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'334', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:54:04.8380577', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'335', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:54:05.0560452', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'336', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:54:05.2900472', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'337', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:54:05.5644068', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'338', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:55:34.8458114', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'339', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:55:37.7301409', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'340', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:55:38.1271437', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'341', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:55:38.8721424', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'342', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:55:39.9841415', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'343', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:56:34.3549909', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'344', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:56:34.5989892', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'345', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:56:34.8479951', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'346', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:56:35.0818708', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'347', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:56:35.3086962', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'348', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:58:39.9278005', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'349', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:58:42.9589178', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'350', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:58:43.3709231', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'351', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:58:44.1989226', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'352', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:58:45.2475423', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'353', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:59:44.8257486', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'354', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 19:00:38.3078038', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'355', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 19:06:15.4126137', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'356', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 19:06:18.7751708', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'357', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 19:06:19.2211728', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'358', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 19:06:20.5511856', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'359', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 19:06:21.5781156', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'360', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 18:20:38.0448212', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'361', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:20:41.7096405', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'362', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 18:20:42.1670655', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'363', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 18:20:42.3986407', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'364', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 18:20:43.4940005', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'365', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 20:30:54.4261179', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'366', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 20:30:59.6329777', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'367', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 20:31:00.1289769', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'368', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 20:31:01.1879577', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'369', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 20:31:02.1217416', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'370', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-24 20:31:40.9348410', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'371', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 20:31:43.1620773', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'372', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-24 20:31:44.1427636', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'373', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-24 20:31:45.2041185', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'374', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-24 20:31:47.3160265', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'375', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-27 11:43:35.5527455', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'376', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-27 11:43:36.9784230', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'377', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-27 11:43:37.4554221', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'378', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-27 11:43:37.6780236', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'379', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-27 11:43:37.9870195', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'380', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-27 11:47:03.8621969', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'381', N'240410020', N'LEGIYEM', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-27 11:47:07.1522309', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'382', N'240410021', N'ENDANG SRI SUSILAWATI', N'0', N'SHIFT 1 LINE WENI', N'2024-08-27 11:47:07.4802322', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'383', N'240410022', N'SRI HARYANTI/DOWO', N'0', N'SHIFT 1 LINE KAMARI', N'2024-08-27 11:47:07.6842353', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'384', N'240410027', N'HARI MURTI', N'0', N'QC ENDLINE', N'2024-08-27 11:47:08.7543239', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'385', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-26 09:16:18.0806019', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'386', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-26 09:25:36.3227195', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'387', N'240510027', N'RENDI NUR ARIFIN', N'0', N'SHIFT 1 LINE DIKA', N'2024-10-02 16:15:18.6111162', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'388', N'240510027', N'RENDI NUR ARIFIN', N'0', N'SHIFT 1 LINE DIKA', N'2024-10-02 16:15:18.6251165', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'389', N'240410351', N'NOVIANA LUTFI NUR FADILLA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-10-02 16:15:21.5761172', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'390', N'240410179', N'SRI LESTARI / JOGOSETRAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-10-02 16:15:22.1841178', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'391', N'240410351', N'NOVIANA LUTFI NUR FADILLA', N'0', N'SHIFT 1 LINE KAMARI', N'2024-10-02 16:15:23.8521184', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'392', N'240410179', N'SRI LESTARI / JOGOSETRAN', N'0', N'SHIFT 1 LINE ENDANG 2', N'2024-10-02 16:15:25.1171234', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'393', N'240510037', N'BASUKI WARDOYO', N'0', N'CLEANING SERVICE / HARIAN', N'2024-10-02 16:15:25.4611156', N'192.168.2.83', N'4370', N'6')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'394', N'240410341', N'SABILA GUSTINA', N'0', N'STB / PREPARATION', N'2024-10-02 16:15:55.5475356', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'395', N'240410218', N'ANIK ERNAWATI', N'0', N'PADPRINT', N'2024-10-02 16:15:55.2365502', N'192.168.2.84', N'4370', N'7')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'396', N'240410341', N'SABILA GUSTINA', N'0', N'STB / PREPARATION', N'2024-10-02 16:15:55.7065357', N'192.168.2.85', N'4370', N'5')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'397', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-03 10:39:55.6781343', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'398', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-03 10:42:42.2015779', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'399', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-03 10:43:12.6535266', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'400', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-03 10:45:01.6448488', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'401', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-03 10:48:50.4907641', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'402', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 10:49:29.8601496', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'403', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 10:50:52.5263271', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'404', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 10:52:32.2339261', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'405', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 11:00:46.9027089', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'406', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 11:05:36.4139335', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'407', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 11:20:48.5291295', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'408', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 11:32:35.5943882', N'192.168.94.94', N'4370', N'3')
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'409', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-10-04 11:34:31.9072408', N'192.168.94.94', N'4370', N'3')
GO

SET IDENTITY_INSERT [dbo].[AbsenRealTimes] OFF
GO


-- ----------------------------
-- Auto increment value for AbsenRealTimes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AbsenRealTimes]', RESEED, 409)
GO


-- ----------------------------
-- Primary Key structure for table AbsenRealTimes
-- ----------------------------
ALTER TABLE [dbo].[AbsenRealTimes] ADD CONSTRAINT [PK__AbsenRea__3214EC0743AA6882] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

