-- 1) Check for the Database Exists .If the database is exist then drop and create new DB       
IF EXISTS (SELECT [name] FROM sys.databases WHERE [name] = 'PatientDB' )       
DROP DATABASE PatientDB       
GO       
       
CREATE DATABASE PatientDB       
GO       
       
USE PatientDB       
GO  




-- ) //////////// BloodGroup
IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'BloodGroup' )       
DROP TABLE BloodGroup       
GO 


CREATE TABLE [dbo].[BloodGroup](
	[BloodGroupsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_BloodGroup] PRIMARY KEY CLUSTERED 
(
	[BloodGroupsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Department' )       
DROP TABLE Department       
GO 

CREATE TABLE [dbo].[Department](
	[DepartmentsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


-- ) //////////// Experience
IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Experience' )       
DROP TABLE Experience       
GO 

CREATE TABLE [dbo].[Experience](
	[ExperienceId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Experience] PRIMARY KEY CLUSTERED 
(
	[ExperienceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO




-- ) //////////// Experience
IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Gender' )       
DROP TABLE Gender       
GO 
CREATE TABLE [dbo].[Gender](
	[GendersId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GendersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


-- ) //////////// Doctor

IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Doctor' )       
DROP TABLE Doctor       
GO 
CREATE TABLE [dbo].[Doctor](
	[DoctorsId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Education] [nvarchar](max) NULL,
	[Designation] [nvarchar](max) NULL,
	[GendersId] [int] NOT NULL,
	[ExperienceId] [int] NOT NULL,
	[DepartmentsId] [int] NOT NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Department_DepartmentsId] FOREIGN KEY([DepartmentsId])
REFERENCES [dbo].[Department] ([DepartmentsId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Department_DepartmentsId]
GO

ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Experience_ExperienceId] FOREIGN KEY([ExperienceId])
REFERENCES [dbo].[Experience] ([ExperienceId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Experience_ExperienceId]
GO

ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Gender_GendersId] FOREIGN KEY([GendersId])
REFERENCES [dbo].[Gender] ([GendersId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Gender_GendersId]
GO





-- ) //////////// Patient

IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Patient' )       
DROP TABLE Patient       
GO 

/****** Object:  Table [dbo].[Patient]    Script Date: 8/17/2019 12:56:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patient](
	[PatientsId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Symptoms] [nvarchar](max) NULL,
	[Birthday] [nvarchar](max) NULL,
	[BloodGroupsId] [int] NOT NULL,
	[GendersId] [int] NOT NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_BloodGroup_BloodGroupsId] FOREIGN KEY([BloodGroupsId])
REFERENCES [dbo].[BloodGroup] ([BloodGroupsId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_BloodGroup_BloodGroupsId]
GO

ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Gender_GendersId] FOREIGN KEY([GendersId])
REFERENCES [dbo].[Gender] ([GendersId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Gender_GendersId]
GO





-- ) //////////// Appointment

IF EXISTS ( SELECT [name] FROM sys.tables WHERE [name] = 'Appointment' )       
DROP TABLE Appointment       
GO 

CREATE TABLE [dbo].[Appointment](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[PatientsId] [int] NOT NULL,
	[Day] [nvarchar](max) NULL,
	[DepartmentsId] [int] NOT NULL,
	[DoctorsId] [int] NOT NULL,
	[Symptoms] [nvarchar](max) NULL,
	[IsVisible] [bit] NOT NULL,
	[Urd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Department_DepartmentsId] FOREIGN KEY([DepartmentsId])
REFERENCES [dbo].[Department] ([DepartmentsId])
GO

ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Department_DepartmentsId]
GO

ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor_DoctorsId] FOREIGN KEY([DoctorsId])
REFERENCES [dbo].[Doctor] ([DoctorsId])
GO

ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor_DoctorsId]
GO

ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient_PatientsId] FOREIGN KEY([PatientsId])
REFERENCES [dbo].[Patient] ([PatientsId])
GO

ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient_PatientsId]
Go




INSERT INTO [BloodGroup]([Name],[IsVisible],[Urd])VALUES ('AB+ ve',0,GETDATE());
INSERT INTO [BloodGroup]([Name],[IsVisible],[Urd])VALUES ('A+ ve',0,GETDATE());
INSERT INTO [BloodGroup]([Name],[IsVisible],[Urd])VALUES ('B+ ve',0,GETDATE());
INSERT INTO [BloodGroup]([Name],[IsVisible],[Urd])VALUES ('AB- ve',0,GETDATE());
INSERT INTO [BloodGroup]([Name],[IsVisible],[Urd])VALUES ('O- ve',0,GETDATE());



INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('General Medicine',0,GETDATE())
INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('Neurology',0,GETDATE())
INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('Dermatology',0,GETDATE())
INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('Orthopedics',0,GETDATE())
INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('Diabetology',0,GETDATE())
INSERT INTO [dbo].[Department]([Name],[IsVisible],[Urd])    VALUES('Cardiology',0,GETDATE())


INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('1+ years',0,GETDATE())   
INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('2+ years',0,GETDATE())   
INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('5+ years',0,GETDATE())   
INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('10+ years',0,GETDATE())   
INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('15+ years',0,GETDATE())   
INSERT INTO [dbo].[Experience]([Name],[IsVisible],[Urd])  VALUES('20+ years',0,GETDATE())  



INSERT INTO [dbo].[Gender]([Name],[IsVisible],[Urd]) VALUES('Male',0,GETDATE()) 
INSERT INTO [dbo].[Gender]([Name],[IsVisible],[Urd]) VALUES('Female',0,GETDATE()) 
INSERT INTO [dbo].[Gender]([Name],[IsVisible],[Urd]) VALUES('Unkown',0,GETDATE()) 





