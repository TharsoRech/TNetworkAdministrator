
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/22/2021 08:00:37
-- Generated from EDMX file: C:\Users\tharso.curia\Documents\Projects\TNetworkAdministrator\TNetworkAdministrator\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeviceSet'
CREATE TABLE [dbo].[DeviceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Manufacturer] nvarchar(max)  NULL,
    [Ip] nvarchar(max)  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [Image] nvarchar(max)  NULL,
    [Priority] int  NULL,
    [Group] int  NULL,
    [Type] int  NOT NULL,
    [AddIn] datetime  NOT NULL,
    [TimeON] datetime  NULL,
    [TimeOF] datetime  NULL,
    [DaysToCheck] int  NULL,
    [CheckEvery] int  NULL,
    [Log] nvarchar(max)  NULL,
    [Warnings] int  NULL,
    [Location] int  NULL,
    [Services] int  NULL
);
GO

-- Creating table 'Group'
CREATE TABLE [dbo].[Group] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [UseDefaultPriority] tinyint  NULL,
    [Priority] int  NULL,
    [TimeOn] datetime  NULL,
    [TimeOff] datetime  NULL,
    [DaysToCheck] int  NULL,
    [CheckEvery] int  NULL,
    [Warnings] int  NULL
);
GO

-- Creating table 'Location'
CREATE TABLE [dbo].[Location] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Priority'
CREATE TABLE [dbo].[Priority] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Low] int  NOT NULL,
    [Medium] int  NOT NULL,
    [High] int  NOT NULL,
    [Critical] int  NOT NULL
);
GO

-- Creating table 'Service'
CREATE TABLE [dbo].[Service] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Computer] nvarchar(max)  NOT NULL,
    [Port] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Settings'
CREATE TABLE [dbo].[Settings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Good] int  NOT NULL,
    [Slow] int  NOT NULL,
    [Unreacheable] int  NOT NULL,
    [NotTested] int  NOT NULL
);
GO

-- Creating table 'Type'
CREATE TABLE [dbo].[Type] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Computer] nvarchar(max)  NOT NULL,
    [Printer] nvarchar(max)  NOT NULL,
    [Switch] nvarchar(max)  NOT NULL,
    [Camera] nvarchar(max)  NOT NULL,
    [Unknown] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Warning'
CREATE TABLE [dbo].[Warning] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Device] int  NOT NULL,
    [CreatedIn] datetime  NOT NULL,
    [WarningType] int  NOT NULL
);
GO

-- Creating table 'WarningType'
CREATE TABLE [dbo].[WarningType] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Offline] nvarchar(max)  NOT NULL,
    [LostingPackage] nvarchar(max)  NOT NULL,
    [NetworkUsingExtreme] nvarchar(max)  NOT NULL,
    [ProcessUsingExtreme] nvarchar(max)  NOT NULL,
    [DiskUtilization] nvarchar(max)  NOT NULL,
    [Unknown] int  NOT NULL
);
GO

-- Creating table 'DaysToCheck'
CREATE TABLE [dbo].[DaysToCheck] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Sunday] int  NOT NULL,
    [Monday] int  NOT NULL,
    [Tuesday] int  NOT NULL,
    [wednesday] int  NOT NULL,
    [Thursday] int  NOT NULL,
    [Friday] int  NOT NULL,
    [Saturday] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [PK_DeviceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Group'
ALTER TABLE [dbo].[Group]
ADD CONSTRAINT [PK_Group]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Location'
ALTER TABLE [dbo].[Location]
ADD CONSTRAINT [PK_Location]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Priority'
ALTER TABLE [dbo].[Priority]
ADD CONSTRAINT [PK_Priority]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [PK_Service]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Settings'
ALTER TABLE [dbo].[Settings]
ADD CONSTRAINT [PK_Settings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Status'
ALTER TABLE [dbo].[Status]
ADD CONSTRAINT [PK_Status]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Type'
ALTER TABLE [dbo].[Type]
ADD CONSTRAINT [PK_Type]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Warning'
ALTER TABLE [dbo].[Warning]
ADD CONSTRAINT [PK_Warning]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WarningType'
ALTER TABLE [dbo].[WarningType]
ADD CONSTRAINT [PK_WarningType]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DaysToCheck'
ALTER TABLE [dbo].[DaysToCheck]
ADD CONSTRAINT [PK_DaysToCheck]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Group] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_Group_ID]
    FOREIGN KEY ([Group])
    REFERENCES [dbo].[Group]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Group_ID'
CREATE INDEX [IX_FK_Group_ID]
ON [dbo].[DeviceSet]
    ([Group]);
GO

-- Creating foreign key on [Warnings] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_Waring_ID]
    FOREIGN KEY ([Warnings])
    REFERENCES [dbo].[Warning]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Waring_ID'
CREATE INDEX [IX_FK_Waring_ID]
ON [dbo].[DeviceSet]
    ([Warnings]);
GO

-- Creating foreign key on [Location] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_Location_ID]
    FOREIGN KEY ([Location])
    REFERENCES [dbo].[Location]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Location_ID'
CREATE INDEX [IX_FK_Location_ID]
ON [dbo].[DeviceSet]
    ([Location]);
GO

-- Creating foreign key on [Services] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_Service_ID]
    FOREIGN KEY ([Services])
    REFERENCES [dbo].[Service]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Service_ID'
CREATE INDEX [IX_FK_Service_ID]
ON [dbo].[DeviceSet]
    ([Services]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------