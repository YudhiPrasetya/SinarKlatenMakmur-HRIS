/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : PayrollDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:12:50
*/


-- ----------------------------
-- Table structure for Payrolls
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Payrolls]') AND type IN ('U'))
	DROP TABLE [dbo].[Payrolls]
GO

CREATE TABLE [dbo].[Payrolls] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Bulan] int  NULL,
  [Tahun] int  NULL,
  [IdEmployee] int  NOT NULL,
  [EmployeeName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [GroupName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DepartmentName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Upah] decimal(18,2)  NOT NULL,
  [TotalMasuk] int  NOT NULL,
  [TotalLembur] decimal(18,2)  NOT NULL,
  [Gaji] decimal(18,2)  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int DEFAULT 0 NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL,
  [NIK] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL,
  [Tgl] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[Payrolls] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Payrolls
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Payrolls] ON
GO

INSERT INTO [dbo].[Payrolls] ([Id], [Bulan], [Tahun], [IdEmployee], [EmployeeName], [GroupName], [DepartmentName], [Upah], [TotalMasuk], [TotalLembur], [Gaji], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [NIK], [Tgl]) VALUES (N'80', N'9', N'2024', N'2115', N'CANI ARIANI', N'ADMIN INVENTORY', N'PRODUKSI', N'2244012.00', N'20', N'0.00', N'2137154.20', N'2024-09-27 00:00:00.0000000', N'1', N'2024-09-27 11:13:30.2430004', N'1', N'240410433', NULL)
GO

INSERT INTO [dbo].[Payrolls] ([Id], [Bulan], [Tahun], [IdEmployee], [EmployeeName], [GroupName], [DepartmentName], [Upah], [TotalMasuk], [TotalLembur], [Gaji], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [NIK], [Tgl]) VALUES (N'83', N'10', N'2024', N'2115', N'CANI ARIANI', N'ADMIN INVENTORY', N'PRODUKSI', N'2244012.00', N'2', N'0.00', N'213715.42', N'2024-10-03 00:00:00.0000000', N'1', N'2024-10-04 11:33:07.9058955', N'1', N'240410433', N'2024-10-04 11:33:07.9056319')
GO

SET IDENTITY_INSERT [dbo].[Payrolls] OFF
GO


-- ----------------------------
-- Auto increment value for Payrolls
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Payrolls]', RESEED, 83)
GO


-- ----------------------------
-- Primary Key structure for table Payrolls
-- ----------------------------
ALTER TABLE [dbo].[Payrolls] ADD CONSTRAINT [PK_Payrolls] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

