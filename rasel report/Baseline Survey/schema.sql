if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_thana_district]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[thana] DROP CONSTRAINT FK_thana_district
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_union_thana]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[union] DROP CONSTRAINT FK_union_thana
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_cnc_union]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[cnc] DROP CONSTRAINT FK_cnc_union
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_village_union]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[village] DROP CONSTRAINT FK_village_union
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_cnc]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_cnc
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_para_village]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[para] DROP CONSTRAINT FK_para_village
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_house_para]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[house] DROP CONSTRAINT FK_house_para
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_roof]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_roof
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_wall]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_wall
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_floor]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_floor
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_member_relation]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[member] DROP CONSTRAINT FK_member_relation
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_member_sex]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[member] DROP CONSTRAINT FK_member_sex
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_member_marital_status]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[member] DROP CONSTRAINT FK_member_marital_status
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_member_education]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[member] DROP CONSTRAINT FK_member_education
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_user]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_user
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_water_source]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_water_source
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_khana_evaluation]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[khana] DROP CONSTRAINT FK_khana_evaluation
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_member_khana]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[member] DROP CONSTRAINT FK_member_khana
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[district]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[district]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[thana]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[thana]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[union]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[union]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[cnc]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[cnc]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[village]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[village]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[para]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[para]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[house]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[house]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[roof]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[roof]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[wall]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[wall]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[floor]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[floor]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[relation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[relation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sex]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[sex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[marital_status]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[marital_status]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[education]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[education]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[user]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[user]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[water_source]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[water_source]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[evaluation]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[evaluation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[khana]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[khana]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[member]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[member]
GO

CREATE TABLE [dbo].[district] (
	[district_no] [int] NOT NULL ,
	[district_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[thana] (
	[thana_no] [int] NOT NULL ,
	[thana_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[district_no] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[union] (
	[union_no] [int] NOT NULL ,
	[union_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[thana_no] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[cnc] (
	[cnc_no] [int] NOT NULL ,
	[union_no] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[village] (
	[village_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[union_no] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[para] (
	[para_name] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[village_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[house] (
	[house_name] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[para_name] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[roof] (
	[roof_no] [int] NOT NULL ,
	[roof] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[wall] (
	[wall_no] [int] NOT NULL ,
	[wall] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[floor] (
	[floor_no] [int] NOT NULL ,
	[floor] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[relation] (
	[relation_no] [int] NOT NULL ,
	[relation] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[sex] (
	[sex_no] [int] NOT NULL ,
	[sex] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[marital_status] (
	[marital_no] [int] NOT NULL ,
	[status] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[education] (
	[education_no] [int] NOT NULL ,
	[education] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[user] (
	[user_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[name] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[password] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[member_count] [bigint] NULL ,
	[khana_count] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[water_source] (
	[water_source_no] [int] NOT NULL ,
	[water_source] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[evaluation] (
	[evaluation_no] [int] NOT NULL ,
	[evaluation] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[khana] (
	[khana_no] [int] NOT NULL ,
	[cnc_no] [int] NULL ,
	[user_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[roof_no] [int] NULL ,
	[wall_no] [int] NULL ,
	[floor_no] [int] NULL ,
	[water_source_no] [int] NULL ,
	[evaluation_no] [int] NULL ,
	[house_price] [bigint] NULL ,
	[land_amount] [int] NULL ,
	[land_price] [bigint] NULL ,
	[cow] [int] NULL ,
	[goat] [int] NULL ,
	[hen] [int] NULL ,
	[fruit_tree] [int] NULL ,
	[vegitable_land] [int] NULL ,
	[month_covered] [int] NULL ,
	[bed] [int] NULL ,
	[chair] [int] NULL ,
	[radio] [int] NULL ,
	[tv] [int] NULL ,
	[tubewell] [int] NULL ,
	[milky_cow] [int] NULL ,
	[milky_goat] [int] NULL ,
	[day_labourer] [int] NULL ,
	[labour_days] [int] NULL ,
	[latrine] [int] NULL ,
	[enumerator] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[cno_name] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[_date] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[member] (
	[member_no] [int] NOT NULL ,
	[mother_no] [int] NULL ,
	[name] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[relation_no] [int] NULL ,
	[age] [int] NULL ,
	[dob] [datetime] NULL ,
	[sex_no] [int] NULL ,
	[marital_no] [int] NULL ,
	[marital_year] [int] NULL ,
	[education_no] [int] NULL ,
	[weight] [float] NULL ,
	[height] [int] NULL ,
	[parity] [int] NULL ,
	[khana_no] [int] NULL 
) ON [PRIMARY]
GO

