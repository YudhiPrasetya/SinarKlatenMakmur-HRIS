/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : ExceptionsTypeDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:08:08
*/


-- ----------------------------
-- Table structure for ExceptionTypes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExceptionTypes]') AND type IN ('U'))
	DROP TABLE [dbo].[ExceptionTypes]
GO

CREATE TABLE [dbo].[ExceptionTypes] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [ExceptionName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ExceptionTypes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ExceptionTypes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ExceptionTypes] ON
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'1', N'SAKIT DENGAN SURAT DOKTER')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'2', N'SAKIT TANPA SURAT DOKTER')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'3', N'CUTI MENIKAH')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'4', N'CUTI KERABAT MENINGGAL')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'5', N'CUTI MENIKAH')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'6', N'IJIN')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'7', N'CUTI TAHUNAN')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'8', N'CUTI MELAHIRKAN')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'9', N'ALPA')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'10', N'CUTI ISTRI MELAHIRKAN')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'11', N'CUTI MENGKHITANKAN/MENIKAHKAN ANAK')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'12', N'CUTI KEGUGURAN')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'13', N'CUTI MENIKAHKAN ANAK')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'14', N'CUTI KELUARGA DALAM 1 RUMAH MENINGGAL')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'15', N'CUTI HAID')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'16', N'CUTI IBADAH HAJI/UMROH')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'17', N'CUTI BERSAMA')
GO

INSERT INTO [dbo].[ExceptionTypes] ([Id], [ExceptionName]) VALUES (N'18', N'CUTI TAHUNAN')
GO

SET IDENTITY_INSERT [dbo].[ExceptionTypes] OFF
GO


-- ----------------------------
-- Auto increment value for ExceptionTypes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ExceptionTypes]', RESEED, 18)
GO


-- ----------------------------
-- Primary Key structure for table ExceptionTypes
-- ----------------------------
ALTER TABLE [dbo].[ExceptionTypes] ADD CONSTRAINT [PK_ExceptionTypes] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

