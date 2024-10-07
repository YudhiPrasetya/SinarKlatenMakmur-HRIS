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

 Date: 29/10/2023 15:24:39
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

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'1', N'SK/QC JENI', N'1', N'2022-04-19 10:50:52.0000000', N'1', N'2022-04-19 10:50:52.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'3', N'SK/RESIGN', N'1', N'2022-04-19 10:42:49.0000000', N'1', N'2022-04-19 10:42:49.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'4', N'SK/STAFF', N'1', N'2018-02-27 15:24:40.0000000', N'1', N'2018-02-27 15:24:40.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'5', N'SK/CLEANING SERVICE', N'1', N'2022-03-23 11:11:42.0000000', N'1', N'2022-03-23 11:11:42.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'6', N'SK/LINE NARTI', N'1', N'2022-09-14 08:42:38.0000000', N'1', N'2022-09-14 08:42:38.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'7', N'SK/QC TRI', N'0', N'2023-06-16 10:11:32.0000000', N'1', N'2023-06-16 10:11:32.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'8', N'SK/LINE ARI TANTRI', N'1', N'2022-04-19 09:00:49.0000000', N'1', N'2022-04-19 09:00:49.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'9', N'SK/PACKING OUTERWEAR', N'1', N'2022-11-02 09:01:04.0000000', N'1', N'2022-11-02 09:01:04.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'10', N'SK/PACKING UNDERWEAR', N'1', N'2022-09-26 15:00:39.0000000', N'1', N'2022-09-26 15:00:39.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'12', N'SK/IRON', N'1', N'2018-04-13 09:22:51.0000000', N'1', N'2018-04-13 09:22:51.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'13', N'SK/PKL', N'1', N'2022-05-10 13:05:13.0000000', N'1', N'2022-05-10 13:05:13.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'14', N'SK/SECURITY', N'1', N'2022-04-30 08:57:55.0000000', N'1', N'2022-04-30 08:57:55.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'15', N'SK/CUTTING', N'1', N'2023-06-16 10:10:13.0000000', N'1', N'2023-06-16 10:10:13.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'16', N'SK/HT', N'1', N'2022-04-19 12:31:49.0000000', N'1', N'2022-04-19 12:31:49.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'17', N'SK/MEKANIK', N'1', N'2022-04-19 12:46:48.0000000', N'1', N'2022-04-19 12:46:48.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'18', N'SK/SECURITY WANITA', N'1', N'2022-04-19 12:54:33.0000000', N'1', N'2022-04-19 12:54:33.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'19', N'SK/DRIVER', N'1', N'2022-04-19 12:50:59.0000000', N'1', N'2022-04-19 12:50:59.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'20', N'SK/LINE ENDANG', N'1', N'2023-05-03 09:33:09.0000000', N'1', N'2023-05-03 09:33:09.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'21', N'SK/WAREHOUSE', N'1', N'2022-04-19 10:40:38.0000000', N'1', N'2022-04-19 10:40:38.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'22', N'SK/ADMIN', N'1', N'2023-03-31 10:08:52.0000000', N'1', N'2023-03-31 10:08:52.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'23', N'SK/QC GUNAWAN', N'1', N'2022-12-14 14:56:06.0000000', N'1', N'2022-12-14 14:56:06.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'24', N'SK/MOULDING', N'1', N'2022-06-28 10:26:35.0000000', N'1', N'2022-06-28 10:26:35.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'25', N'SK/QC MINCU', N'1', N'2023-03-29 15:35:49.0000000', N'1', N'2023-03-29 15:35:49.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'26', N'SK/QC MUJI', N'1', N'2022-12-14 14:55:48.0000000', N'1', N'2022-12-14 14:55:48.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'27', N'SK/PRESS', N'1', N'2022-04-19 11:43:45.0000000', N'1', N'2022-04-19 11:43:45.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'28', N'SK/SAMPLE', N'1', N'2022-07-29 14:24:50.0000000', N'1', N'2022-07-29 14:24:50.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'29', N'SK/SPOT CLEANING', N'1', N'2022-04-19 12:47:13.0000000', N'1', N'2022-04-19 12:47:13.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'30', N'SK/STAFF JAKARTA', N'1', N'2022-04-15 10:05:44.0000000', N'1', N'2022-04-15 10:05:44.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'31', N'SK/PATTERN', N'1', N'2021-12-30 14:59:09.0000000', N'1', N'2021-12-30 14:59:09.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'32', N'SK/PREPARATION', N'1', N'2021-12-30 14:59:57.0000000', N'1', N'2021-12-30 14:59:57.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'34', N'SK/CUTTING MOLDING 2', N'0', N'2023-03-18 10:19:32.0000000', N'1', N'2023-03-18 10:19:32.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'35', N'SK/LINE PIPIT', N'1', N'2022-04-14 16:13:41.0000000', N'1', N'2022-04-14 16:13:41.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'36', N'SK/LINE NUR', N'1', N'2022-04-14 16:15:39.0000000', N'1', N'2022-04-14 16:15:39.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'37', N'SK/LINE KRISTANTI', N'1', N'2022-12-14 14:25:18.0000000', N'1', N'2022-12-14 14:25:18.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'38', N'SK/LINE SUTARWI', N'1', N'2022-04-14 16:16:08.0000000', N'1', N'2022-04-14 16:16:08.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'39', N'SK/LINE DIKA', N'1', N'2022-04-14 16:16:20.0000000', N'1', N'2022-04-14 16:16:20.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'41', N'SK/LINE KRISTINA', N'1', N'2022-12-15 14:33:23.0000000', N'1', N'2022-12-15 14:33:23.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'42', N'SK/LINE YULIYANTI', N'0', N'2023-06-16 10:10:51.0000000', N'1', N'2023-06-16 10:10:51.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'43', N'SK/LINE KAMARI', N'1', N'2022-04-14 16:17:06.0000000', N'1', N'2022-04-14 16:17:06.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'44', N'SK/LINE APRI', N'0', N'2023-06-16 10:10:27.0000000', N'1', N'2023-06-16 10:10:27.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'45', N'SK/LINE ANNA', N'1', N'2022-04-14 16:17:27.0000000', N'1', N'2022-04-14 16:17:27.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'46', N'SK/LINE SUGIYANTI', N'1', N'2022-04-14 16:17:38.0000000', N'1', N'2022-04-14 16:17:38.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'47', N'SK/LINE WENI', N'1', N'2022-04-14 16:17:48.0000000', N'1', N'2022-04-14 16:17:48.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'48', N'SK/UNDER AGE', N'0', N'2023-03-18 10:20:15.0000000', N'1', N'2023-03-18 10:20:15.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'49', N'SK/TRIMSTORE', N'1', N'2022-06-20 13:15:38.0000000', N'1', N'2022-06-20 13:15:38.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'50', N'SK/LINE LINA', N'1', N'2022-12-26 10:47:54.0000000', N'1', N'2022-12-26 10:47:54.0000000', N'1')
GO

INSERT INTO [dbo].[Groups] ([GroupID], [GroupDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'51', N'Undefined', N'1', N'1970-01-01 00:00:00.0000000', N'1', N'1970-01-01 00:00:00.0000000', N'1')
GO

SET IDENTITY_INSERT [dbo].[Groups] OFF
GO


-- ----------------------------
-- Auto increment value for Groups
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Groups]', RESEED, 52)
GO


-- ----------------------------
-- Primary Key structure for table Groups
-- ----------------------------
ALTER TABLE [dbo].[Groups] ADD CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

