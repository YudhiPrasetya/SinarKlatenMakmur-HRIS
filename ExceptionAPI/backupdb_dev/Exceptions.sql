/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : ExceptionsDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:07:41
*/


-- ----------------------------
-- Table structure for Exceptions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Exceptions]') AND type IN ('U'))
	DROP TABLE [dbo].[Exceptions]
GO

CREATE TABLE [dbo].[Exceptions] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Nama] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ExceptionName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [StartDate] datetime2(7)  NULL,
  [EndDate] datetime2(7)  NULL,
  [Detail] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [UpdatedBy] int  NOT NULL,
  [GrupKerja] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL
)
GO

ALTER TABLE [dbo].[Exceptions] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Exceptions
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Exceptions] ON
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'1', N'722041026', N'RESA YULIANA PUTRI', N'CUTI TAHUNAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'2', N'722041086', N'WINDARTI', N'CUTI TAHUNAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'3', N'722121716', N'NAYLA PUTRI AULIA', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'4', N'722121716', N'NAYLA PUTRI AULIA', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'5', N'722121716', N'NAYLA PUTRI AULIA', N'CUTI TAHUNAN', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'6', N'722121716', N'NAYLA PUTRI AULIA', N'CUTI TAHUNAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'7', N'722121716', N'NAYLA PUTRI AULIA', N'CUTI TAHUNAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/ADMIN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'8', N'722040710', N'WIWIN ANDRIANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'9', N'722040804', N'KETTY PUTRI ANGGORO WATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'10', N'722040804', N'KETTY PUTRI ANGGORO WATI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'11', N'722040804', N'KETTY PUTRI ANGGORO WATI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'12', N'722040863', N'SULIASIH', N'CUTI TAHUNAN', N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'13', N'722040863', N'SULIASIH', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'14', N'722040863', N'SULIASIH', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'15', N'722040863', N'SULIASIH', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'16', N'722040863', N'SULIASIH', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'17', N'722040863', N'SULIASIH', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'18', N'722040863', N'SULIASIH', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'19', N'722040863', N'SULIASIH', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'20', N'722040863', N'SULIASIH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'21', N'722040863', N'SULIASIH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'22', N'722040863', N'SULIASIH', N'IJIN ', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'23', N'722040863', N'SULIASIH', N'IJIN ', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'24', N'722040863', N'SULIASIH', N'IJIN ', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'25', N'722040863', N'SULIASIH', N'IJIN ', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'26', N'722040922', N'BUDIYONO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'27', N'722040922', N'BUDIYONO', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'28', N'722061403', N'IVAN LUTFIANTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'29', N'722091639', N'FITRI HANDAYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'30', N'723021902', N'TIMBUL WAHYU NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'31', N'723021902', N'TIMBUL WAHYU NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'32', N'723021902', N'TIMBUL WAHYU NUGROHO', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'33', N'723021902', N'TIMBUL WAHYU NUGROHO', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'34', N'723021902', N'TIMBUL WAHYU NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/CUTTING')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'35', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI MENIKAH', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'36', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI MENIKAH', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'37', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI MENIKAH', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'38', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI TAHUNAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'39', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI TAHUNAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'40', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI TAHUNAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'41', N'722041311', N'FELIX ALFIAN SANJAYA', N'CUTI TAHUNAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'42', N'722061379', N'FAJAR PURNOMO', N'CUTI TAHUNAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'43', N'722061379', N'FAJAR PURNOMO', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/DRIVER')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'44', N'722040862', N'MAHMUD NUR SAID', N'CUTI TAHUNAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/HT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'45', N'718010071', N'VITRIA AYU VEBRIANI ', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'46', N'718040161', N'MUJI LESTARI ', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'47', N'722040766', N'KUSMIYATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'48', N'723011853', N'AMIR SOLIKIN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'49', N'723011853', N'AMIR SOLIKIN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'50', N'723011853', N'AMIR SOLIKIN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'51', N'723011853', N'AMIR SOLIKIN', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'52', N'723011856', N'SRI PARWATI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'53', N'723011856', N'SRI PARWATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'54', N'723011856', N'SRI PARWATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'55', N'723011856', N'SRI PARWATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/IRON')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'56', N'722040723', N'WIDI SULISTIANI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'57', N'722040894', N'SUPRAPTI / JOMBOR', N'CUTI ORTU/MERTUA/SUAMI/ISTRI/ANAK MENINGGAL', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'58', N'722040894', N'SUPRAPTI / JOMBOR', N'CUTI ORTU/MERTUA/SUAMI/ISTRI/ANAK MENINGGAL', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'59', N'722041004', N'EKO FITRIANINGRUM', N'CUTI TAHUNAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'60', N'723062015', N'AGUSTINI WULANDARI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'61', N'723062015', N'AGUSTINI WULANDARI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ANNA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'62', N'719090347', N'LEGIYEM', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'63', N'719090347', N'LEGIYEM', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'64', N'722040733', N'CAHYO BAGUS PRATAMA', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'65', N'722040733', N'CAHYO BAGUS PRATAMA', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'66', N'723021905', N'DAVID HIDAYAT', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'67', N'723031918', N'JOHAN MUSTOFA NURAINI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'68', N'723031918', N'JOHAN MUSTOFA NURAINI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ARI TANTRI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'69', N'722040702', N'SITI ROHMANI ', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'70', N'722040777', N'RUJIATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'71', N'722040877', N'ISKANDAR WIJANARKO', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'72', N'722040877', N'ISKANDAR WIJANARKO', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'73', N'722040877', N'ISKANDAR WIJANARKO', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'74', N'722040952', N'DYAN KUSUMAWATI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'75', N'722061387', N'MUHAMMAD NUR IKHSAN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'76', N'723021911', N'BINTI SHOLIKHATUN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'77', N'723021911', N'BINTI SHOLIKHATUN', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'78', N'723051964', N'SUJATMIKO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE DIKA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'79', N'722040829', N'MARYANI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'80', N'722040939', N'FITRI ENDRIYANI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'81', N'722040939', N'FITRI ENDRIYANI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'82', N'723021908', N'ANDRI PAWARTI', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE ENDANG')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'83', N'722040687', N'HARSINI', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'84', N'722040687', N'HARSINI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'85', N'722040687', N'HARSINI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'86', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'87', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'88', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'89', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-04 00:00:00.0000000', N'2023-11-04 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'90', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-05 00:00:00.0000000', N'2023-11-05 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'91', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'92', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'93', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'94', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'95', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'96', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-11 00:00:00.0000000', N'2023-11-11 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'97', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-12 00:00:00.0000000', N'2023-11-12 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'98', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'99', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'100', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'101', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'102', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'103', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-18 00:00:00.0000000', N'2023-11-18 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'104', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-19 00:00:00.0000000', N'2023-11-19 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'105', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'106', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'107', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'108', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'109', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'110', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-25 00:00:00.0000000', N'2023-11-25 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'111', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-26 00:00:00.0000000', N'2023-11-26 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'112', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'113', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'114', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'115', N'722040869', N'AULIA LISTYANI', N'CUTI MELAHIRKAN', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'116', N'722040960', N'DENI SETIAWAN', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'117', N'723051981', N'YUNITA ISMAWATI', N'CUTI TAHUNAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'118', N'723052007', N'SURYANI / BANARJO', N'CUTI ORTU/MERTUA/SUAMI/ISTRI/ANAK MENINGGAL', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'119', N'723052007', N'SURYANI / BANARJO', N'CUTI ORTU/MERTUA/SUAMI/ISTRI/ANAK MENINGGAL', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KAMARI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'120', N'722040818', N'SURANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'121', N'722040818', N'SURANI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'122', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'123', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'124', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'125', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-04 00:00:00.0000000', N'2023-11-04 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'126', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-05 00:00:00.0000000', N'2023-11-05 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'127', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'128', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'129', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'130', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'131', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'132', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-11 00:00:00.0000000', N'2023-11-11 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'133', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-12 00:00:00.0000000', N'2023-11-12 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'134', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'135', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'136', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'137', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'138', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'139', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-18 00:00:00.0000000', N'2023-11-18 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'140', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-19 00:00:00.0000000', N'2023-11-19 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'141', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'142', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'143', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'144', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'145', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'146', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-25 00:00:00.0000000', N'2023-11-25 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'147', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-26 00:00:00.0000000', N'2023-11-26 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'148', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'149', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'150', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'151', N'722040844', N'TITA SARASWATI', N'CUTI MELAHIRKAN', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'152', N'722040913', N'SULISTIAWATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'153', N'722040913', N'SULISTIAWATI', N'CUTI TAHUNAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'154', N'722040693', N'NANIK SUWANDARI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE KRISTINA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'155', N'721010529', N'MEXITALIA GRETA FERYANA', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'156', N'721070586', N'SURATMI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'157', N'722040882', N'TRI HANDAYANINGSIH', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'158', N'722040946', N'SRI LESTARI / NGENTAK', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'159', N'722040989', N'MUHAMAD RAHAYU SAPUTRA', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'160', N'722040989', N'MUHAMAD RAHAYU SAPUTRA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'161', N'722041183', N'ARIZAL ROY ALBANA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'162', N'723082030', N'NASRULLOH BANI ISMAIL', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NARTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'163', N'721110602', N'WIDAYAT JUNIANTO', N'CUTI ISTRI MELAHIRKAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'164', N'721110602', N'WIDAYAT JUNIANTO', N'CUTI ISTRI MELAHIRKAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'165', N'722040945', N'TRIMAH', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'166', N'722040945', N'TRIMAH', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'167', N'722040971', N'BADRIYATUN', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'168', N'722040973', N'YUSUF KRISTIAWAN', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'169', N'722091618', N'LILIK TRI MULYANI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'170', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'171', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'172', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'173', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'174', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'175', N'722091618', N'LILIK TRI MULYANI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'176', N'722091618', N'LILIK TRI MULYANI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'177', N'722091618', N'LILIK TRI MULYANI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'178', N'722091618', N'LILIK TRI MULYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'179', N'723051990', N'NINING RAHAYU', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE NUR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'180', N'719090369', N'MUHAMMAD SHOHIBUL WAHID', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'181', N'720070427', N'WAHYU PRASTIWI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'182', N'722040724', N'SAVITARIA IGA ALTARI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'183', N'722040724', N'SAVITARIA IGA ALTARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'184', N'722040748', N'YANI LESTARI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'185', N'722040751', N'SRI MARTINI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'186', N'722040754', N'AMBAR RAHAYU', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'187', N'722040754', N'AMBAR RAHAYU', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'188', N'722040779', N'IRA NOFIAWATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'189', N'722040885', N'FINKI WULANDARI', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'190', N'722040885', N'FINKI WULANDARI', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'191', N'722040885', N'FINKI WULANDARI', N'CUTI MENIKAH', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'192', N'722040885', N'FINKI WULANDARI', N'CUTI MENIKAH', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'193', N'722040885', N'FINKI WULANDARI', N'CUTI MENIKAH', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'194', N'722040885', N'FINKI WULANDARI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'195', N'722040885', N'FINKI WULANDARI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'196', N'722040951', N'TRI YULIANI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'197', N'722040951', N'TRI YULIANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'198', N'722040951', N'TRI YULIANI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'199', N'722040951', N'TRI YULIANI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'200', N'722041083', N'RIZKYTA NUR HIDAYAH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'201', N'723011823', N'ANGELA DEVANI PERMATA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'202', N'723021863', N'MUKLIS ISKANDAR', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE PIPIT')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'203', N'722040785', N'RAHAYU', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'204', N'722040785', N'RAHAYU', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'205', N'722040785', N'RAHAYU', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUGIYANTI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'206', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'207', N'721110603', N'NANIK SUMARNI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'208', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'209', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'210', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'211', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'212', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'213', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'214', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'215', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'216', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'217', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'218', N'721110603', N'NANIK SUMARNI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'219', N'722041053', N'RUSTANTI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'220', N'722041078', N'DEVY EKA PURNAMASARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'221', N'722061404', N'IKHSAN SYAFI''I', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'222', N'722121746', N'YULIAN WAHYU SAPUTRA', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'223', N'723031942', N'RAYDA DWI PRATAMA', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'224', N'723051996', N'TRI RIYADI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'225', N'723051996', N'TRI RIYADI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'226', N'723051996', N'TRI RIYADI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE SUTARWI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'227', N'721110625', N'DHITO GALANG SADEWA ERITANTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE WENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'228', N'722040782', N'WARTI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE WENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'229', N'722040879', N'MUHYIDI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE WENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'230', N'723031952', N'DINA HARJANTI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE WENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'231', N'723052000', N'MUH. RISKI NURDIANSAH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/LINE WENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'232', N'722040770', N'DANANG PURNOMO', N'CUTI TAHUNAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/MEKANIK')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'233', N'722041171', N'ALIP HARSONO', N'CUTI TAHUNAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/MEKANIK')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'234', N'722041171', N'ALIP HARSONO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/MEKANIK')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'235', N'722041187', N'NICO SONI SAPUTRA', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/MEKANIK')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'236', N'721010526', N'LILIK SURYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING OUTERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'237', N'721010526', N'LILIK SURYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING OUTERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'238', N'722040974', N'SRI PUJI HASTUTI', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING OUTERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'239', N'721110614', N'MELISA SAPUTRI', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'240', N'721110614', N'MELISA SAPUTRI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'241', N'721110614', N'MELISA SAPUTRI', N'CUTI MENIKAH', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'242', N'721110614', N'MELISA SAPUTRI', N'CUTI MENIKAH', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'243', N'721110614', N'MELISA SAPUTRI', N'CUTI MENIKAH', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'244', N'721110614', N'MELISA SAPUTRI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'245', N'722040843', N'REWANG MANUNGGAL JATI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'246', N'722040843', N'REWANG MANUNGGAL JATI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'247', N'722040843', N'REWANG MANUNGGAL JATI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PACKING UNDERWEAR')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'248', N'721110617', N'FAHRUL TRI BASHORI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PATTERN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'249', N'23060123', N'MUSA', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PKL')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'250', N'23060124', N'FATONI LINDU AJI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PKL')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'251', N'23060124', N'FATONI LINDU AJI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PKL')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'252', N'23060124', N'FATONI LINDU AJI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PKL')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'253', N'23060124', N'FATONI LINDU AJI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PKL')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'254', N'722041032', N'NGADIMAN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'255', N'722041073', N'NANANG KRISNANTO', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'256', N'722041116', N'FAJAR DWI UTAMI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'257', N'722041120', N'AYU SINTAWATI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'258', N'722071503', N'SABILA GUSTINA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'259', N'722081551', N'ANITA AGUSTINA', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'260', N'722081577', N'KURNIAWAN SATYA PRABOWO', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'261', N'722091616', N'SAVINA AYU DWIYANTI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'262', N'722101649', N'DWI RATNANINGSIH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'263', N'722101649', N'DWI RATNANINGSIH', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'264', N'722101649', N'DWI RATNANINGSIH', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'265', N'723011844', N'ACHMAD SAIFUL BASAR', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'266', N'723011844', N'ACHMAD SAIFUL BASAR', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PREPARATION')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'267', N'722041112', N'UUD BACHTIAR', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PRESS')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'268', N'722041112', N'UUD BACHTIAR', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PRESS')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'269', N'722061455', N'MUHAMMAD AGUNG NUR ROHMAN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PRESS')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'270', N'723011838', N'NANDA APRILIA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PRESS')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'271', N'723021909', N'BAYU AJI ARDIYANTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/PRESS')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'272', N'718070183', N'WAHYU ARIANI ', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'273', N'718070183', N'WAHYU ARIANI ', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'274', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'275', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'276', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-25 00:00:00.0000000', N'2023-11-25 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'277', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-26 00:00:00.0000000', N'2023-11-26 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'278', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'279', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'280', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'281', N'718070183', N'WAHYU ARIANI ', N'CUTI MELAHIRKAN', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'282', N'722040786', N'SRI WAHYUNI / CAWAS', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'283', N'722040786', N'SRI WAHYUNI / CAWAS', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'284', N'722061382', N'ERNI ANDIKASARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'285', N'722061382', N'ERNI ANDIKASARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'286', N'722061382', N'ERNI ANDIKASARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'287', N'722061382', N'ERNI ANDIKASARI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'288', N'723062012', N'SAMAYA KHOIRUNNISA', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'289', N'723062012', N'SAMAYA KHOIRUNNISA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'290', N'723062012', N'SAMAYA KHOIRUNNISA', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'291', N'723062012', N'SAMAYA KHOIRUNNISA', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'292', N'723062012', N'SAMAYA KHOIRUNNISA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'293', N'723062012', N'SAMAYA KHOIRUNNISA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC GUNAWAN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'294', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'295', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'296', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'297', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'298', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'299', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-11 00:00:00.0000000', N'2023-11-11 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'300', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-12 00:00:00.0000000', N'2023-11-12 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'301', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'302', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'303', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'304', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'305', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'306', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-18 00:00:00.0000000', N'2023-11-18 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'307', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-19 00:00:00.0000000', N'2023-11-19 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'308', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'309', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'310', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'311', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'312', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'313', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-25 00:00:00.0000000', N'2023-11-25 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'314', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-26 00:00:00.0000000', N'2023-11-26 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'315', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'316', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'317', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'318', N'722040788', N'DWI GIYARTI', N'CUTI MELAHIRKAN', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'319', N'722040838', N'PUJI ASTUTI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'320', N'723051959', N'AGUSTINA IKA PANDU DEWANTI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'321', N'723051970', N'DIAH PUTRI FEBRIANTI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'322', N'822041295', N'BEKTININGSIH', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC JENI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'323', N'722040781', N'RIA SETIYANINGRUM ', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'324', N'722040943', N'SITI YATEN NURJANAH KHOLIFAH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'325', N'722040943', N'SITI YATEN NURJANAH KHOLIFAH', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'326', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'327', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'328', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'329', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-04 00:00:00.0000000', N'2023-11-04 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'330', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-05 00:00:00.0000000', N'2023-11-05 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'331', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'332', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'333', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'334', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'335', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'336', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-11 00:00:00.0000000', N'2023-11-11 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'337', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-12 00:00:00.0000000', N'2023-11-12 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'338', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'339', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'340', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'341', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'342', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'343', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-18 00:00:00.0000000', N'2023-11-18 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'344', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-19 00:00:00.0000000', N'2023-11-19 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'345', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'346', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'347', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'348', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'349', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'350', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-25 00:00:00.0000000', N'2023-11-25 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'351', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-26 00:00:00.0000000', N'2023-11-26 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'352', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'353', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'354', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'355', N'722040999', N'DESY PURWANINGSIH', N'CUTI MELAHIRKAN', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'356', N'722111690', N'DINA SRI MULYANINGRUM', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'357', N'722111690', N'DINA SRI MULYANINGRUM', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'358', N'722111690', N'DINA SRI MULYANINGRUM', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'359', N'722111690', N'DINA SRI MULYANINGRUM', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'360', N'722111690', N'DINA SRI MULYANINGRUM', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'361', N'723052004', N'SRI PURWANTI', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'362', N'723082028', N'OLIFIA SANDRA PUSPITA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MINCU')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'363', N'722040769', N'SRI WISUSI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/QC MUJI')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'364', N'717120004', N'DEDY NUGROHO ', N'CUTI TAHUNAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'365', N'717120004', N'DEDY NUGROHO ', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'366', N'717120004', N'DEDY NUGROHO ', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'367', N'717120004', N'DEDY NUGROHO ', N'CUTI TAHUNAN', N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'368', N'717120004', N'DEDY NUGROHO ', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'369', N'717120004', N'DEDY NUGROHO ', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'370', N'717120004', N'DEDY NUGROHO ', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'371', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'372', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'373', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'374', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'375', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'376', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'377', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'378', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'379', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'380', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'381', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'382', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'383', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'384', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'385', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'386', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'387', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'388', N'719090362', N'NINING VAIF RAHMA N', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'389', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'390', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'391', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'392', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'393', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'394', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'395', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'396', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'397', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'398', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'399', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'400', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'401', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'402', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'403', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'404', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'405', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'406', N'722040721', N'RIYAN GUNAWAN', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'407', N'722040743', N'TRI UTAMI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'408', N'722040743', N'TRI UTAMI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'409', N'722040743', N'TRI UTAMI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'410', N'722040743', N'TRI UTAMI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'411', N'722040743', N'TRI UTAMI', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'412', N'722040743', N'TRI UTAMI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'413', N'722040743', N'TRI UTAMI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'414', N'722040743', N'TRI UTAMI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'415', N'722040743', N'TRI UTAMI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'416', N'722040743', N'TRI UTAMI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'417', N'722040743', N'TRI UTAMI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'418', N'722040743', N'TRI UTAMI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'419', N'722040743', N'TRI UTAMI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'420', N'722040743', N'TRI UTAMI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'421', N'722040743', N'TRI UTAMI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'422', N'722040743', N'TRI UTAMI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'423', N'722040743', N'TRI UTAMI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'424', N'722040743', N'TRI UTAMI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'425', N'722040743', N'TRI UTAMI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'426', N'722040743', N'TRI UTAMI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'427', N'722040827', N'MARINTEN', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'428', N'722040827', N'MARINTEN', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'429', N'722040827', N'MARINTEN', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'430', N'722040827', N'MARINTEN', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'431', N'722040827', N'MARINTEN', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'432', N'722040827', N'MARINTEN', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'433', N'722040827', N'MARINTEN', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'434', N'722040827', N'MARINTEN', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'435', N'722040827', N'MARINTEN', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'436', N'722040827', N'MARINTEN', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'437', N'722040827', N'MARINTEN', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'438', N'722040827', N'MARINTEN', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'439', N'722040827', N'MARINTEN', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'440', N'722040827', N'MARINTEN', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'441', N'722040827', N'MARINTEN', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'442', N'722040827', N'MARINTEN', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'443', N'722040827', N'MARINTEN', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'444', N'722040827', N'MARINTEN', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'445', N'722040827', N'MARINTEN', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'446', N'722040827', N'MARINTEN', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'447', N'722040827', N'MARINTEN', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'448', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'449', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'450', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'451', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'452', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'453', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'454', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'455', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'456', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'457', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'458', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'459', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'460', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'461', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'462', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'463', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'464', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'465', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'466', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'467', N'722040855', N'SHINTA ANGGRAINI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'468', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'469', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'470', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'471', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'472', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'473', N'722040895', N'BAYU PURNOMO AJI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'474', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'475', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'476', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'477', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'478', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'479', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'480', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'481', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'482', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'483', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'484', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'485', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'486', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'487', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'488', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'489', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'490', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'491', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'492', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'493', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'494', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'495', N'722040953', N'YEI NOVA GANA', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'496', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'497', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'498', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'499', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'500', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'501', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'502', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'503', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'504', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'505', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'506', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'507', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'508', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'509', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'510', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'511', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'512', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'513', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'514', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'515', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'516', N'722041128', N'DESI KUSUMAWATI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'517', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'518', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'519', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'520', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'521', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'522', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'523', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'524', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'525', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'526', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'527', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'528', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'529', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'530', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'531', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'532', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'533', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'534', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'535', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'536', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'537', N'722041323', N'RENI NUR RAHMA', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'538', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'539', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'540', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'541', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'542', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'543', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'544', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'545', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'546', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'547', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'548', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'549', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'550', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'551', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'552', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'553', N'722051373', N'ASZARA ARFIN KUSUMAWATI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'554', N'723031917', N'KARWANTI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'555', N'723031917', N'KARWANTI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'556', N'723031917', N'KARWANTI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'557', N'723031917', N'KARWANTI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'558', N'723031917', N'KARWANTI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'559', N'723031917', N'KARWANTI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'560', N'723031917', N'KARWANTI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'561', N'723031917', N'KARWANTI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'562', N'723031917', N'KARWANTI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'563', N'723031917', N'KARWANTI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'564', N'723031917', N'KARWANTI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'565', N'723031917', N'KARWANTI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'566', N'723031917', N'KARWANTI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'567', N'723031917', N'KARWANTI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'568', N'723031917', N'KARWANTI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'569', N'723031917', N'KARWANTI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'570', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'571', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'572', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'573', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'574', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'575', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'576', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'577', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'578', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'579', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'580', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'581', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'582', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'583', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'584', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'585', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'586', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'587', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'588', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'589', N'723051966', N'TRI OKTAVIANI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'590', N'723051985', N'WULANDARI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'591', N'723051985', N'WULANDARI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'592', N'723051985', N'WULANDARI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'593', N'723051985', N'WULANDARI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'594', N'723051985', N'WULANDARI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'595', N'723051985', N'WULANDARI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'596', N'723051985', N'WULANDARI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'597', N'723051985', N'WULANDARI', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'598', N'723051985', N'WULANDARI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'599', N'723051985', N'WULANDARI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'600', N'723051985', N'WULANDARI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'601', N'723051985', N'WULANDARI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'602', N'723051985', N'WULANDARI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'603', N'723051985', N'WULANDARI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'604', N'723051985', N'WULANDARI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'605', N'723051985', N'WULANDARI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'606', N'723051985', N'WULANDARI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/RESIGN')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'607', N'722040734', N'EMA PUSPITASARI', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SAMPLE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'608', N'722040734', N'EMA PUSPITASARI', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SAMPLE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'609', N'723082032', N'BRIGITA NOVEN FEBRINA SULISTYANI', N'CUTI TAHUNAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SAMPLE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'610', N'723082032', N'BRIGITA NOVEN FEBRINA SULISTYANI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SAMPLE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'611', N'719100397', N'WACHID ARIYANTO', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'612', N'722030673', N'IRWAN SULISTYANTO', N'CUTI TAHUNAN', N'2023-11-19 00:00:00.0000000', N'2023-11-19 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'613', N'722030674', N'DWI FAJAR NUGROHO', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'614', N'722040698', N'ROCHMAD SRI NUGROHO', N'CUTI TAHUNAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'615', N'722040717', N'SIGIT PURNOMO', N'CUTI TAHUNAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'616', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'617', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'618', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'619', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'620', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'621', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'622', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'623', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'624', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'625', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'626', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'627', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'628', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'629', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'630', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'631', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'632', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'633', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'634', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'635', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'636', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'637', N'723112034', N'ALDINO WAHYU MUNANDAR', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'638', N'722061433', N'ELVINA CALLISTA PUTRI', N'CUTI TAHUNAN', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SECURITY WANITA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'639', N'722061375', N'SASONGKO FEBRIAN NUGROHO', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'640', N'722061375', N'SASONGKO FEBRIAN NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'641', N'722061375', N'SASONGKO FEBRIAN NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'642', N'722061375', N'SASONGKO FEBRIAN NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'643', N'722061375', N'SASONGKO FEBRIAN NUGROHO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'644', N'723021901', N'AMIN ENGGAR PRATIWI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/SNAP')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'645', N'721010530', N'BAMBANG PURNOMO SIDHI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'646', N'721060560', N'KRISTANTI ERMASARI', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'647', N'819100392', N'SUBAGYO', N'CUTI TAHUNAN', N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'648', N'820120523', N'ANNA NIKEN YULIANI', N'CUTI TAHUNAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'649', N'822041239', N'NISMA NILAMSARI', N'CUTI TAHUNAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'650', N'822041249', N'DHIYANI YUNITAWATI', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'651', N'822041250', N'RAIS NANTA', N'CUTI TAHUNAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'652', N'822041250', N'RAIS NANTA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'653', N'822041251', N'CANDRA PUTRI WIYANTI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'654', N'822041255', N'PIPIT DWI RAHAYU', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'655', N'822041256', N'ISWANTO', N'CUTI TAHUNAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'656', N'822041256', N'ISWANTO', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'657', N'822041256', N'ISWANTO', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'658', N'822041256', N'ISWANTO', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'659', N'822041256', N'ISWANTO', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'660', N'822041258', N'SALIHAH DEWI PAMUNGKAS', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'661', N'822041260', N'SITI ANI', N'CUTI TAHUNAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'662', N'822041260', N'SITI ANI', N'CUTI TAHUNAN', N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'663', N'822041260', N'SITI ANI', N'CUTI TAHUNAN', N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'664', N'822041260', N'SITI ANI', N'CUTI TAHUNAN', N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'665', N'822041268', N'JOKO KUNCORO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'666', N'822041268', N'JOKO KUNCORO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'667', N'822041269', N'BAGUS SURYADI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'668', N'822041270', N'ERIQ RAJANI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'669', N'822041277', N'ERWIN PANCA SAPUTRA', N'CUTI TAHUNAN', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'670', N'822041278', N'ARI WIBOWO', N'CUTI TAHUNAN', N'2023-11-09 00:00:00.0000000', N'2023-11-09 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'671', N'822041279', N'IMAH FATIYATUL FAUZIYAH', N'CUTI TAHUNAN', N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'672', N'822041282', N'FENTI WIDIA PRAMITA SARI', N'CUTI TAHUNAN', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'673', N'822041282', N'FENTI WIDIA PRAMITA SARI', N'CUTI TAHUNAN', N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'674', N'822041282', N'FENTI WIDIA PRAMITA SARI', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'675', N'822041282', N'FENTI WIDIA PRAMITA SARI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'676', N'822041286', N'UMI NURHAYATI', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'677', N'822041290', N'DERI CAHYADI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'678', N'822041290', N'DERI CAHYADI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'679', N'822041290', N'DERI CAHYADI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'680', N'822041290', N'DERI CAHYADI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'681', N'822041291', N'ANDRE PUTRA KURNIAWAN', N'CUTI TAHUNAN', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'682', N'822041293', N'SUGIARTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'683', N'822041293', N'SUGIARTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'684', N'822041293', N'SUGIARTO', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'685', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'686', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'687', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'688', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'689', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'690', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'691', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'692', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'693', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'694', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'695', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'696', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'697', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'698', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'699', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'700', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'701', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-24 00:00:00.0000000', N'2023-11-24 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'702', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'703', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'704', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'705', N'822071479', N'SETYONINGSIH', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'706', N'822071492', N'SUWANTO', N'CUTI TAHUNAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'707', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-01 00:00:00.0000000', N'2023-11-01 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'708', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-02 00:00:00.0000000', N'2023-11-02 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'709', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-03 00:00:00.0000000', N'2023-11-03 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'710', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'711', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-07 00:00:00.0000000', N'2023-11-07 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'712', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-08 00:00:00.0000000', N'2023-11-08 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'713', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'714', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'715', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'716', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'717', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'718', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'719', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'720', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-22 00:00:00.0000000', N'2023-11-22 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'721', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-23 00:00:00.0000000', N'2023-11-23 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'722', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-27 00:00:00.0000000', N'2023-11-27 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'723', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'724', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-29 00:00:00.0000000', N'2023-11-29 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'725', N'822081535', N'WAHYU ADHIKA NUGRAHADI', NULL, N'2023-11-30 00:00:00.0000000', N'2023-11-30 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'726', N'822081552', N'PANGKI MARADONA', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'727', N'822081586', N'AGUNAWAN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'728', N'822081586', N'AGUNAWAN', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'729', N'822091625', N'DANANG PRASETYO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-14 00:00:00.0000000', N'2023-11-14 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'730', N'823051958', N'DENI HARTANTO', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-16 00:00:00.0000000', N'2023-11-16 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'731', N'823072020', N'YUDHI PRASETYA', N'CUTI TAHUNAN', N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'732', N'822041307', N'SITI ZUBAIDAH', NULL, N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'733', N'822041307', N'SITI ZUBAIDAH', NULL, N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'734', N'822041307', N'SITI ZUBAIDAH', NULL, N'2023-11-15 00:00:00.0000000', N'2023-11-15 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'735', N'822041307', N'SITI ZUBAIDAH', NULL, N'2023-11-20 00:00:00.0000000', N'2023-11-20 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/STAFF JAKARTA')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'736', N'721110623', N'SHEFTA SHARANITA', N'CUTI TAHUNAN', N'2023-11-06 00:00:00.0000000', N'2023-11-06 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'737', N'722040735', N'TAUFIK ABDUL MUSTHOHA', N'CUTI TAHUNAN', N'2023-11-17 00:00:00.0000000', N'2023-11-17 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'738', N'722040735', N'TAUFIK ABDUL MUSTHOHA', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'739', N'722040735', N'TAUFIK ABDUL MUSTHOHA', N'CUTI TAHUNAN', N'2023-11-28 00:00:00.0000000', N'2023-11-28 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'740', N'722041166', N'VIRDAUS MUCHININ', N'CUTI TAHUNAN', N'2023-11-13 00:00:00.0000000', N'2023-11-13 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'741', N'722041166', N'VIRDAUS MUCHININ', N'CUTI TAHUNAN', N'2023-11-21 00:00:00.0000000', N'2023-11-21 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'742', N'723062016', N'MUHAMMAD IQBAL ASROFY', N'SAKIT DENGAN SURAT DOKTER', N'2023-11-10 00:00:00.0000000', N'2023-11-10 00:00:00.0000000', NULL, NULL, N'1', NULL, N'1', N'SK/WAREHOUSE')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'743', N'240410433', N'CANI ARIANI', N'CUTI TAHUNAN', N'2024-09-27 00:00:00.0000000', N'2024-09-27 00:00:00.0000000', N'Cuti rutin tahunan', N'2024-09-27 11:13:16.2200000', N'1', N'2024-09-27 11:13:16.2200000', N'1', N'ADMIN INVENTORY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'744', N'240410433', N'CANI ARIANI', N'CUTI TAHUNAN', N'2024-09-27 00:00:00.0000000', N'2024-09-27 00:00:00.0000000', NULL, N'2024-09-27 12:59:38.4880000', N'1', N'2024-09-27 12:59:38.4880000', N'1', N'ADMIN INVENTORY')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [GrupKerja]) VALUES (N'745', N'240410433', N'CANI ARIANI', N'CUTI TAHUNAN', N'2024-09-27 00:00:00.0000000', N'2024-09-27 00:00:00.0000000', N'cuti rutin tahunan', N'2024-09-27 13:51:31.0200000', N'1', N'2024-09-27 13:51:31.0200000', N'1', N'ADMIN INVENTORY')
GO

SET IDENTITY_INSERT [dbo].[Exceptions] OFF
GO


-- ----------------------------
-- Auto increment value for Exceptions
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Exceptions]', RESEED, 745)
GO


-- ----------------------------
-- Primary Key structure for table Exceptions
-- ----------------------------
ALTER TABLE [dbo].[Exceptions] ADD CONSTRAINT [PK_Exceptions] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

