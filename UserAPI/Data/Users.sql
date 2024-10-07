/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : UserDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 29/10/2023 15:31:03
*/


-- ----------------------------
-- Table structure for Users
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type IN ('U'))
	DROP TABLE [dbo].[Users]
GO

CREATE TABLE [dbo].[Users] (
  [UserId] int  IDENTITY(1,1) NOT NULL,
  [UserName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Password] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Role] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsActive] bit  NOT NULL,
  [Created_At] datetime2(7)  NULL,
  [CreatedBy] int  NULL,
  [UpdatedBy] int  NULL,
  [Updated_At] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[Users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Users
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Users] ON
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'1', N'ROOT', N'KBzUmpfe4rg=', N'Administrator', N'1', N'2014-08-19 09:34:21.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'2', N'HR', N'ld14mNVZrDQ=', N'User', N'1', N'2018-01-12 16:09:13.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'3', N'DELLA', N'ld14mNVZrDQ=', N'User', N'1', N'2018-01-15 11:30:00.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'4', N'DIKA', N'ld14mNVZrDQ=', N'User', N'1', N'2018-01-17 15:30:20.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'5', N'EVA', N'qfyCZp6Jg58=', N'User', N'1', N'2018-03-19 09:18:16.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'6', N'SARI', N'ld14mNVZrDQ=', N'User', N'1', N'2019-09-24 17:25:15.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'7', N'NATALI', N'yJZ4mxjSl8CuxNhcbvOYqQ==', N'User', N'1', N'2022-04-30 08:57:41.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'8', N'DIYANI', N'ezym0npAzi+uxNhcbvOYqQ==', N'User', N'1', N'2022-04-30 08:57:58.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'9', N'PKL', N'ozcWzeHpzK8=', N'User', N'1', N'2022-10-21 09:45:30.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'10', N'NAYLA', N'INfJCLkfaF4=', N'User', N'1', N'2023-01-10 08:13:48.0000000', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At]) VALUES (N'12', N'Yudhi', N'ingkung2481!', N'Administrator', N'1', N'2023-08-09 15:40:21.0000000', NULL, NULL, NULL)
GO

SET IDENTITY_INSERT [dbo].[Users] OFF
GO


-- ----------------------------
-- Auto increment value for Users
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Users]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

