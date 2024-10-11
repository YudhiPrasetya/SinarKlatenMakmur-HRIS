/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : ShiftDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:15:35
*/


-- ----------------------------
-- Table structure for JadwalShiftKaryawans
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JadwalShiftKaryawans]') AND type IN ('U'))
	DROP TABLE [dbo].[JadwalShiftKaryawans]
GO

CREATE TABLE [dbo].[JadwalShiftKaryawans] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Deskripsi] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [JadwalMasuk] time(7)  NULL,
  [JadwalPulang] time(7)  NULL,
  [Days] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Initial] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[JadwalShiftKaryawans] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of JadwalShiftKaryawans
-- ----------------------------
SET IDENTITY_INSERT [dbo].[JadwalShiftKaryawans] ON
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'6', N'Shift Pertama', N'07:30:00.0000000', N'16:15:00.0000000', NULL, NULL)
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'7', N'Shift Kedua', N'16:15:00.0000000', N'23:30:00.0000000', NULL, NULL)
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'9', N'Lainnya', N'00:00:00.0000000', N'00:00:00.0000000', NULL, NULL)
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'10', N'Shift 1 5 HK', N'07:30:00.0000000', N'16:30:00.0000000', N'1, 2, 3, 4, 5', N'P1')
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'11', N'asdasdsad', N'12:00:00.0000000', N'18:01:00.0000000', N'1, 2, 3, 4, 5, 6', NULL)
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'12', N'Shift 1 Cutting P0', N'06:30:00.0000000', N'14:15:00.0000000', N'1, 2, 3, 4, 5, 6', N'P01')
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'13', N'Shift 1 Cutting Molding', N'06:30:00.0000000', N'14:15:00.0000000', N'1, 2, 3, 4, 5, 6', N'P0')
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'14', N'Shift 1 Cutting Molding 1', N'07:00:00.0000000', N'14:45:00.0000000', N'1, 2, 3, 4, 5, 6', N'P')
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'15', N'Cuti', N'00:00:00.0000000', N'00:00:00.0000000', N'1, 2, 3, 4, 5, 6', N'CT')
GO

INSERT INTO [dbo].[JadwalShiftKaryawans] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Days], [Initial]) VALUES (N'16', N'Libur', N'00:00:00.0000000', N'00:00:00.0000000', N'1, 2, 3, 4, 5, 6', N'L')
GO

SET IDENTITY_INSERT [dbo].[JadwalShiftKaryawans] OFF
GO


-- ----------------------------
-- Auto increment value for JadwalShiftKaryawans
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JadwalShiftKaryawans]', RESEED, 16)
GO


-- ----------------------------
-- Primary Key structure for table JadwalShiftKaryawans
-- ----------------------------
ALTER TABLE [dbo].[JadwalShiftKaryawans] ADD CONSTRAINT [PK_JadwalShiftKaryawans] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

