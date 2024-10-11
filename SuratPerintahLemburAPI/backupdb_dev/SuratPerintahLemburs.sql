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

 Date: 11/10/2024 09:17:18
*/


-- ----------------------------
-- Table structure for SuratPerintahLemburs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SuratPerintahLemburs]') AND type IN ('U'))
	DROP TABLE [dbo].[SuratPerintahLemburs]
GO

CREATE TABLE [dbo].[SuratPerintahLemburs] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [GroupId] int  NULL,
  [GroupName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [DepartmentId] int  NULL,
  [DepartmentName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [EmployeeId] int  NULL,
  [EmployeeName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Style] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [OTType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [OTDate] datetime2(7)  NULL,
  [OT1] int  NULL,
  [OT2] int  NULL,
  [OTBreak] int  NULL,
  [OTTotal] int  NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int  NULL,
  [UpdatedAT] datetime2(7)  NULL,
  [UpdatedBy] int  NULL,
  [TunjJabatan] int  NULL,
  [TunjKeterampilan] int  NULL,
  [TunjLain] int  NULL,
  [TunjMasaKerja] int  NULL,
  [Upah] decimal(18,2)  NULL,
  [NominalOT1] decimal(18,2)  NULL,
  [NominalOT2] decimal(18,2)  NULL,
  [NominalOTTotal] decimal(18,2)  NULL,
  [NominalOT3] decimal(18,2)  NULL,
  [NominalOT4] decimal(18,2)  NULL,
  [OTP1] int  NULL,
  [OTP2] int  NULL,
  [OTP3] int  NULL,
  [OTP4] int  NULL,
  [OTPNominal1] decimal(18,2)  NULL,
  [OTPNominal2] decimal(18,2)  NULL,
  [OTPNominal3] decimal(18,2)  NULL,
  [OTPNominal4] decimal(18,2)  NULL
)
GO

ALTER TABLE [dbo].[SuratPerintahLemburs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of SuratPerintahLemburs
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SuratPerintahLemburs] ON
GO

INSERT INTO [dbo].[SuratPerintahLemburs] ([Id], [GroupId], [GroupName], [DepartmentId], [DepartmentName], [EmployeeId], [EmployeeName], [NIK], [Description], [Style], [OTType], [OTDate], [OT1], [OT2], [OTBreak], [OTTotal], [CreatedAt], [CreatedBy], [UpdatedAT], [UpdatedBy], [TunjJabatan], [TunjKeterampilan], [TunjLain], [TunjMasaKerja], [Upah], [NominalOT1], [NominalOT2], [NominalOTTotal], [NominalOT3], [NominalOT4], [OTP1], [OTP2], [OTP3], [OTP4], [OTPNominal1], [OTPNominal2], [OTPNominal3], [OTPNominal4]) VALUES (N'1', NULL, N'SK/SECURITY', NULL, NULL, N'714', N'SIGIT PURNOMO', N'722040717', N'gdfgdfg', N'ddsf', N'Lembur Akhir', N'2023-12-01 00:00:00.0000000', N'2', N'6', NULL, N'8', N'2024-01-27 00:00:00.0000000', N'1', N'2024-01-27 00:00:00.0000000', N'1', N'75000', N'0', N'75000', N'0', N'2152322.94', N'19962.35', N'159698.76', N'179661.10', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[SuratPerintahLemburs] ([Id], [GroupId], [GroupName], [DepartmentId], [DepartmentName], [EmployeeId], [EmployeeName], [NIK], [Description], [Style], [OTType], [OTDate], [OT1], [OT2], [OTBreak], [OTTotal], [CreatedAt], [CreatedBy], [UpdatedAT], [UpdatedBy], [TunjJabatan], [TunjKeterampilan], [TunjLain], [TunjMasaKerja], [Upah], [NominalOT1], [NominalOT2], [NominalOTTotal], [NominalOT3], [NominalOT4], [OTP1], [OTP2], [OTP3], [OTP4], [OTPNominal1], [OTPNominal2], [OTPNominal3], [OTPNominal4]) VALUES (N'2', NULL, N'SK/SECURITY', NULL, NULL, N'715', N'RAFI RAJU SANJAYA', N'722040718', N'lembur 8 jam', NULL, N'Lembur Hari Libur', N'2024-01-01 00:00:00.0000000', N'2', N'6', N'0', N'8', N'2024-02-01 00:00:00.0000000', N'1', N'2024-02-01 00:00:00.0000000', N'1', N'75000', N'0', N'75000', N'0', N'2244012.00', N'0.00', N'193732.00', N'235247.00', N'41515.00', N'0.00', N'0', N'7', N'1', N'0', N'20757.00', N'27676.00', N'41515.00', N'55353.00')
GO

INSERT INTO [dbo].[SuratPerintahLemburs] ([Id], [GroupId], [GroupName], [DepartmentId], [DepartmentName], [EmployeeId], [EmployeeName], [NIK], [Description], [Style], [OTType], [OTDate], [OT1], [OT2], [OTBreak], [OTTotal], [CreatedAt], [CreatedBy], [UpdatedAT], [UpdatedBy], [TunjJabatan], [TunjKeterampilan], [TunjLain], [TunjMasaKerja], [Upah], [NominalOT1], [NominalOT2], [NominalOTTotal], [NominalOT3], [NominalOT4], [OTP1], [OTP2], [OTP3], [OTP4], [OTPNominal1], [OTPNominal2], [OTPNominal3], [OTPNominal4]) VALUES (N'3', NULL, N'SK/STAFF', NULL, NULL, NULL, N'KRISTANTI ERMASARI SPV', N'818010085', N'lembur 2 jam', NULL, N'Lembur Akhir', N'2024-02-08 00:00:00.0000000', N'1', N'1', N'0', N'2', NULL, N'0', NULL, N'0', N'0', N'0', N'60000', N'0', N'2244012.00', N'193732.00', N'0.00', N'0.00', NULL, NULL, N'1', N'1', N'0', N'0', N'193732.00', N'0.00', N'0.00', N'0.00')
GO

SET IDENTITY_INSERT [dbo].[SuratPerintahLemburs] OFF
GO


-- ----------------------------
-- Auto increment value for SuratPerintahLemburs
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[SuratPerintahLemburs]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table SuratPerintahLemburs
-- ----------------------------
ALTER TABLE [dbo].[SuratPerintahLemburs] ADD CONSTRAINT [PK_SuratPerintahLemburs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

