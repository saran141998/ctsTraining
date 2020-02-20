
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:10:07
-- Generated from EDMX file: C:\Users\Admin\source\repos\examAutomation\examAutomation\ExamAutomationSystem.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Examautomation];
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

-- Creating table 'StudentsInfo'
CREATE TABLE [dbo].[StudentsInfo] (
    [StudentRegNo] int IDENTITY(1,1) NOT NULL ,
    [StudentName] nvarchar(max)  NOT NULL,
    [DOB] datetime  NOT NULL,
    [SchoolName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ExamsInfo'
CREATE TABLE [dbo].[ExamsInfo] (
    [SubjectCode] int IDENTITY(1,1) NOT NULL,
    [SubjectName] nvarchar(max)  NOT NULL,
    [Examdate] datetime  NOT NULL
);
GO

-- Creating table 'ResultsInfo'
CREATE TABLE [dbo].[ResultsInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentRegNo] int  NOT NULL,
    [SubjectCode] int  NOT NULL,
    [Marks] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentRegNo] in table 'StudentsInfo'
ALTER TABLE [dbo].[StudentsInfo]
ADD CONSTRAINT [PK_StudentsInfo]
    PRIMARY KEY CLUSTERED ([StudentRegNo] ASC);
GO

-- Creating primary key on [SubjectCode] in table 'ExamsInfo'
ALTER TABLE [dbo].[ExamsInfo]
ADD CONSTRAINT [PK_ExamsInfo]
    PRIMARY KEY CLUSTERED ([SubjectCode] ASC);
GO

-- Creating primary key on [Id] in table 'ResultsInfo'
ALTER TABLE [dbo].[ResultsInfo]
ADD CONSTRAINT [PK_ResultsInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentRegNo] in table 'ResultsInfo'
ALTER TABLE [dbo].[ResultsInfo]
ADD CONSTRAINT [FK_StudentInfoResultInfo]
    FOREIGN KEY ([StudentRegNo])
    REFERENCES [dbo].[StudentsInfo]
        ([StudentRegNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentInfoResultInfo'
CREATE INDEX [IX_FK_StudentInfoResultInfo]
ON [dbo].[ResultsInfo]
    ([StudentRegNo]);
GO

-- Creating foreign key on [SubjectCode] in table 'ResultsInfo'
ALTER TABLE [dbo].[ResultsInfo]
ADD CONSTRAINT [FK_ExamInfoResultInfo]
    FOREIGN KEY ([SubjectCode])
    REFERENCES [dbo].[ExamsInfo]
        ([SubjectCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamInfoResultInfo'
CREATE INDEX [IX_FK_ExamInfoResultInfo]
ON [dbo].[ResultsInfo]
    ([SubjectCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------