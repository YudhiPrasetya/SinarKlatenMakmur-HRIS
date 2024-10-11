/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : KehadiranDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:10:34
*/


-- ----------------------------
-- Table structure for JadwalKehadirans
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JadwalKehadirans]') AND type IN ('U'))
	DROP TABLE [dbo].[JadwalKehadirans]
GO

CREATE TABLE [dbo].[JadwalKehadirans] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [NIK] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Nama] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Gender] bit  NULL,
  [GrupKerja] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [JadwalMasuk] datetime2(7)  NULL,
  [JadwalPulang] datetime2(7)  NULL,
  [JamMasuk] datetime2(7)  NULL,
  [JamPulang] datetime2(7)  NULL,
  [Terlambat] time(7)  NULL,
  [Keterangan] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LockedMasuk] bit  NULL,
  [LockedPulang] bit  NULL,
  [Shift] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Inisial_Shift] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [AlasanTerlambat] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Up] bit  NULL,
  [IdJadwalShiftKaryawan] int  NULL
)
GO

ALTER TABLE [dbo].[JadwalKehadirans] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of JadwalKehadirans
-- ----------------------------
SET IDENTITY_INSERT [dbo].[JadwalKehadirans] ON
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'117', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-01 07:30:00.0000000', N'2024-08-01 16:30:00.0000000', N'2024-08-01 07:22:12.0000000', N'2024-08-01 17:23:38.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'118', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-02 07:30:00.0000000', N'2024-08-02 16:30:00.0000000', N'2024-08-02 07:18:53.0000000', N'2024-08-02 17:07:53.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'119', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-05 07:30:00.0000000', N'2024-08-05 16:30:00.0000000', N'2024-08-05 07:18:52.0000000', NULL, N'00:00:00.0000000', NULL, N'1', NULL, N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'120', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-06 07:30:00.0000000', N'2024-08-06 16:30:00.0000000', N'2024-08-06 07:22:08.0000000', NULL, N'00:00:00.0000000', NULL, N'1', NULL, N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'121', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-07 07:30:00.0000000', N'2024-08-07 16:30:00.0000000', N'2024-08-07 07:21:02.0000000', N'2024-08-07 18:15:13.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'122', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-08 07:30:00.0000000', N'2024-08-08 16:30:00.0000000', N'2024-08-08 08:23:28.0000000', N'2024-08-08 18:03:18.0000000', N'00:53:28.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'123', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-09 07:30:00.0000000', N'2024-08-09 16:30:00.0000000', N'2024-08-09 07:18:35.0000000', N'2024-08-09 19:45:02.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'124', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-12 07:30:00.0000000', N'2024-08-12 16:30:00.0000000', N'2024-08-12 07:14:10.0000000', N'2024-08-12 17:16:49.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'125', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-13 07:30:00.0000000', N'2024-08-13 16:30:00.0000000', N'2024-08-13 07:21:40.0000000', N'2024-08-13 16:32:05.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'126', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-14 07:30:00.0000000', N'2024-08-14 16:30:00.0000000', N'2024-08-14 07:18:01.0000000', N'2024-08-14 16:28:03.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'127', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-15 07:30:00.0000000', N'2024-08-15 16:30:00.0000000', N'2024-08-15 07:17:32.0000000', N'2024-08-15 16:41:09.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'128', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-16 07:30:00.0000000', N'2024-08-16 16:30:00.0000000', N'2024-08-16 07:20:33.0000000', N'2024-08-16 16:54:16.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'129', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-19 07:30:00.0000000', N'2024-08-19 16:30:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'130', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-20 07:30:00.0000000', N'2024-08-20 16:30:00.0000000', N'2024-08-20 07:20:46.0000000', N'2024-08-20 17:05:34.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'131', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-21 07:30:00.0000000', N'2024-08-21 16:30:00.0000000', N'2024-08-21 07:27:37.0000000', NULL, N'00:00:00.0000000', NULL, N'1', NULL, N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'132', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-22 07:30:00.0000000', N'2024-08-22 16:30:00.0000000', N'2024-08-22 07:29:19.0000000', N'2024-08-22 16:30:09.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'133', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-23 07:30:00.0000000', N'2024-08-23 16:30:00.0000000', N'2024-08-23 07:33:03.0000000', N'2024-08-23 17:04:09.0000000', N'00:03:03.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'134', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-26 07:30:00.0000000', N'2024-08-26 16:30:00.0000000', N'2024-08-26 07:24:35.0000000', N'2024-08-26 16:23:07.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'135', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-27 07:30:00.0000000', N'2024-08-27 16:30:00.0000000', N'2024-08-27 07:23:42.0000000', N'2024-08-27 16:21:33.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'136', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-28 07:30:00.0000000', N'2024-08-28 16:30:00.0000000', N'2024-08-28 07:28:52.0000000', N'2024-08-28 16:43:23.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'137', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-29 07:30:00.0000000', N'2024-08-29 16:30:00.0000000', N'2024-08-29 07:30:08.0000000', N'2024-08-29 16:31:52.0000000', N'00:00:08.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'138', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-30 07:30:00.0000000', N'2024-08-30 16:30:00.0000000', N'2024-08-30 07:32:06.0000000', N'2024-08-30 17:01:30.0000000', N'00:02:06.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'139', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-03 00:00:00.0000000', N'2024-08-03 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'140', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-04 00:00:00.0000000', N'2024-08-04 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'141', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-10 00:00:00.0000000', N'2024-08-10 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'142', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-11 00:00:00.0000000', N'2024-08-11 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'143', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-17 00:00:00.0000000', N'2024-08-17 00:00:00.0000000', N'2024-08-17 07:33:31.0000000', NULL, N'07:33:31.0000000', NULL, N'1', NULL, N'Libur', N'L', NULL, N'Terlambat', N'1', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'144', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-18 00:00:00.0000000', N'2024-08-18 00:00:00.0000000', N'2024-08-18 08:00:21.0000000', N'2024-08-18 16:46:02.0000000', N'08:00:21.0000000', NULL, N'1', N'1', N'Libur', N'L', NULL, N'Terlambat', N'1', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'145', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-24 00:00:00.0000000', N'2024-08-24 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'146', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-25 00:00:00.0000000', N'2024-08-25 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'147', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-08-31 00:00:00.0000000', N'2024-08-31 00:00:00.0000000', NULL, NULL, NULL, NULL, NULL, NULL, N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'148', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-03 00:00:00.0000000', N'2024-08-03 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'149', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-04 00:00:00.0000000', N'2024-08-04 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'150', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-10 00:00:00.0000000', N'2024-08-10 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'151', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-11 00:00:00.0000000', N'2024-08-11 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'152', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-17 00:00:00.0000000', N'2024-08-17 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'153', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-18 00:00:00.0000000', N'2024-08-18 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'154', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-24 00:00:00.0000000', N'2024-08-24 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'155', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-25 00:00:00.0000000', N'2024-08-25 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'156', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-31 00:00:00.0000000', N'2024-08-31 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'157', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-01 07:30:00.0000000', N'2024-08-01 16:30:00.0000000', N'2024-08-01 07:35:44.0000000', N'2024-08-01 17:13:14.0000000', N'00:05:44.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'158', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-02 07:30:00.0000000', N'2024-08-02 16:30:00.0000000', N'2024-08-02 07:23:27.0000000', N'2024-08-02 17:13:25.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'159', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-05 07:30:00.0000000', N'2024-08-05 16:30:00.0000000', N'2024-08-05 07:49:17.0000000', N'2024-08-05 17:37:21.0000000', N'00:19:17.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'160', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-06 07:30:00.0000000', N'2024-08-06 16:30:00.0000000', N'2024-08-06 07:25:52.0000000', N'2024-08-06 17:45:05.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'161', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-07 07:30:00.0000000', N'2024-08-07 16:30:00.0000000', N'2024-08-07 07:42:18.0000000', N'2024-08-07 17:28:38.0000000', N'00:12:18.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'162', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-08 07:30:00.0000000', N'2024-08-08 16:30:00.0000000', N'2024-08-08 07:38:54.0000000', N'2024-08-08 17:21:37.0000000', N'00:08:54.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'163', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-09 07:30:00.0000000', N'2024-08-09 16:30:00.0000000', N'2024-08-09 07:16:14.0000000', N'2024-08-09 17:25:55.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'164', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-12 07:30:00.0000000', N'2024-08-12 16:30:00.0000000', N'2024-08-12 07:18:39.0000000', N'2024-08-12 17:35:45.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'165', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-13 07:30:00.0000000', N'2024-08-13 16:30:00.0000000', N'2024-08-13 07:31:31.0000000', N'2024-08-13 17:24:29.0000000', N'00:01:31.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'166', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-14 07:30:00.0000000', N'2024-08-14 16:30:00.0000000', N'2024-08-14 07:31:52.0000000', N'2024-08-14 17:31:21.0000000', N'00:01:52.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'167', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-15 07:30:00.0000000', N'2024-08-15 16:30:00.0000000', N'2024-08-15 07:10:23.0000000', NULL, N'00:00:00.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'168', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-16 07:30:00.0000000', N'2024-08-16 16:30:00.0000000', N'2024-08-16 07:12:33.0000000', NULL, N'00:00:00.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'169', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-19 07:30:00.0000000', N'2024-08-19 16:30:00.0000000', N'2024-08-19 07:26:25.0000000', NULL, N'00:00:00.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'170', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-20 07:30:00.0000000', N'2024-08-20 16:30:00.0000000', N'2024-08-20 07:19:58.0000000', N'2024-08-20 17:31:41.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'171', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-21 07:30:00.0000000', N'2024-08-21 16:30:00.0000000', N'2024-08-21 07:25:18.0000000', NULL, N'00:00:00.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'172', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-22 07:30:00.0000000', N'2024-08-22 16:30:00.0000000', N'2024-08-22 07:34:19.0000000', NULL, N'00:04:19.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'173', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-23 07:30:00.0000000', N'2024-08-23 16:30:00.0000000', N'2024-08-23 07:28:32.0000000', N'2024-08-23 17:35:24.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'174', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-26 07:30:00.0000000', N'2024-08-26 16:30:00.0000000', N'2024-08-26 07:40:34.0000000', N'2024-08-26 18:53:56.0000000', N'00:10:34.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'175', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-27 07:30:00.0000000', N'2024-08-27 16:30:00.0000000', N'2024-08-27 07:35:53.0000000', N'2024-08-27 17:14:30.0000000', N'00:05:53.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'176', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-28 07:30:00.0000000', N'2024-08-28 16:30:00.0000000', N'2024-08-28 07:33:22.0000000', NULL, N'00:03:22.0000000', NULL, N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'177', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-29 07:30:00.0000000', N'2024-08-29 16:30:00.0000000', N'2024-08-29 07:41:35.0000000', N'2024-08-29 17:02:38.0000000', N'00:11:35.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Terlambat', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'178', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-08-30 07:30:00.0000000', N'2024-08-30 16:30:00.0000000', N'2024-08-30 06:59:51.0000000', N'2024-08-30 17:27:48.0000000', N'00:00:00.0000000', NULL, N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, N'Tepat Waktu', N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'179', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-01 00:00:00.0000000', N'2024-09-01 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'180', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-07 00:00:00.0000000', N'2024-09-07 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'181', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-08 00:00:00.0000000', N'2024-09-08 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'182', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-14 00:00:00.0000000', N'2024-09-14 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'183', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-15 00:00:00.0000000', N'2024-09-15 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'184', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-21 00:00:00.0000000', N'2024-09-21 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'185', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-22 00:00:00.0000000', N'2024-09-22 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'186', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-28 00:00:00.0000000', N'2024-09-28 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'187', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-29 00:00:00.0000000', N'2024-09-29 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'188', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-02 07:30:00.0000000', N'2024-09-02 16:30:00.0000000', N'2024-09-02 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'189', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-03 07:30:00.0000000', N'2024-09-03 16:30:00.0000000', N'2024-09-03 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'190', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-04 07:30:00.0000000', N'2024-09-04 16:30:00.0000000', N'2024-09-04 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'191', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-05 07:30:00.0000000', N'2024-09-05 16:30:00.0000000', N'2024-09-05 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'192', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-06 07:30:00.0000000', N'2024-09-06 16:30:00.0000000', N'2024-09-06 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'193', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-09 07:30:00.0000000', N'2024-09-09 16:30:00.0000000', N'2024-09-09 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'194', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-10 07:30:00.0000000', N'2024-09-10 16:30:00.0000000', N'2024-09-10 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'195', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-11 07:30:00.0000000', N'2024-09-11 16:30:00.0000000', N'2024-09-11 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'196', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-12 07:30:00.0000000', N'2024-09-12 16:30:00.0000000', N'2024-09-12 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'197', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-13 07:30:00.0000000', N'2024-09-13 16:30:00.0000000', N'2024-09-13 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'198', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-16 07:30:00.0000000', N'2024-09-16 16:30:00.0000000', N'2024-09-16 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'199', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-17 07:30:00.0000000', N'2024-09-17 16:30:00.0000000', N'2024-09-17 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'200', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-18 07:30:00.0000000', N'2024-09-18 16:30:00.0000000', N'2024-09-18 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'201', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-19 07:30:00.0000000', N'2024-09-19 16:30:00.0000000', N'2024-09-19 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'202', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-20 07:30:00.0000000', N'2024-09-20 16:30:00.0000000', N'2024-09-20 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'203', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-23 07:30:00.0000000', N'2024-09-23 16:30:00.0000000', N'2024-09-23 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'204', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-24 07:30:00.0000000', N'2024-09-24 16:30:00.0000000', N'2024-09-24 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'205', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-25 07:30:00.0000000', N'2024-09-25 16:30:00.0000000', N'2024-09-25 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'206', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-26 07:30:00.0000000', N'2024-09-26 16:30:00.0000000', N'2024-09-26 07:26:51.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'207', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-27 07:30:00.0000000', N'2024-09-27 16:30:00.0000000', NULL, NULL, NULL, N'CUTI TAHUNAN', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'208', N'240410433', N'CANI ARIANI', N'0', N'ADMIN INVENTORY', N'2024-09-30 07:30:00.0000000', N'2024-09-30 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'209', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-01 00:00:00.0000000', N'2024-09-01 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'210', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-07 00:00:00.0000000', N'2024-09-07 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'211', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-08 00:00:00.0000000', N'2024-09-08 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'212', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-14 00:00:00.0000000', N'2024-09-14 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'213', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-15 00:00:00.0000000', N'2024-09-15 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'214', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-21 00:00:00.0000000', N'2024-09-21 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'215', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-22 00:00:00.0000000', N'2024-09-22 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'216', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-28 00:00:00.0000000', N'2024-09-28 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'217', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-29 00:00:00.0000000', N'2024-09-29 00:00:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Libur', N'L', NULL, NULL, N'0', N'16')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'218', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-02 07:30:00.0000000', N'2024-09-02 16:30:00.0000000', N'2024-09-02 07:44:44.0000000', N'2024-09-02 16:42:48.0000000', N'00:14:44.0000000', N'Terlambat', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'219', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-03 07:30:00.0000000', N'2024-09-03 16:30:00.0000000', N'2024-09-03 07:30:04.0000000', N'2024-09-03 16:41:10.0000000', N'00:00:04.0000000', N'Terlambat', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'220', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-04 07:30:00.0000000', N'2024-09-04 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'221', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-05 07:30:00.0000000', N'2024-09-05 16:30:00.0000000', N'2024-09-05 07:42:42.0000000', N'2024-09-05 16:45:36.0000000', N'00:12:42.0000000', N'Terlambat', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'222', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-06 07:30:00.0000000', N'2024-09-06 16:30:00.0000000', NULL, N'2024-09-06 20:13:18.0000000', NULL, NULL, N'0', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'223', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-09 07:30:00.0000000', N'2024-09-09 16:30:00.0000000', N'2024-09-09 07:29:26.0000000', NULL, N'00:00:00.0000000', N'Tepat Waktu', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'224', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-10 07:30:00.0000000', N'2024-09-10 16:30:00.0000000', NULL, N'2024-09-10 18:00:13.0000000', NULL, NULL, N'0', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'225', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-11 07:30:00.0000000', N'2024-09-11 16:30:00.0000000', N'2024-09-11 07:29:07.0000000', N'2024-09-11 17:34:38.0000000', N'00:00:00.0000000', N'Tepat Waktu', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'226', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-12 07:30:00.0000000', N'2024-09-12 16:30:00.0000000', N'2024-09-12 07:37:25.0000000', N'2024-09-12 17:23:59.0000000', N'00:07:25.0000000', N'Terlambat', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'227', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-13 07:30:00.0000000', N'2024-09-13 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'228', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-16 07:30:00.0000000', N'2024-09-16 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'229', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-17 07:30:00.0000000', N'2024-09-17 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'230', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-18 07:30:00.0000000', N'2024-09-18 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'231', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-19 07:30:00.0000000', N'2024-09-19 16:30:00.0000000', N'2024-09-19 07:49:35.0000000', N'2024-09-19 17:30:12.0000000', N'00:19:35.0000000', N'Terlambat', N'1', N'1', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'232', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-20 07:30:00.0000000', N'2024-09-20 16:30:00.0000000', N'2024-09-20 07:40:17.0000000', NULL, N'00:10:17.0000000', N'Terlambat', N'1', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'1', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'233', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-23 07:30:00.0000000', N'2024-09-23 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'234', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-24 07:30:00.0000000', N'2024-09-24 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'235', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-25 07:30:00.0000000', N'2024-09-25 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'236', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-26 07:30:00.0000000', N'2024-09-26 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'237', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-27 07:30:00.0000000', N'2024-09-27 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'238', N'240410552', N'YUDHI PRASETYA', N'0', N'STAFF', N'2024-09-30 07:30:00.0000000', N'2024-09-30 16:30:00.0000000', NULL, NULL, NULL, NULL, N'0', N'0', N'Shift 1 5 HK', N'P1', NULL, NULL, N'0', N'10')
GO

