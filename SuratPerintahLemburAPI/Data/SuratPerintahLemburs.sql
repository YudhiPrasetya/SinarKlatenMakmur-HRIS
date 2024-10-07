/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : SuratPerintahLemburDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 01/11/2023 14:35:39
*/


-- ----------------------------
-- Table structure for SuratPerintahLemburs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SuratPerintahLemburs]') AND type IN ('U'))
	DROP TABLE [dbo].[SuratPerintahLemburs]
GO

CREATE TABLE [dbo].[SuratPerintahLemburs] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [GroupId] int  NOT NULL,
  [GroupName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DepartmentId] int  NOT NULL,
  [DepartmentName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [EmployeeId] int  NOT NULL,
  [EmployeeName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Style] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [OTType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [OTDate] datetime2(7)  NOT NULL,
  [OT1] int  NOT NULL,
  [OT2] int  NOT NULL,
  [OTBreak] int  NOT NULL,
  [OTTotal] int  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int DEFAULT 0 NOT NULL,
  [UpdatedAT] datetime2(7)  NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL,
  [TunjJabatan] int DEFAULT 0 NOT NULL,
  [TunjKeterampilan] int DEFAULT 0 NOT NULL,
  [TunjLain] int DEFAULT 0 NOT NULL,
  [TunjMasaKerja] int DEFAULT 0 NOT NULL,
  [Upah] decimal(18,2)  NOT NULL,
  [UpahLembur] decimal(18,2)  NOT NULL
)
GO

ALTER TABLE [dbo].[SuratPerintahLemburs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of SuratPerintahLemburs
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SuratPerintahLemburs] ON
GO

INSERT INTO [dbo].[SuratPerintahLemburs] ([Id], [GroupId], [GroupName], [DepartmentId], [DepartmentName], [EmployeeId], [EmployeeName], [NIK], [Description], [Style], [OTType], [OTDate], [OT1], [OT2], [OTBreak], [OTTotal], [CreatedAt], [CreatedBy], [UpdatedAT], [UpdatedBy], [TunjJabatan], [TunjKeterampilan], [TunjLain], [TunjMasaKerja], [Upah], [UpahLembur]) VALUES (N'11', N'4', N'SK/STAFF', N'6', N'CV.SK ', N'2128', N'YUDHI PRASETYA', N'823072020', N'fgff', N'dasdasd', N'Lembur Awal', N'2023-10-19 14:53:51.9572520', N'1', N'1', N'0', N'2', N'2023-10-19 14:53:51.7460000', N'1', N'2023-10-19 14:53:51.7460000', N'1', N'0', N'0', N'0', N'0', N'2152323.00', N'24882.00')
GO

SET IDENTITY_INSERT [dbo].[SuratPerintahLemburs] OFF
GO


-- ----------------------------
-- Auto increment value for SuratPerintahLemburs
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[SuratPerintahLemburs]', RESEED, 11)
GO


-- ----------------------------
-- Primary Key structure for table SuratPerintahLemburs
-- ----------------------------
ALTER TABLE [dbo].[SuratPerintahLemburs] ADD CONSTRAINT [PK_SuratPerintahLemburs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

