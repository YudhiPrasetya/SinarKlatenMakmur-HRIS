/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : LupaAbsenDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:11:03
*/


-- ----------------------------
-- Table structure for LupaAbsens
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LupaAbsens]') AND type IN ('U'))
	DROP TABLE [dbo].[LupaAbsens]
GO

CREATE TABLE [dbo].[LupaAbsens] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Tanggal] datetime2(7)  NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NamaKaryawan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Absen] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Jam] time(7)  NULL,
  [Keterangan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedBy] int  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [UpdatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [GrupKerja] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL
)
GO

ALTER TABLE [dbo].[LupaAbsens] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LupaAbsens
-- ----------------------------
SET IDENTITY_INSERT [dbo].[LupaAbsens] ON
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'1', N'2023-11-17 00:00:00.0000000', N'722121716', N'NAYLA PUTRI AULIA', N'Pulang', N'16:32:31.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/ADMIN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'2', N'2023-11-29 00:00:00.0000000', N'722040804', N'KETTY PUTRI ANGGORO WATI', N'Pulang', N'16:28:23.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/CUTTING')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'3', N'2023-11-17 00:00:00.0000000', N'722040873', N'TUTIK LESTARI', N'Pulang', N'16:44:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/CUTTING')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'4', N'2023-11-23 00:00:00.0000000', N'722091639', N'FITRI HANDAYANI', N'Pulang', N'16:23:20.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/CUTTING')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'5', N'2023-11-09 00:00:00.0000000', N'722041311', N'FELIX ALFIAN SANJAYA', N'Pulang', N'16:20:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/DRIVER')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'6', N'2023-11-15 00:00:00.0000000', N'722041311', N'FELIX ALFIAN SANJAYA', N'Pulang', N'16:28:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/DRIVER')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'7', N'2023-11-22 00:00:00.0000000', N'722040697', N'RIVAN ANDI SAPUTRO', N'Pulang', N'16:27:44.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'8', N'2023-11-16 00:00:00.0000000', N'722040797', N'FATAH UL ALIM', N'Pulang', N'16:19:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'9', N'2023-11-17 00:00:00.0000000', N'722040890', N'SRI SUPARTINI', N'Pulang', N'16:31:15.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'10', N'2023-11-06 00:00:00.0000000', N'722040894', N'SUPRAPTI / JOMBOR', N'Pulang', N'16:24:36.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'11', N'2023-11-08 00:00:00.0000000', N'722041117', N'WINARNI', N'Pulang', N'16:29:22.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'12', N'2023-11-17 00:00:00.0000000', N'722041117', N'WINARNI', N'Pulang', N'16:41:58.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'13', N'2023-11-30 00:00:00.0000000', N'722041117', N'WINARNI', N'Pulang', N'16:20:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'14', N'2023-11-07 00:00:00.0000000', N'719090347', N'LEGIYEM', N'Pulang', N'16:28:21.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'15', N'2023-11-24 00:00:00.0000000', N'721100595', N'NAUFAL PRADIPA SETYA LAKSANA', N'Pulang', N'16:30:29.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'16', N'2023-11-03 00:00:00.0000000', N'722040817', N'SULTONIYAH', N'Pulang', N'16:40:27.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'17', N'2023-11-20 00:00:00.0000000', N'723031918', N'JOHAN MUSTOFA NURAINI', N'Pulang', N'16:16:03.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'18', N'2023-11-13 00:00:00.0000000', N'722040811', N'INDAH WINARNI', N'Pulang', N'16:29:03.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'19', N'2023-11-10 00:00:00.0000000', N'722040930', N'SUPATMI/JATISARI', N'Pulang', N'16:38:28.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'20', N'2023-11-06 00:00:00.0000000', N'723051961', N'WINDARSIH', N'Pulang', N'16:17:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'21', N'2023-11-06 00:00:00.0000000', N'723062014', N'ANTOK SUSILO', N'Pulang', N'16:15:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'22', N'2023-11-10 00:00:00.0000000', N'722040676', N'AGUNG SUMADYO', N'Pulang', N'16:39:58.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'23', N'2023-11-06 00:00:00.0000000', N'722040686', N'FITRI KURNIAWATI', N'Pulang', N'16:20:30.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'24', N'2023-11-01 00:00:00.0000000', N'722040776', N'DANANG SUPRIYANTO', N'Pulang', N'22:50:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'25', N'2023-11-29 00:00:00.0000000', N'722040956', N'IIS SETYANI', N'Pulang', N'16:26:57.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'26', N'2023-11-03 00:00:00.0000000', N'723051981', N'YUNITA ISMAWATI', N'Pulang', N'16:31:09.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'27', N'2023-11-06 00:00:00.0000000', N'723051981', N'YUNITA ISMAWATI', N'Pulang', N'16:21:57.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'28', N'2023-11-08 00:00:00.0000000', N'723051981', N'YUNITA ISMAWATI', N'Pulang', N'16:28:43.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'29', N'2023-11-06 00:00:00.0000000', N'719090364', N'VENDY HERMAWAN', N'Pulang', N'16:24:08.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KRISTINA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'30', N'2023-11-13 00:00:00.0000000', N'722030671', N'DEFI KURNIAWATI', N'Pulang', N'16:22:58.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KRISTINA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'31', N'2023-11-17 00:00:00.0000000', N'722111695', N'SRI PUSPANINGSIH', N'Pulang', N'16:34:10.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE KRISTINA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'32', N'2023-11-10 00:00:00.0000000', N'721110645', N'ENDANG SUPARMI', N'Pulang', N'16:38:57.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'33', N'2023-11-09 00:00:00.0000000', N'722040731', N'INDRI ASTUTI', N'Pulang', N'16:15:56.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'34', N'2023-11-13 00:00:00.0000000', N'722040962', N'BAGUS BINTARA YUDHA ANDIKA', N'Pulang', N'16:16:58.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NUR')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'35', N'2023-11-13 00:00:00.0000000', N'722040981', N'SRI SUPADMI', N'Pulang', N'16:20:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NUR')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'36', N'2023-11-21 00:00:00.0000000', N'722040996', N'UMI LATIFAH', N'Pulang', N'16:22:14.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NUR')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'37', N'2023-11-13 00:00:00.0000000', N'722041000', N'DEVI MURDIANTI', N'Pulang', N'16:26:31.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NUR')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'38', N'2023-11-28 00:00:00.0000000', N'722041012', N'TIWIK SETYOWATI', N'Pulang', N'16:15:40.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE NUR')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'39', N'2023-11-13 00:00:00.0000000', N'722040744', N'SAPTAYANI', N'Pulang', N'16:26:08.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'40', N'2023-11-13 00:00:00.0000000', N'722081598', N'BAGAS SUPRIYANTO', N'Pulang', N'16:27:25.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'41', N'2023-11-15 00:00:00.0000000', N'722081598', N'BAGAS SUPRIYANTO', N'Pulang', N'16:28:59.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'42', N'2023-11-21 00:00:00.0000000', N'722081598', N'BAGAS SUPRIYANTO', N'Pulang', N'16:17:16.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'43', N'2023-11-14 00:00:00.0000000', N'722041005', N'MUCHLIS NUR ARIFIN', N'Pulang', N'16:18:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'44', N'2023-11-15 00:00:00.0000000', N'722041005', N'MUCHLIS NUR ARIFIN', N'Pulang', N'16:22:50.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'45', N'2023-11-16 00:00:00.0000000', N'722041005', N'MUCHLIS NUR ARIFIN', N'Pulang', N'16:29:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'46', N'2023-11-27 00:00:00.0000000', N'722041005', N'MUCHLIS NUR ARIFIN', N'Pulang', N'16:24:50.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'47', N'2023-11-20 00:00:00.0000000', N'722040782', N'WARTI', N'Pulang', N'16:18:07.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/LINE WENI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'48', N'2023-11-28 00:00:00.0000000', N'723011852', N'DANANG ADI PRABOWO', N'Pulang', N'16:18:08.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/PREPARATION')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'49', N'2023-11-14 00:00:00.0000000', N'721060583', N'SRI RAHAYU PURWANINGSIH', N'Pulang', N'17:22:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC JENI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'50', N'2023-11-06 00:00:00.0000000', N'722040841', N'DWI ROHMATUN', N'Pulang', N'16:26:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC JENI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'51', N'2023-11-07 00:00:00.0000000', N'722101666', N'CISILIA ANTRISKA FRENDY OLIVIANTI', N'Pulang', N'16:16:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC JENI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'52', N'2023-11-08 00:00:00.0000000', N'723021868', N'PINTO ADI PUTRA', N'Pulang', N'16:15:13.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC JENI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'53', N'2023-11-15 00:00:00.0000000', N'721060571', N'SAVIRA NURUL APRILYANI', N'Pulang', N'16:22:45.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'54', N'2023-11-07 00:00:00.0000000', N'721110654', N'KHANA RURY ANDARIESTA', N'Pulang', N'16:28:56.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'55', N'2023-11-22 00:00:00.0000000', N'721110654', N'KHANA RURY ANDARIESTA', N'Pulang', N'14:37:22.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'56', N'2023-11-15 00:00:00.0000000', N'722040836', N'UMI KHOIROTIN', N'Pulang', N'16:20:19.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'57', N'2023-11-28 00:00:00.0000000', N'723052004', N'SRI PURWANTI', N'Pulang', N'16:22:20.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'58', N'2023-11-29 00:00:00.0000000', N'723052004', N'SRI PURWANTI', N'Pulang', N'16:29:35.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MINCU')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'59', N'2023-11-03 00:00:00.0000000', N'722061391', N'NINA NURJANAH', N'Pulang', N'16:41:28.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MUJI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'60', N'2023-11-08 00:00:00.0000000', N'723011784', N'RUDHI', N'Pulang', N'16:17:00.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MUJI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'61', N'2023-11-02 00:00:00.0000000', N'723021882', N'FAUZAN ABDUL FATTAH', N'Pulang', N'16:17:52.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/QC MUJI')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'62', N'2023-11-02 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'22:31:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'63', N'2023-11-03 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'22:28:42.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'64', N'2023-11-09 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'07:03:32.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'65', N'2023-11-10 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'22:25:42.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'66', N'2023-11-14 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'23:34:09.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'67', N'2023-11-17 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'22:23:42.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'68', N'2023-11-20 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'14:43:43.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'69', N'2023-11-22 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'23:16:45.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'70', N'2023-11-24 00:00:00.0000000', N'717120004', N'DEDY NUGROHO ', N'Pulang', N'07:31:30.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/RESIGN')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'71', N'2023-11-03 00:00:00.0000000', N'719100397', N'WACHID ARIYANTO', N'Pulang', N'22:15:45.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'72', N'2023-11-10 00:00:00.0000000', N'719100397', N'WACHID ARIYANTO', N'Pulang', N'22:06:21.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'73', N'2023-11-17 00:00:00.0000000', N'719100397', N'WACHID ARIYANTO', N'Pulang', N'22:12:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'74', N'2023-11-06 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:27:32.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'75', N'2023-11-07 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'19:56:26.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'76', N'2023-11-12 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'23:00:39.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'77', N'2023-11-13 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:24:35.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'78', N'2023-11-14 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:26:51.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'79', N'2023-11-20 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:28:17.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'80', N'2023-11-21 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:21:22.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'81', N'2023-11-25 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'14:30:14.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'82', N'2023-11-27 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'21:59:49.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'83', N'2023-11-28 00:00:00.0000000', N'722030672', N'AHMAD ROKHIM', N'Pulang', N'22:26:09.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'84', N'2023-11-05 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'22:25:59.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'85', N'2023-11-11 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'22:26:05.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'86', N'2023-11-12 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'07:43:01.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'87', N'2023-11-18 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'22:22:32.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'88', N'2023-11-25 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'21:51:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'89', N'2023-11-26 00:00:00.0000000', N'722030673', N'IRWAN SULISTYANTO', N'Pulang', N'21:53:12.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'90', N'2023-11-01 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:19:16.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'91', N'2023-11-02 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'10:27:42.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'92', N'2023-11-05 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'14:32:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'93', N'2023-11-08 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:05:07.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'94', N'2023-11-09 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:31:27.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'95', N'2023-11-15 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:21:28.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'96', N'2023-11-16 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:17:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'97', N'2023-11-21 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'23:14:11.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'98', N'2023-11-22 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:19:59.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'99', N'2023-11-23 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'07:31:34.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'100', N'2023-11-26 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'14:37:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'101', N'2023-11-29 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:20:39.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'102', N'2023-11-30 00:00:00.0000000', N'722030674', N'DWI FAJAR NUGROHO', N'Pulang', N'22:21:57.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'103', N'2023-11-04 00:00:00.0000000', N'722040698', N'ROCHMAD SRI NUGROHO', N'Pulang', N'23:16:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'104', N'2023-11-05 00:00:00.0000000', N'722040698', N'ROCHMAD SRI NUGROHO', N'Pulang', N'22:50:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'105', N'2023-11-12 00:00:00.0000000', N'722040698', N'ROCHMAD SRI NUGROHO', N'Pulang', N'22:08:36.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'106', N'2023-11-19 00:00:00.0000000', N'722040698', N'ROCHMAD SRI NUGROHO', N'Pulang', N'22:25:14.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'107', N'2023-11-26 00:00:00.0000000', N'722040698', N'ROCHMAD SRI NUGROHO', N'Pulang', N'22:21:07.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'108', N'2023-11-06 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'22:32:13.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'109', N'2023-11-11 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'23:07:27.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'110', N'2023-11-12 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'23:02:47.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'111', N'2023-11-13 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'22:43:00.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'112', N'2023-11-20 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'07:35:12.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'113', N'2023-11-27 00:00:00.0000000', N'722040707', N'SUTANTO', N'Pulang', N'07:30:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'114', N'2023-11-04 00:00:00.0000000', N'722040717', N'SIGIT PURNOMO', N'Pulang', N'22:21:19.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'115', N'2023-11-11 00:00:00.0000000', N'722040717', N'SIGIT PURNOMO', N'Pulang', N'22:24:09.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'116', N'2023-11-18 00:00:00.0000000', N'722040717', N'SIGIT PURNOMO', N'Pulang', N'22:22:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'117', N'2023-11-25 00:00:00.0000000', N'722040717', N'SIGIT PURNOMO', N'Pulang', N'22:27:40.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'118', N'2023-11-01 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:23:19.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'119', N'2023-11-07 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:30:29.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'120', N'2023-11-08 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:28:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'121', N'2023-11-12 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'14:33:42.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'122', N'2023-11-14 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:29:44.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'123', N'2023-11-15 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:27:28.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'124', N'2023-11-21 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:28:14.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'125', N'2023-11-22 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'22:27:05.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'126', N'2023-11-27 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'23:10:11.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'127', N'2023-11-29 00:00:00.0000000', N'722040718', N'RAFI RAJU SANJAYA', N'Pulang', N'07:31:04.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SECURITY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'128', N'2023-11-13 00:00:00.0000000', N'720020415', N'SRI MURTINING', N'Pulang', N'14:25:26.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'129', N'2023-11-28 00:00:00.0000000', N'720020415', N'SRI MURTINING', N'Pulang', N'18:46:02.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'130', N'2023-11-02 00:00:00.0000000', N'721100597', N'SUGENG RIYADI', N'Pulang', N'22:41:36.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'131', N'2023-11-13 00:00:00.0000000', N'721100597', N'SUGENG RIYADI', N'Pulang', N'14:24:54.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'132', N'2023-11-13 00:00:00.0000000', N'722040874', N'ALAMSYAH SANDI PRADANA', N'Pulang', N'14:24:52.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'133', N'2023-11-10 00:00:00.0000000', N'723051972', N'SRI WAHYUNI / KLEPU', N'Pulang', N'16:42:38.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/SNAP')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'134', N'2023-11-01 00:00:00.0000000', N'722040722', N'SUTARWI', N'Pulang', N'16:21:03.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'135', N'2023-11-13 00:00:00.0000000', N'822041243', N'OKTAVIANI PUTRI UTAMI', N'Pulang', N'16:24:05.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'136', N'2023-11-01 00:00:00.0000000', N'822041251', N'CANDRA PUTRI WIYANTI', N'Pulang', N'16:10:17.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'137', N'2023-11-08 00:00:00.0000000', N'822041254', N'DIYAH MURTININGRUM', N'Pulang', N'16:17:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'138', N'2023-11-13 00:00:00.0000000', N'822041254', N'DIYAH MURTININGRUM', N'Pulang', N'16:22:35.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'139', N'2023-11-20 00:00:00.0000000', N'822041255', N'PIPIT DWI RAHAYU', N'Pulang', N'16:18:51.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'140', N'2023-11-08 00:00:00.0000000', N'822041256', N'ISWANTO', N'Pulang', N'17:42:37.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'141', N'2023-11-10 00:00:00.0000000', N'822041256', N'ISWANTO', N'Pulang', N'17:17:25.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'142', N'2023-11-02 00:00:00.0000000', N'822041265', N'MARDIANA SILALAHI', N'Pulang', N'16:16:22.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'143', N'2023-11-08 00:00:00.0000000', N'822041265', N'MARDIANA SILALAHI', N'Pulang', N'16:15:47.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'144', N'2023-11-21 00:00:00.0000000', N'822041265', N'MARDIANA SILALAHI', N'Pulang', N'16:22:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'145', N'2023-11-28 00:00:00.0000000', N'822041282', N'FENTI WIDIA PRAMITA SARI', N'Pulang', N'16:26:50.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'146', N'2023-11-14 00:00:00.0000000', N'822041284', N'MEGAN FARADIKA', N'Pulang', N'16:26:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'147', N'2023-11-30 00:00:00.0000000', N'822041286', N'UMI NURHAYATI', N'Pulang', N'16:21:02.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'148', N'2023-11-13 00:00:00.0000000', N'822041287', N'NATALIA DAMAYANTI', N'Pulang', N'16:29:26.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'149', N'2023-11-29 00:00:00.0000000', N'822041288', N'YOHANNES INDRA DWINUGRAHA, S.T', N'Pulang', N'16:25:49.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'150', N'2023-11-16 00:00:00.0000000', N'822041289', N'NURWANTO', N'Pulang', N'16:23:16.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'151', N'2023-11-21 00:00:00.0000000', N'822041289', N'NURWANTO', N'Pulang', N'16:28:09.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'152', N'2023-11-07 00:00:00.0000000', N'822041291', N'ANDRE PUTRA KURNIAWAN', N'Pulang', N'17:05:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'153', N'2023-11-08 00:00:00.0000000', N'822041291', N'ANDRE PUTRA KURNIAWAN', N'Pulang', N'17:10:05.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'154', N'2023-11-10 00:00:00.0000000', N'822041291', N'ANDRE PUTRA KURNIAWAN', N'Pulang', N'17:59:39.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'155', N'2023-11-01 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:21:32.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'156', N'2023-11-02 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:23:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'157', N'2023-11-03 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:42:41.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'158', N'2023-11-07 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:18:24.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'159', N'2023-11-08 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:19:28.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'160', N'2023-11-09 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:28:53.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'161', N'2023-11-10 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:34:49.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'162', N'2023-11-15 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:19:46.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'163', N'2023-11-20 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:20:18.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'164', N'2023-11-21 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:15:34.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'165', N'2023-11-22 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:17:32.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'166', N'2023-11-24 00:00:00.0000000', N'822041293', N'SUGIARTO', N'Pulang', N'16:35:14.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'167', N'2023-11-07 00:00:00.0000000', N'822071509', N'OKMAWATI', N'Pulang', N'16:18:10.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'168', N'2023-11-09 00:00:00.0000000', N'822081535', N'WAHYU ADHIKA NUGRAHADI', N'Pulang', N'15:02:55.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'169', N'2023-11-17 00:00:00.0000000', N'822081535', N'WAHYU ADHIKA NUGRAHADI', N'Pulang', N'15:15:07.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'170', N'2023-11-24 00:00:00.0000000', N'822081535', N'WAHYU ADHIKA NUGRAHADI', N'Pulang', N'15:12:08.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'171', N'2023-11-21 00:00:00.0000000', N'822081552', N'PANGKI MARADONA', N'Pulang', N'17:14:08.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'172', N'2023-11-01 00:00:00.0000000', N'823031940', N'KANNADASAN SAMIAPPAN', N'Pulang', N'16:27:33.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'173', N'2023-11-06 00:00:00.0000000', N'823031940', N'KANNADASAN SAMIAPPAN', N'Pulang', N'16:22:20.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'174', N'2023-11-13 00:00:00.0000000', N'822041303', N'HENDRY LOVIANDRY, ST', N'Pulang', N'16:25:06.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'175', N'2023-11-17 00:00:00.0000000', N'822041303', N'HENDRY LOVIANDRY, ST', N'Pulang', N'16:33:20.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'176', N'2023-11-06 00:00:00.0000000', N'822041307', N'SITI ZUBAIDAH', N'Pulang', N'16:17:50.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'177', N'2023-11-22 00:00:00.0000000', N'722041166', N'VIRDAUS MUCHININ', N'Pulang', N'16:24:19.0000000', N'Lupa Absen Pulang', N'1', NULL, N'1', NULL, N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'185', N'2024-09-19 00:00:00.0000000', N'240410433', N'CANI ARIANI', N'Masuk', N'07:31:00.0000000', N'Lupa Absen Masuk', N'1', N'2024-09-24 00:00:00.0000000', N'1', N'2024-09-24 00:00:00.0000000', N'ADMIN INVENTORY')
GO

INSERT INTO [dbo].[LupaAbsens] ([Id], [Tanggal], [NIK], [NamaKaryawan], [Absen], [Jam], [Keterangan], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [GrupKerja]) VALUES (N'187', N'2024-09-12 00:00:00.0000000', N'240410433', N'CANI ARIANI', N'Masuk', N'07:19:00.0000000', N'Lupa Absen Masuk', N'1', N'2024-09-24 00:00:00.0000000', N'1', N'2024-09-24 00:00:00.0000000', N'ADMIN INVENTORY')
GO

SET IDENTITY_INSERT [dbo].[LupaAbsens] OFF
GO


-- ----------------------------
-- Auto increment value for LupaAbsens
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[LupaAbsens]', RESEED, 187)
GO


-- ----------------------------
-- Primary Key structure for table LupaAbsens
-- ----------------------------
ALTER TABLE [dbo].[LupaAbsens] ADD CONSTRAINT [PK_LupaAbsens] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

