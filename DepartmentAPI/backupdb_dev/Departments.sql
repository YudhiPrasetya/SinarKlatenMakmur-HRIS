/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : DepartmentDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:06:35
*/


-- ----------------------------
-- Table structure for Departments
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Departments]') AND type IN ('U'))
	DROP TABLE [dbo].[Departments]
GO

CREATE TABLE [dbo].[Departments] (
  [DepartmentID] int  IDENTITY(1,1) NOT NULL,
  [DepartmentName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DepartmentDescription] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsActive] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [CreatedBy] int DEFAULT 0 NOT NULL,
  [UpdatedAt] datetime2(7)  NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL,
  [Budget] int DEFAULT 0 NOT NULL
)
GO

ALTER TABLE [dbo].[Departments] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Departments
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Departments] ON
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'1', N'FGX', N'FGX', N'1', N'2018-01-17 10:55:36.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'2', N'GI 2', N'GI 2', N'1', N'2018-01-17 10:55:36.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'3', N'PRODUKSI', N'PRODUKSI', N'1', N'2018-01-17 10:55:36.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'4', N'PURCHASING', N'PURCHASING', N'1', N'2018-01-17 10:55:36.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'5', N'SECURITY', N'SECURITY', N'1', N'2018-06-25 14:56:16.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'6', N'CV.SK ', N'CV.SK ', N'1', N'2019-02-11 10:44:12.0000000', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'7', N'TATMI', N'TATMI', N'1', N'2019-04-01 14:22:13.0000000', N'0', NULL, N'0', N'0')
GO

SET IDENTITY_INSERT [dbo].[Departments] OFF
GO


-- ----------------------------
-- Auto increment value for Departments
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Departments]', RESEED, 16)
GO


-- ----------------------------
-- Primary Key structure for table Departments
-- ----------------------------
ALTER TABLE [dbo].[Departments] ADD CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED ([DepartmentID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

