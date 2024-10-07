/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : JadwalKerjaKaryawanDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 03/11/2023 16:13:20
*/


-- ----------------------------
-- Table structure for JadwalKerjaKaryawans
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JadwalKerjaKaryawans]') AND type IN ('U'))
	DROP TABLE [dbo].[JadwalKerjaKaryawans]
GO

CREATE TABLE [dbo].[JadwalKerjaKaryawans] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NamaKaryawan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [GroupName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TglAwal] datetime2(7)  NULL,
  [TglAkhir] datetime2(7)  NULL,
  [JamMasuk] time(7)  NULL,
  [JamPulang] time(7)  NULL,
  [CreatedBy] int  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [UpdatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [Keterangan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[JadwalKerjaKaryawans] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Auto increment value for JadwalKerjaKaryawans
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JadwalKerjaKaryawans]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table JadwalKerjaKaryawans
-- ----------------------------
ALTER TABLE [dbo].[JadwalKerjaKaryawans] ADD CONSTRAINT [PK_JadwalKerjaKaryawans] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