INSERT INTO [dbo].[JadwalKehadirans] ([Id], [NIK], [Nama], [Gender], [GrupKerja], [JadwalMasuk], [JadwalPulang], [JamMasuk], [JamPulang], [Terlambat], [Keterangan], [LockedMasuk], [LockedPulang], [Shift], [Inisial_Shift], [AlasanTerlambat], [Status], [Up], [IdJadwalShiftKaryawan]) VALUES (N'240', N'240410028', N'WACHID ARIYANTO', N'0', N'SECURITY PRIA', N'2024-09-07 23:00:00.0000000', N'2024-09-08 07:00:00.0000000', N'2024-09-07 21:54:25.0000000', N'2024-09-08 07:31:54.0000000', N'00:00:00.0000000', N'Tepat Waktu', N'1', N'1', N'Malam', N'M', NULL, NULL, N'1', N'0')
GO

SET IDENTITY_INSERT [dbo].[JadwalKehadirans] OFF
GO


-- ----------------------------
-- Auto increment value for JadwalKehadirans
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JadwalKehadirans]', RESEED, 242)
GO


-- ----------------------------
-- Primary Key structure for table JadwalKehadirans
-- ----------------------------
ALTER TABLE [dbo].[JadwalKehadirans] ADD CONSTRAINT [PK__JadwalKe__3214EC07C90D1A7C] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

