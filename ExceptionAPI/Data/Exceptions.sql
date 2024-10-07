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

 Date: 03/11/2023 14:37:38
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
  [IdException] int  NOT NULL,
  [ExceptionName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [StartDate] datetime2(7)  NULL,
  [EndDate] datetime2(7)  NULL,
  [Detail] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [UpdatedBy] int  NOT NULL,
  [IdEmployee] int DEFAULT 0 NOT NULL
)
GO

ALTER TABLE [dbo].[Exceptions] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Exceptions
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Exceptions] ON
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'1', N'718010049', N'NIKEN DWI LESTARI', N'3', N'CUTI MENIKAH', N'2023-09-04 00:00:00.0000000', N'2023-09-06 00:00:00.0000000', N'sdfsdfsdfsdf', N'2023-08-30 16:35:11.7650000', N'0', N'2023-08-30 16:35:11.7650000', N'0', N'5')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'2', N'818010085', N'KRISTANTI ERMASARI SPV', N'1', N'SAKIT DENGAN SURAT DOKTER', N'2023-09-06 00:00:00.0000000', N'2023-09-08 00:00:00.0000000', N'ffgfgfgfgfg', N'2023-09-05 07:54:38.3460000', N'1', N'2023-09-05 07:54:38.3460000', N'1', N'0')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'3', N'818010085', N'KRISTANTI ERMASARI SPV', N'2', N'SAKIT TANPA SURAT DOKTER', N'2023-09-10 00:00:00.0000000', N'2023-09-13 00:00:00.0000000', N'xxzxzxzxc', N'2023-08-31 07:24:23.3940000', N'0', N'2023-08-31 07:24:23.3950000', N'0', N'4')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'4', N'823072020', N'YUDHI PRASETYA', N'1', N'SAKIT DENGAN SURAT DOKTER', N'2023-09-07 00:00:00.0000000', N'2023-09-11 00:00:00.0000000', N'sakit sakit sakit', N'2023-09-06 11:08:02.4610000', N'1', N'2023-09-06 11:08:02.4610000', N'1', N'0')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'5', N'822041252', N'TITA INDARMANTI', N'6', N'IJIN', N'2023-08-03 00:00:00.0000000', N'2023-08-04 00:00:00.0000000', N'ttrytryty', N'2023-09-04 16:51:30.4040000', N'1', N'2023-09-04 16:51:30.4040000', N'1', N'0')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'6', N'718010024', N'SRI NING L', N'2', N'SAKIT TANPA SURAT DOKTER', N'2023-09-04 00:00:00.0000000', N'2023-09-06 00:00:00.0000000', N'ssssdsd', N'2023-09-04 08:58:49.7080000', N'1', N'2023-09-04 08:58:49.7080000', N'1', N'48')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'7', N'718010038', N'TUTIK MURYANI', N'6', N'IJIN', N'2023-09-05 00:00:00.0000000', N'2023-09-05 00:00:00.0000000', N'cxvcxvcxv', N'2023-09-04 09:00:33.5030000', N'1', N'2023-09-04 09:00:33.5040000', N'1', N'13')
GO

INSERT INTO [dbo].[Exceptions] ([Id], [NIK], [Nama], [IdException], [ExceptionName], [StartDate], [EndDate], [Detail], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [IdEmployee]) VALUES (N'8', N'718010030', N'PINDRI LARASATI', N'1', N'SAKIT DENGAN SURAT DOKTER', N'2023-09-13 00:00:00.0000000', N'2023-09-15 00:00:00.0000000', N'xxxxxxxx', N'2023-09-04 09:37:59.5480000', N'1', N'2023-09-04 09:37:59.5480000', N'1', N'51')
GO

SET IDENTITY_INSERT [dbo].[Exceptions] OFF
GO


-- ----------------------------
-- Auto increment value for Exceptions
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Exceptions]', RESEED, 9)
GO


-- ----------------------------
-- Primary Key structure for table Exceptions
-- ----------------------------
ALTER TABLE [dbo].[Exceptions] ADD CONSTRAINT [PK_Exceptions] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

