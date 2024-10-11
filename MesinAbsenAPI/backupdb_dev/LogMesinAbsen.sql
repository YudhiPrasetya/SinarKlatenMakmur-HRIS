/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : MesinAbsenDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:12:03
*/


-- ----------------------------
-- Table structure for LogMesinAbsen
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LogMesinAbsen]') AND type IN ('U'))
	DROP TABLE [dbo].[LogMesinAbsen]
GO

CREATE TABLE [dbo].[LogMesinAbsen] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [IPMesin] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PortMesin] int  NULL,
  [NoMesin] int  NULL,
  [NIK] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tgl] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[LogMesinAbsen] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LogMesinAbsen
-- ----------------------------
SET IDENTITY_INSERT [dbo].[LogMesinAbsen] ON
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'586', N'192.168.94.94', N'4370', N'3', N'07080028', N'2024-09-19 21:31:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'587', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-01 07:30:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'588', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-01 23:00:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'589', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-04 06:08:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'590', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-04 15:31:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'591', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-05 06:11:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'592', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-05 15:31:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'593', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-06 14:11:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'594', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-06 23:02:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'595', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-07 21:54:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'596', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-08 07:31:54.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'597', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-08 22:03:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'598', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-09 07:31:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'599', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-11 06:12:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'600', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-11 15:33:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'601', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-12 06:05:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'602', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-12 15:31:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'603', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-13 14:15:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'604', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-13 23:01:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'605', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-14 22:13:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'606', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-15 07:30:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'607', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-15 22:11:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'608', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-16 07:30:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'609', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-18 14:13:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'610', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-18 23:00:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'611', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-19 13:56:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'612', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-19 23:00:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'613', N'192.168.94.94', N'4370', N'3', N'240410028', N'2024-09-20 14:02:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'614', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-02 07:23:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'615', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-02 16:24:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'616', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-05 07:12:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'617', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-05 18:43:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'618', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-10 07:15:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'619', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-10 16:22:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'620', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-13 07:16:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'621', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-13 16:39:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'622', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-14 07:55:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'623', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-14 16:00:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'624', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-19 07:19:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'625', N'192.168.94.94', N'4370', N'3', N'240410040', N'2024-09-19 16:45:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'626', N'192.168.94.94', N'4370', N'3', N'240410055', N'2024-09-12 07:11:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'627', N'192.168.94.94', N'4370', N'3', N'240410055', N'2024-09-20 07:11:58.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'628', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-02 17:44:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'629', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-04 16:41:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'630', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-05 18:19:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'631', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-06 18:05:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'632', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-09 07:06:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'633', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-09 17:38:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'634', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-13 17:25:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'635', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-18 17:32:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'636', N'192.168.94.94', N'4370', N'3', N'240410056', N'2024-09-19 18:46:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'637', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-02 06:26:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'638', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-02 15:32:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'639', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-03 06:23:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'640', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-03 15:30:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'641', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-04 14:24:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'642', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-04 23:01:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'643', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-05 14:23:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'644', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-05 23:00:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'645', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-06 22:18:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'646', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-07 07:36:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'647', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-09 06:26:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'648', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-10 06:20:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'649', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-10 15:31:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'650', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-11 06:23:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'651', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-11 15:34:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'652', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-12 14:23:46.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'653', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-12 23:08:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'654', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-13 22:20:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'655', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-14 07:35:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'656', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-16 06:20:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'657', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-16 15:30:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'658', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-17 06:10:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'659', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-17 15:30:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'660', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-18 22:12:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'661', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-19 07:30:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'662', N'192.168.94.94', N'4370', N'3', N'240410071', N'2024-09-19 23:00:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'663', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-01 22:21:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'664', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-02 07:35:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'665', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-02 23:01:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'666', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-03 22:12:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'667', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-04 07:30:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'668', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-04 22:18:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'669', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-05 07:30:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'670', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-07 15:31:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'671', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-08 14:17:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'672', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-08 23:00:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'673', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-09 14:15:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'674', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-09 23:00:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'675', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-10 22:22:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'676', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-11 07:40:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'677', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-11 22:17:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'678', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-12 07:40:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'679', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-14 06:25:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'680', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-14 15:33:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'681', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-15 06:19:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'682', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-15 15:31:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'683', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-16 14:15:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'684', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-16 23:01:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'685', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-17 22:12:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'686', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-18 22:16:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'687', N'192.168.94.94', N'4370', N'3', N'240410072', N'2024-09-19 07:30:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'688', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-01 14:41:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'689', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-01 23:01:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'690', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-02 22:29:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'691', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-03 07:32:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'692', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-05 22:28:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'693', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-06 07:39:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'694', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-06 21:41:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'695', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-07 07:34:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'696', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-08 06:31:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'697', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-08 15:33:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'698', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-09 22:28:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'699', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-10 07:37:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'700', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-12 22:27:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'701', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-14 07:36:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'702', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-14 23:04:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'703', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-15 14:36:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'704', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-15 23:01:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'705', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-16 22:22:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'706', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-17 07:34:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'707', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-19 22:23:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'708', N'192.168.94.94', N'4370', N'3', N'240410073', N'2024-09-20 07:35:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'709', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-01 06:56:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'710', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-01 16:01:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'711', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-02 06:58:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'712', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-06 07:17:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'713', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-06 16:39:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'714', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-11 07:17:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'715', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-11 16:29:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'716', N'192.168.94.94', N'4370', N'3', N'240410075', N'2024-09-20 07:08:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'717', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-02 06:37:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'718', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-02 15:34:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'719', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-03 14:26:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'720', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-04 23:02:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'721', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-05 14:19:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'722', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-06 06:27:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'723', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-06 15:32:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'724', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-07 22:24:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'725', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-08 07:34:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'726', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-10 14:18:58.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'727', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-10 23:14:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'728', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-11 14:32:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'729', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-11 23:05:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'730', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-12 14:14:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'731', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-12 23:57:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'732', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-13 14:19:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'733', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-13 23:01:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'734', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-14 22:24:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'735', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-17 14:20:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'736', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-17 22:48:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'737', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-18 06:21:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'738', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-18 15:35:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'739', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-19 06:24:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'740', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-19 15:35:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'741', N'192.168.94.94', N'4370', N'3', N'240410086', N'2024-09-20 06:26:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'742', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-01 06:29:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'743', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-01 15:33:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'744', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-02 15:32:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'745', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-03 06:18:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'746', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-03 15:30:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'747', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-06 06:25:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'748', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-06 15:35:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'749', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-07 06:16:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'750', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-07 15:31:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'751', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-08 23:03:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'752', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-09 06:25:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'753', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-09 15:37:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'754', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-10 06:19:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'755', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-10 15:33:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'756', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-13 06:23:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'757', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-13 15:37:54.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'758', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-14 06:19:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'759', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-14 15:32:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'760', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-15 23:01:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'761', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-16 23:03:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'762', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-17 06:19:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'763', N'192.168.94.94', N'4370', N'3', N'240410092', N'2024-09-20 06:32:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'764', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-01 07:31:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'765', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-01 22:24:58.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'766', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-02 07:33:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'767', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-02 22:23:58.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'768', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-03 07:34:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'769', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-05 06:18:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'770', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-05 15:31:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'771', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-06 06:20:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'772', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-06 15:31:46.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'773', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-07 14:28:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'774', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-07 23:09:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'775', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-08 22:25:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'776', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-09 07:31:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'777', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-09 22:26:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'778', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-10 07:31:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'779', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-12 06:28:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'780', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-12 15:31:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'781', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-13 06:22:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'782', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-13 15:32:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'783', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-14 14:27:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'784', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-14 23:03:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'785', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-15 22:26:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'786', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-16 07:31:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'787', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-16 22:20:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'788', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-17 07:33:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'789', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-19 06:22:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'790', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-19 15:31:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'791', N'192.168.94.94', N'4370', N'3', N'240410099', N'2024-09-20 06:23:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'792', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-01 06:27:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'793', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-01 15:32:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'794', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-02 14:28:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'795', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-02 23:03:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'796', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-03 14:27:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'797', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-03 23:29:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'798', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-04 06:33:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'799', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-04 16:03:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'800', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-05 06:35:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'801', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-05 16:01:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'802', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-08 06:31:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'803', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-08 15:33:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'804', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-09 14:30:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'805', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-09 23:01:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'806', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-10 14:28:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'807', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-10 23:15:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'808', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-11 22:21:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'809', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-12 08:18:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'810', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-12 22:18:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'811', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-13 07:35:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'812', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-15 06:34:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'813', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-15 15:32:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'814', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-16 06:32:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'815', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-16 15:32:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'816', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-17 14:30:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'817', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-17 23:03:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'818', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-18 06:27:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'819', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-18 16:16:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'820', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-19 22:28:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'821', N'192.168.94.94', N'4370', N'3', N'240410100', N'2024-09-20 07:37:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'822', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-02 15:32:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'823', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-03 06:59:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'824', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-03 16:58:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'825', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-04 16:27:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'826', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-09 06:47:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'827', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-09 17:15:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'828', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-10 06:54:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'829', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-10 16:17:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'830', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-11 06:50:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'831', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-11 17:57:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'832', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-12 06:55:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'833', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-12 19:10:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'834', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-13 06:51:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'835', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-13 16:42:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'836', N'192.168.94.94', N'4370', N'3', N'240410310', N'2024-09-19 16:05:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'837', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-01 06:47:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'838', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-01 16:03:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'839', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-02 07:03:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'840', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-02 16:23:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'841', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-03 06:59:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'842', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-03 16:35:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'843', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-04 07:04:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'844', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-04 16:28:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'845', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-11 07:04:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'846', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-11 16:28:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'847', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-12 07:01:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'848', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-12 16:25:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'849', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-13 07:02:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'850', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-13 16:40:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'851', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-14 06:50:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'852', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-14 16:01:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'853', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-17 07:05:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'854', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-17 16:26:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'855', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-18 07:01:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'856', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-18 16:33:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'857', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-19 07:00:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'858', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-19 16:44:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'859', N'192.168.94.94', N'4370', N'3', N'240410314', N'2024-09-20 07:01:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'860', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-02 07:14:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'861', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-02 16:15:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'862', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-03 07:23:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'863', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-03 16:15:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'864', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-04 07:09:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'865', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-05 07:23:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'866', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-05 16:21:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'867', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-06 07:21:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'868', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-06 16:36:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'869', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-09 07:17:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'870', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-09 16:22:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'871', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-10 07:08:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'872', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-10 16:19:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'873', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-11 07:17:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'874', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-11 16:16:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'875', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-12 07:09:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'876', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-12 16:15:46.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'877', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-13 07:10:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'878', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-13 16:31:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'879', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-17 07:14:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'880', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-18 07:11:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'881', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-18 16:23:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'882', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-19 07:17:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'883', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-19 16:24:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'884', N'192.168.94.94', N'4370', N'3', N'240410319', N'2024-09-20 07:17:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'885', N'192.168.94.94', N'4370', N'3', N'240410380', N'2024-09-02 07:14:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'886', N'192.168.94.94', N'4370', N'3', N'240410396', N'2024-09-19 21:31:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'887', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-02 07:32:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'888', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-02 16:24:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'889', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-03 07:33:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'890', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-03 16:22:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'891', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-04 16:25:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'892', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-05 07:26:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'893', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-06 07:24:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'894', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-06 16:46:46.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'895', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-09 07:27:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'896', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-09 16:26:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'897', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-10 07:30:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'898', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-10 16:26:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'899', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-11 07:31:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'900', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-11 16:28:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'901', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-12 07:24:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'902', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-12 16:18:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'903', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-13 07:26:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'904', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-17 07:33:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'905', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-18 07:38:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'906', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-18 16:51:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'907', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-19 07:31:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'908', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-19 16:23:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'909', N'192.168.94.94', N'4370', N'3', N'240410433', N'2024-09-20 07:29:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'910', N'192.168.94.94', N'4370', N'3', N'240410437', N'2024-09-12 07:10:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'911', N'192.168.94.94', N'4370', N'3', N'240410437', N'2024-09-20 07:12:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'912', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-02 14:14:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'913', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-02 23:02:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'914', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-03 22:13:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'915', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-04 07:31:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'916', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-04 22:15:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'917', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-05 07:32:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'918', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-06 07:31:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'919', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-06 23:02:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'920', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-09 06:14:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'921', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-09 15:52:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'922', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-10 22:15:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'923', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-11 07:40:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'924', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-11 23:01:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'925', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-12 06:17:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'926', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-12 15:31:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'927', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-13 06:18:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'928', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-13 15:34:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'929', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-16 06:16:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'930', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-16 15:31:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'931', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-17 22:16:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'932', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-18 07:33:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'933', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-18 23:00:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'934', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-19 06:16:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'935', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-19 15:31:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'936', N'192.168.94.94', N'4370', N'3', N'240410447', N'2024-09-20 14:16:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'937', N'192.168.94.94', N'4370', N'3', N'240410474', N'2024-09-06 16:46:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'938', N'192.168.94.94', N'4370', N'3', N'240410474', N'2024-09-09 07:02:58.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'939', N'192.168.94.94', N'4370', N'3', N'240410474', N'2024-09-09 16:25:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'940', N'192.168.94.94', N'4370', N'3', N'240410474', N'2024-09-10 07:13:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'941', N'192.168.94.94', N'4370', N'3', N'240410474', N'2024-09-10 16:26:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'942', N'192.168.94.94', N'4370', N'3', N'240410481', N'2024-09-19 21:30:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'943', N'192.168.94.94', N'4370', N'3', N'240410484', N'2024-09-05 17:48:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'944', N'192.168.94.94', N'4370', N'3', N'240410499', N'2024-09-11 07:00:37.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'945', N'192.168.94.94', N'4370', N'3', N'240410499', N'2024-09-12 07:06:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'946', N'192.168.94.94', N'4370', N'3', N'240410499', N'2024-09-13 07:25:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'947', N'192.168.94.94', N'4370', N'3', N'240410499', N'2024-09-17 07:07:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'948', N'192.168.94.94', N'4370', N'3', N'240410499', N'2024-09-18 07:07:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'949', N'192.168.94.94', N'4370', N'3', N'240410503', N'2024-09-19 21:30:46.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'950', N'192.168.94.94', N'4370', N'3', N'240410506', N'2024-09-02 16:37:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'951', N'192.168.94.94', N'4370', N'3', N'240410506', N'2024-09-04 16:54:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'952', N'192.168.94.94', N'4370', N'3', N'240410506', N'2024-09-05 16:32:16.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'953', N'192.168.94.94', N'4370', N'3', N'240410506', N'2024-09-13 16:44:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'954', N'192.168.94.94', N'4370', N'3', N'240410507', N'2024-09-19 21:30:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'955', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-03 16:33:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'956', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-04 16:33:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'957', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-05 16:38:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'958', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-09 16:35:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'959', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-11 16:28:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'960', N'192.168.94.94', N'4370', N'3', N'240410513', N'2024-09-13 16:35:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'961', N'192.168.94.94', N'4370', N'3', N'240410515', N'2024-09-19 21:30:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'962', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-02 07:35:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'963', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-02 16:24:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'964', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-04 07:32:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'965', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-04 16:25:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'966', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-06 16:46:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'967', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-09 07:28:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'968', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-10 16:25:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'969', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-11 16:28:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'970', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-12 07:30:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'971', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-12 16:18:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'972', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-18 07:30:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'973', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-18 16:51:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'974', N'192.168.94.94', N'4370', N'3', N'240410520', N'2024-09-19 16:23:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'975', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-09 16:51:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'976', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-12 07:22:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'977', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-12 17:32:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'978', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-13 17:23:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'979', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-18 17:32:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'980', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-19 17:13:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'981', N'192.168.94.94', N'4370', N'3', N'240410531', N'2024-09-20 07:27:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'982', N'192.168.94.94', N'4370', N'3', N'240410541', N'2024-09-19 21:31:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'983', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-02 07:44:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'984', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-02 16:42:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'985', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-03 07:30:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'986', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-03 16:41:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'987', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-05 07:42:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'988', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-05 16:45:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'989', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-06 20:13:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'990', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-09 07:29:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'991', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-10 18:00:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'992', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-11 07:29:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'993', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-11 17:34:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'994', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-12 07:37:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'995', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-12 17:23:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'996', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-19 07:49:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'997', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-19 17:30:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'998', N'192.168.94.94', N'4370', N'3', N'240410552', N'2024-09-20 07:40:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'999', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-02 07:47:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1000', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-03 07:37:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1001', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-04 07:45:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1002', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-05 07:36:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1003', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-06 07:50:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1004', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-09 07:52:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1005', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-10 07:43:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1006', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-10 17:18:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1007', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-11 07:50:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1008', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-12 07:50:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1009', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-12 17:11:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1010', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-13 07:36:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1011', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-18 07:49:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1012', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-19 08:03:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1013', N'192.168.94.94', N'4370', N'3', N'240410553', N'2024-09-20 07:43:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1014', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-02 17:44:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1015', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-04 07:19:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1016', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-04 18:25:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1017', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-05 18:19:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1018', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-06 18:05:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1019', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-09 07:16:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1020', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-09 17:38:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1021', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-10 07:10:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1022', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-10 18:00:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1023', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-11 07:15:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1024', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-11 17:34:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1025', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-12 07:08:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1026', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-12 17:32:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1027', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-13 07:14:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1028', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-13 17:07:55.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1029', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-18 07:11:56.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1030', N'192.168.94.94', N'4370', N'3', N'240410556', N'2024-09-18 17:32:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1031', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-04 07:19:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1032', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-09 07:16:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1033', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-09 17:11:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1034', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-10 07:10:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1035', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-11 07:15:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1036', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-12 07:09:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1037', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-12 17:23:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1038', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-13 07:14:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1039', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-18 07:12:06.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1040', N'192.168.94.94', N'4370', N'3', N'240410558', N'2024-09-20 07:18:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1041', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-01 06:56:27.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1042', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-01 16:01:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1043', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-02 06:48:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1044', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-02 16:29:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1045', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-03 06:50:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1046', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-03 16:40:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1047', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-04 06:54:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1048', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-04 16:33:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1049', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-05 06:58:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1050', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-05 16:17:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1051', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-06 06:59:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1052', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-06 16:40:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1053', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-09 06:55:43.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1054', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-09 16:31:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1055', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-10 06:59:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1056', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-10 16:36:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1057', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-11 06:58:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1058', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-11 16:43:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1059', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-12 06:56:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1060', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-12 16:19:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1061', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-13 06:50:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1062', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-13 16:42:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1063', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-14 06:58:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1064', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-14 16:02:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1065', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-17 06:57:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1066', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-17 16:46:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1067', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-18 06:59:02.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1068', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-18 16:51:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1069', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-19 06:55:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1070', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-19 16:48:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1071', N'192.168.94.94', N'4370', N'3', N'240410567', N'2024-09-20 06:55:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1072', N'192.168.94.94', N'4370', N'3', N'240410569', N'2024-09-11 17:13:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1073', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-03 06:51:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1074', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-03 16:19:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1075', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-04 06:38:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1076', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-04 16:17:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1077', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-09 06:33:52.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1078', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-09 16:15:08.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1079', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-12 06:30:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1080', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-12 16:15:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1081', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-18 06:29:31.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1082', N'192.168.94.94', N'4370', N'3', N'240510037', N'2024-09-18 16:18:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1083', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-02 07:26:13.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1084', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-03 07:31:34.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1085', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-04 07:32:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1086', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-05 07:31:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1087', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-06 07:32:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1088', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-09 07:35:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1089', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-11 07:34:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1090', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-12 07:28:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1091', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-13 07:30:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1092', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-17 07:29:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1093', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-18 07:42:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1094', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-19 07:34:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1095', N'192.168.94.94', N'4370', N'3', N'240710019', N'2024-09-20 07:34:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1096', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-02 07:26:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1097', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-03 07:30:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1098', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-04 07:27:54.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1099', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-05 07:31:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1100', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-06 07:24:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1101', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-09 07:23:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1102', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-10 07:11:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1103', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-11 07:27:26.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1104', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-12 07:33:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1105', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-13 07:26:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1106', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-17 07:18:35.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1107', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-18 07:23:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1108', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-19 07:17:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1109', N'192.168.94.94', N'4370', N'3', N'240710020', N'2024-09-20 07:30:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1110', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-02 07:23:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1111', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-02 15:25:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1112', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-04 07:24:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1113', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-05 07:29:03.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1114', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-06 07:20:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1115', N'192.168.94.94', N'4370', N'3', N'240710021', N'2024-09-09 07:25:36.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1116', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-02 07:32:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1117', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-02 15:33:57.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1118', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-03 07:32:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1119', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-04 07:31:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1120', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-05 07:24:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1121', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-06 07:30:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1122', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-09 07:25:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1123', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-10 07:27:10.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1124', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-11 07:25:21.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1125', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-12 07:20:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1126', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-13 07:21:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1127', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-17 15:07:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1128', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-18 07:24:11.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1129', N'192.168.94.94', N'4370', N'3', N'240710022', N'2024-09-19 07:20:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1130', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-02 07:25:25.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1131', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-04 07:28:30.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1132', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-05 07:33:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1133', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-06 07:32:00.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1134', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-09 07:37:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1135', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-10 08:29:39.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1136', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-11 07:32:18.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1137', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-12 07:31:23.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1138', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-13 07:34:28.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1139', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-17 07:28:17.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1140', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-18 07:30:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1141', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-19 07:30:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1142', N'192.168.94.94', N'4370', N'3', N'240710023', N'2024-09-20 07:31:42.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1143', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-02 07:35:49.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1144', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-03 07:30:40.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1145', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-04 07:22:41.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1146', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-05 07:27:09.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1147', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-06 07:32:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1148', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-09 07:25:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1149', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-10 07:39:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1150', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-11 07:28:45.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1151', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-12 07:33:15.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1152', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-13 07:34:48.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1153', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-17 07:25:04.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1154', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-18 07:27:07.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1155', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-19 07:19:32.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1156', N'192.168.94.94', N'4370', N'3', N'240710024', N'2024-09-20 07:24:59.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1157', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-02 07:23:14.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1158', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-02 15:33:53.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1159', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-03 07:32:47.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1160', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-04 07:24:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1161', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-05 07:18:20.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1162', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-06 07:14:44.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1163', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-09 07:19:22.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1164', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-10 07:05:29.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1165', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-10 15:06:01.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1166', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-11 07:18:50.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1167', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-12 07:17:19.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1168', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-13 07:17:38.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1169', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-17 07:13:05.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1170', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-18 07:24:24.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1171', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-19 07:13:33.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'1172', N'192.168.94.94', N'4370', N'3', N'240710025', N'2024-09-20 07:15:12.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2013', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-01 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2014', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-02 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2015', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-03 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2016', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-04 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2017', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-05 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2018', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-06 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2019', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-07 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2020', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-08 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2021', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-09 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2022', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-10 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2023', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-11 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2024', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-12 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2025', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-13 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2026', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-14 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2027', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-15 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2028', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-16 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2029', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-17 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2030', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-18 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2031', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-19 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2032', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-20 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2033', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-21 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2034', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-22 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2035', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-23 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2036', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-24 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2037', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-25 07:26:51.0000000')
GO

INSERT INTO [dbo].[LogMesinAbsen] ([id], [IPMesin], [PortMesin], [NoMesin], [NIK], [Tgl]) VALUES (N'2038', N'192.168.94.94', N'4037', N'3', N'240410433', N'2024-09-26 07:26:51.0000000')
GO

SET IDENTITY_INSERT [dbo].[LogMesinAbsen] OFF
GO


-- ----------------------------
-- Auto increment value for LogMesinAbsen
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[LogMesinAbsen]', RESEED, 2038)
GO


-- ----------------------------
-- Primary Key structure for table LogMesinAbsen
-- ----------------------------
ALTER TABLE [dbo].[LogMesinAbsen] ADD CONSTRAINT [PK__LogMesin__3213E83FC93B2232] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

