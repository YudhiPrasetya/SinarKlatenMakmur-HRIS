/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : ShiftDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:15:23
*/


-- ----------------------------
-- Table structure for JadwalShiftDepartemens
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JadwalShiftDepartemens]') AND type IN ('U'))
	DROP TABLE [dbo].[JadwalShiftDepartemens]
GO

CREATE TABLE [dbo].[JadwalShiftDepartemens] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Keterangan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [GrupKerja] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [JadwalMasuk] time(7)  NULL,
  [JadwalPulang] time(7)  NULL
)
GO

ALTER TABLE [dbo].[JadwalShiftDepartemens] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of JadwalShiftDepartemens
-- ----------------------------
SET IDENTITY_INSERT [dbo].[JadwalShiftDepartemens] ON
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'1', N'Shift 1 hari jumat SK/IRON', N'SK/IRON', N'05:30:00.0000000', N'14:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'2', N'Shift 1 hari jumat - SK/QC JENI', N'SK/QC JENI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'3', N'Shift 1 hari jumat - SK/RESIGN', N'SK/RESIGN', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'4', N'Shift 1 hari jumat - SK/STAFF', N'SK/STAFF', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'5', N'Shift 1 hari jumat - SK/CLEANING SERVICE', N'SK/CLEANING SERVICE', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'6', N'Shift 1 hari jumat - SK/LINE NARTI', N'SK/LINE NARTI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'7', N'Shift 1 hari jumat - SK/QC TRI', N'SK/QC TRI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'8', N'Shift 1 hari jumat - SK/LINE ARI TANTRI', N'SK/LINE ARI TANTRI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'9', N'Shift 1 hari jumat - SK/PACKING OUTERWEAR', N'SK/PACKING OUTERWEAR', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'10', N'Shift 1 hari jumat - SK/PACKING UNDERWEAR', N'SK/PACKING UNDERWEAR', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'11', N'Shift 1 hari jumat - SK/PKL', N'SK/PKL', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'12', N'Shift 1 hari jumat - SK/SECURITY', N'SK/SECURITY', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'13', N'Shift 1 hari jumat - SK/CUTTING', N'SK/CUTTING', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'14', N'Shift 1 hari jumat - SK/HT', N'SK/HT', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'15', N'Shift 1 hari jumat - SK/MEKANIK', N'SK/MEKANIK', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'16', N'Shift 1 hari jumat - SK/SECURITY WANITA', N'SK/SECURITY WANITA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'17', N'Shift 1 hari jumat - SK/DRIVER', N'SK/DRIVER', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'18', N'Shift 1 hari jumat - SK/LINE ENDANG', N'SK/LINE ENDANG', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'19', N'Shift 1 hari jumat - SK/WAREHOUSE', N'SK/WAREHOUSE', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'20', N'Shift 1 hari jumat - SK/ADMIN', N'SK/ADMIN', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'21', N'Shift 1 hari jumat - SK/QC GUNAWAN', N'SK/QC GUNAWAN', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'22', N'Shift 1 hari jumat - SK/MOULDING', N'SK/MOULDING', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'23', N'Shift 1 hari jumat - SK/QC MINCU', N'SK/QC MINCU', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'24', N'Shift 1 hari jumat - SK/QC MUJI', N'SK/QC MUJI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'25', N'Shift 1 hari jumat - SK/PRESS', N'SK/PRESS', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'26', N'Shift 1 hari jumat - SK/SAMPLE', N'SK/SAMPLE', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'27', N'Shift 1 hari jumat - SK/SPOT CLEANING', N'SK/SPOT CLEANING', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'28', N'Shift 1 hari jumat - SK/STAFF JAKARTA', N'SK/STAFF JAKARTA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'29', N'Shift 1 hari jumat - SK/PATTERN', N'SK/PATTERN', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'30', N'Shift 1 hari jumat - SK/PREPARATION', N'SK/PREPARATION', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'31', N'Shift 1 hari jumat - SK/CUTTING MOLDING 2', N'SK/CUTTING MOLDING 2', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'32', N'Shift 1 hari jumat - SK/LINE PIPIT', N'SK/LINE PIPIT', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'33', N'Shift 1 hari jumat - SK/LINE NUR', N'SK/LINE NUR', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'34', N'Shift 1 hari jumat - SK/LINE KRISTANTI', N'SK/LINE KRISTANTI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'35', N'Shift 1 hari jumat - SK/LINE SUTARWI', N'SK/LINE SUTARWI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'36', N'Shift 1 hari jumat - SK/LINE DIKA', N'SK/LINE DIKA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'37', N'Shift 1 hari jumat - SK/LINE KRISTINA', N'SK/LINE KRISTINA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'38', N'Shift 1 hari jumat - SK/LINE YULIYANTI', N'SK/LINE YULIYANTI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'39', N'Shift 1 hari jumat - SK/LINE KAMARI', N'SK/LINE KAMARI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'40', N'Shift 1 hari jumat - SK/LINE APRI', N'SK/LINE APRI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'41', N'Shift 1 hari jumat - SK/LINE ANNA', N'SK/LINE ANNA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'42', N'Shift 1 hari jumat - SK/LINE SUGIYANTI', N'SK/LINE SUGIYANTI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'43', N'Shift 1 hari jumat - SK/LINE WENI', N'SK/LINE WENI', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'44', N'Shift 1 hari jumat - SK/UNDER AGE', N'SK/UNDER AGE', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'45', N'Shift 1 hari jumat - SK/TRIMSTORE', N'SK/TRIMSTORE', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'46', N'Shift 1 hari jumat - SK/LINE LINA', N'SK/LINE LINA', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'47', N'Shift 1 hari jumat - Undefined', N'Undefined', N'07:30:00.0000000', N'16:30:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'48', N'Shift 1 SK/IRON - SK/IRON', N'SK/IRON', N'05:30:00.0000000', N'14:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'49', N'Shift 1 - SK/QC JENI', N'SK/QC JENI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'50', N'Shift 1 - SK/RESIGN', N'SK/RESIGN', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'51', N'Shift 1 - SK/STAFF', N'SK/STAFF', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'52', N'Shift 1 - SK/CLEANING SERVICE', N'SK/CLEANING SERVICE', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'53', N'Shift 1 - SK/LINE NARTI', N'SK/LINE NARTI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'54', N'Shift 1 - SK/QC TRI', N'SK/QC TRI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'55', N'Shift 1 - SK/LINE ARI TANTRI', N'SK/LINE ARI TANTRI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'56', N'Shift 1 - SK/PACKING OUTERWEAR', N'SK/PACKING OUTERWEAR', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'57', N'Shift 1 - SK/PACKING UNDERWEAR', N'SK/PACKING UNDERWEAR', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'58', N'Shift 1 - SK/PKL', N'SK/PKL', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'59', N'Shift 1 - SK/SECURITY', N'SK/SECURITY', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'60', N'Shift 1 - SK/CUTTING', N'SK/CUTTING', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'61', N'Shift 1 - SK/HT', N'SK/HT', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'62', N'Shift 1 - SK/MEKANIK', N'SK/MEKANIK', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'63', N'Shift 1 - SK/SECURITY WANITA', N'SK/SECURITY WANITA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'64', N'Shift 1 - SK/DRIVER', N'SK/DRIVER', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'65', N'Shift 1 - SK/LINE ENDANG', N'SK/LINE ENDANG', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'66', N'Shift 1 - SK/WAREHOUSE', N'SK/WAREHOUSE', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'67', N'Shift 1 - SK/ADMIN', N'SK/ADMIN', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'68', N'Shift 1 - SK/QC GUNAWAN', N'SK/QC GUNAWAN', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'69', N'Shift 1 - SK/MOULDING', N'SK/MOULDING', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'70', N'Shift 1 - SK/QC MINCU', N'SK/QC MINCU', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'71', N'Shift 1 - SK/QC MUJI', N'SK/QC MUJI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'72', N'Shift 1 - SK/PRESS', N'SK/PRESS', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'73', N'Shift 1 - SK/SAMPLE', N'SK/SAMPLE', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'74', N'Shift 1 - SK/SPOT CLEANING', N'SK/SPOT CLEANING', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'75', N'Shift 1 - SK/STAFF JAKARTA', N'SK/STAFF JAKARTA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'76', N'Shift 1 - SK/PATTERN', N'SK/PATTERN', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'77', N'Shift 1 - SK/PREPARATION', N'SK/PREPARATION', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'78', N'Shift 1 - SK/CUTTING MOLDING 2', N'SK/CUTTING MOLDING 2', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'79', N'Shift 1 - SK/LINE PIPIT', N'SK/LINE PIPIT', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'80', N'Shift 1 - SK/LINE NUR', N'SK/LINE NUR', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'81', N'Shift 1 - SK/LINE KRISTANTI', N'SK/LINE KRISTANTI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'82', N'Shift 1 - SK/LINE SUTARWI', N'SK/LINE SUTARWI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'83', N'Shift 1 - SK/LINE DIKA', N'SK/LINE DIKA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'84', N'Shift 1 - SK/LINE KRISTINA', N'SK/LINE KRISTINA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'85', N'Shift 1 - SK/LINE YULIYANTI', N'SK/LINE YULIYANTI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'86', N'Shift 1 - SK/LINE KAMARI', N'SK/LINE KAMARI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'87', N'Shift 1 - SK/LINE APRI', N'SK/LINE APRI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'88', N'Shift 1 - SK/LINE ANNA', N'SK/LINE ANNA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'89', N'Shift 1 - SK/LINE SUGIYANTI', N'SK/LINE SUGIYANTI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'90', N'Shift 1 - SK/LINE WENI', N'SK/LINE WENI', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'91', N'Shift 1 - SK/UNDER AGE', N'SK/UNDER AGE', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'92', N'Shift 1 - SK/TRIMSTORE', N'SK/TRIMSTORE', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'93', N'Shift 1 - SK/LINE LINA', N'SK/LINE LINA', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'94', N'Shift 1 - Undefined', N'Undefined', N'07:30:00.0000000', N'16:15:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'95', N'Shift 2 SK/IRON - SK/IRON', N'SK/IRON', N'14:15:00.0000000', N'22:45:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'96', N'Shift 2 hari jumat - SK/CUTTING', N'SK/CUTTING', N'10:00:00.0000000', N'19:00:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'97', N'Shift 2 hari jumat - SK/HT', N'SK/HT', N'10:00:00.0000000', N'19:00:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'98', N'Shift 2 - SK/CUTTING', N'SK/CUTTING', N'10:00:00.0000000', N'18:45:00.0000000')
GO

INSERT INTO [dbo].[JadwalShiftDepartemens] ([Id], [Keterangan], [GrupKerja], [JadwalMasuk], [JadwalPulang]) VALUES (N'99', N'Shift 2 - SK/HT', N'SK/HT', N'10:00:00.0000000', N'18:45:00.0000000')
GO

SET IDENTITY_INSERT [dbo].[JadwalShiftDepartemens] OFF
GO


-- ----------------------------
-- Auto increment value for JadwalShiftDepartemens
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JadwalShiftDepartemens]', RESEED, 99)
GO


-- ----------------------------
-- Primary Key structure for table JadwalShiftDepartemens
-- ----------------------------
ALTER TABLE [dbo].[JadwalShiftDepartemens] ADD CONSTRAINT [PK_JadwalShiftDepartemens] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

