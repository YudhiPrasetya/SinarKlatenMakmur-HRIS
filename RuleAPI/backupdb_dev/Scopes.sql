/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : RuleDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:14:50
*/


-- ----------------------------
-- Table structure for Scopes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Scopes]') AND type IN ('U'))
	DROP TABLE [dbo].[Scopes]
GO

CREATE TABLE [dbo].[Scopes] (
  [ScopeId] int  NOT NULL,
  [GroupIcon] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [GroupTitle] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MenuIcon] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MenuTitle] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Route] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Scope] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Scopes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Scopes
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Scopes
-- ----------------------------
ALTER TABLE [dbo].[Scopes] ADD CONSTRAINT [PK__Scopes__612CEA31BBEAA443] PRIMARY KEY CLUSTERED ([ScopeId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

