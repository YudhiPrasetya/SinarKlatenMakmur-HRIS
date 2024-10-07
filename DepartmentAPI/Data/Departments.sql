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

 Date: 29/10/2023 15:23:31
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

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'1', N'FGX', N'FGX Desc', N'1', N'2023-09-09 12:17:27.7030000', N'1', N'2023-09-09 12:17:27.7030000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'2', N'GI 2', N'GI 2 ', N'0', N'2023-09-09 07:33:03.6640000', N'1', N'2023-09-09 07:33:03.6640000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'3', N'PRODUKSI', N'PRODUKSI Desc', N'1', N'2018-01-17 10:55:36.0000000', N'1', N'2018-01-17 10:55:36.0000000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'4', N'PURCHASING', N'PURCHASING Desc', N'1', N'2018-01-17 10:55:36.0000000', N'1', N'2018-01-17 10:55:36.0000000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'5', N'SECURITY', N'SECURITY Desc', N'1', N'2018-06-25 14:56:16.0000000', N'1', N'2018-06-25 14:56:16.0000000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'6', N'CV.SK ', N'CV.SK Desc', N'1', N'2019-02-11 10:44:12.0000000', N'1', N'2019-02-11 10:44:12.0000000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'7', N'TATMI', N'TATMI Desc', N'1', N'2019-04-01 14:22:13.0000000', N'1', N'2019-04-01 14:22:13.0000000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'8', N'ffssdfdsf', N'ddfaddasd-updated', N'1', N'2023-09-06 13:25:36.0350000', N'1', N'2023-09-06 13:25:36.0350000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'10', N'xdxdxdxd', N'fdggdgdfggdfgdf', N'1', N'2023-09-06 10:45:09.3180000', N'1', N'2023-09-06 10:45:09.3180000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'11', N'xxsdsdsd', N'fdsgsdfkkok', N'1', N'2023-09-06 10:57:24.4580000', N'1', N'2023-09-06 10:57:24.4580000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'12', N'tttt', N'tttytyty-update', N'1', N'2023-09-07 16:45:21.7350000', N'1', N'2023-09-07 16:45:21.7350000', N'1', N'0')
GO

INSERT INTO [dbo].[Departments] ([DepartmentID], [DepartmentName], [DepartmentDescription], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Budget]) VALUES (N'13', N'lllll', N'llllll', N'0', N'2023-09-06 14:12:49.5330000', N'1', N'2023-09-06 14:12:49.5330000', N'1', N'0')
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

