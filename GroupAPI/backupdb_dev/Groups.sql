/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : GroupDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:09:26
*/


-- ----------------------------
-- Table structure for Groups
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Groups]') AND type IN ('U'))
	DROP TABLE [dbo].[Groups]
GO

CREATE TABLE [dbo].[Groups] (
  [GroupID] int  IDENTITY(1,1) NOT NULL,
  [GroupDesc] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsActive] bit  NOT NULL,
  [CreatedAt] datetime2(7)  NOT NULL,
  [CreatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7) DEFAULT '0001-01-01T00:00:00.0000000' NOT NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL
)
GO

ALTER TABLE [dbo].[Groups] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Groups
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Groups] ON
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'1', N'ADMIN INVENTORY', N'1', N'2024-05-07 17:12:03.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'3', N'RESIGN', N'1', N'2024-05-07 16:09:51.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'4', N'STAFF', N'1', N'2024-05-07 17:12:29.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'5', N'CLEANING SERVICE', N'1', N'2024-05-07 15:20:27.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'6', N'SHIFT 1 LINE SUTARWI', N'1', N'2024-05-07 15:57:40.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'7', N'ADMIN IE', N'1', N'2024-05-07 15:15:09.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'8', N'SHIFT 1 LINE ARI TANTRI', N'1', N'2024-05-07 15:54:30.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'9', N'PACKING OUTERWEAR', N'1', N'2024-05-07 16:09:29.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'10', N'PACKING UNDERWEAR', N'1', N'2024-05-07 16:09:37.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'12', N'PACKING / IRON', N'1', N'2024-05-07 16:32:12.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'13', N'MAGANG PKL', N'1', N'2024-05-07 16:05:10.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'14', N'SECURITY PRIA', N'1', N'2024-05-07 15:22:39.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'15', N'CUTTING', N'1', N'2024-05-07 15:47:45.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'16', N'PADPRINT', N'1', N'2024-05-07 16:36:31.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'17', N'GENERAL MAINTENANCE', N'1', N'2024-05-07 16:01:26.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'18', N'SECURITY WANITA', N'1', N'2024-05-07 15:22:50.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'19', N'DRIVER', N'1', N'2024-05-07 15:20:18.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'20', N'SHIFT 1 LINE ENDANG 1', N'1', N'2024-05-07 15:55:39.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'21', N'WAREHOUSE FABRIC', N'1', N'2024-05-07 16:03:37.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'22', N'QC CUTTING', N'1', N'2024-05-07 15:44:37.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'23', N'QC AQL', N'1', N'2024-05-07 17:10:48.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'24', N'MOULDING', N'1', N'2024-05-07 15:21:29.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'25', N'QC ENDLINE', N'1', N'2024-05-07 16:52:37.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'26', N'QC SAMPLE', N'1', N'2024-05-07 17:28:00.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'27', N'MOULDING / PRESS', N'1', N'2024-05-07 16:32:49.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'28', N'SAMPLE', N'1', N'2024-05-07 16:06:41.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'29', N'QC WASHTEST', N'1', N'2024-05-07 16:33:20.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'30', N'WAREHOUSE ACC', N'1', N'2024-05-07 16:03:54.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'31', N'ADMIN SAMPLE', N'1', N'2024-05-07 16:06:19.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'32', N'STB / PREPARATION', N'1', N'2024-05-07 17:28:32.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'35', N'SHIFT 1 LINE PIPIT', N'1', N'2024-05-07 15:57:10.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'36', N'SHIFT 1 LINE NUR', N'1', N'2024-05-07 15:56:59.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'37', N'SHIFT 1 LINE ENDANG 2', N'1', N'2024-05-07 15:55:54.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'38', N'SHIFT 1 LINE SUTARWI 2', N'1', N'2024-05-07 15:57:50.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'39', N'SHIFT 1 LINE DIKA', N'1', N'2024-05-07 15:55:26.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'41', N'SHIFT 1 LINE SUGIYANTI 1', N'1', N'2024-05-07 15:57:21.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'42', N'ADMIN MEKANIK', N'1', N'2024-05-07 15:14:17.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'43', N'SHIFT 1 LINE KAMARI', N'1', N'2024-05-07 15:56:10.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'44', N'STAFF GI 1', N'1', N'2024-05-07 16:10:23.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'45', N'SHIFT 1 LINE ANNA', N'1', N'2024-05-07 15:47:35.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'46', N'SHIFT 1 LINE SUGIYANTI 2', N'1', N'2024-05-07 15:57:31.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'47', N'SHIFT 1 LINE WENI', N'1', N'2024-05-07 15:58:01.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'48', N'ADMIN WAREHOUSE', N'1', N'2024-05-07 15:17:01.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'49', N'QC IN LINE', N'1', N'2024-05-07 16:40:25.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'50', N'QC INCOMING', N'1', N'2024-05-07 15:56:39.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'52', N'CLEANING SERVICE / HARIAN', N'1', N'2024-06-03 09:14:17.0000000', N'1', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'53', N'GROUP PAGI', N'1', N'2024-06-10 16:45:01.8100000', N'1', N'2024-06-10 16:45:05.1297484', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'54', N'GROUP PAGI', N'1', N'2024-06-10 16:45:03.8330000', N'1', N'2024-06-10 16:45:05.8366033', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'55', N'GROUP PAGI', N'1', N'2024-06-10 16:45:04.0240000', N'1', N'2024-06-10 16:45:06.0254605', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'56', N'GROUP PAGI', N'1', N'2024-06-10 16:45:03.1200000', N'1', N'2024-06-10 16:45:06.1304856', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'57', N'GROUP PAGI', N'1', N'2024-06-10 16:45:03.6360000', N'1', N'2024-06-10 16:45:06.6516557', N'1')
GO

SET IDENTITY_INSERT [dbo].[Groups] OFF
GO


-- ----------------------------
-- Auto increment value for Groups
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Groups]', RESEED, 57)
GO


-- ----------------------------
-- Primary Key structure for table Groups
-- ----------------------------
ALTER TABLE [dbo].[Groups] ADD CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

