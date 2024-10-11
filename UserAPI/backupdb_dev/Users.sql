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

 Date: 11/10/2024 09:18:25
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
  [Updated_At] datetime2(7)  NULL,
  [Scopes] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [RefreshToken] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [RefreshTokenExpiryTime] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[Users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Users
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Users] ON
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'2', N'Yudhi Prasetya', N'1f313c5478b3842db42187a7d494a787efa53388a55b0de35843b4b04dcc040c', N'Admin', N'1', NULL, NULL, NULL, NULL, N'users.read; users.post; users.put; users.delete; ', NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'3', N'Fitri W', N'9343787923d8ab8b0501c0378480c7306da06c16dad6e621612d7eaa1979eaa9', N'User', N'0', NULL, NULL, NULL, NULL, N'users.read; ', NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'4', N'Azlan', N'8449a312d2e3d96ff3157c9c3350b2c29e3b391f6033a622ddbb9d93876c289c', N'User', N'0', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'5', N'Evano', N'f35bbc884bc64e8cc6615f009b438d03464ef95cc6d8f05ae447610d23b67f9a', N'User', N'0', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'6', N'Security1', N'851501c1697bf3f346ae7527d70bb4f874e8fa3ce8148cfd5b888370acb880eb', N'Security', N'0', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'7', N'SPV1', N'10114e63252ddad167d19ce4fab84da280d88014231c0fe28518414bb678a742', N'Supervisor', N'0', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[Users] ([UserId], [UserName], [Password], [Role], [IsActive], [Created_At], [CreatedBy], [UpdatedBy], [Updated_At], [Scopes], [RefreshToken], [RefreshTokenExpiryTime]) VALUES (N'8', N'Yudhi2', N'1f313c5478b3842db42187a7d494a787efa53388a55b0de35843b4b04dcc040c', N'Admin', N'0', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO

SET IDENTITY_INSERT [dbo].[Users] OFF
GO


-- ----------------------------
-- Auto increment value for Users
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Users]', RESEED, 8)
GO


-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

