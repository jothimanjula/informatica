---DATABASE SCRIPT------------
CREATE DATABASE INFOMATICSMEETING
--------------------------------------------
---CREATE TABLE USERACCOUNTS----------------
--------------------------------------------
GO
USE INFOMATICSMEETING
GO
CREATE TABLE USERACCOUNTS
(
    UserId int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    UserName varchar(255) NOT NULL,
	[password] varchar(255) NOT NULL,
	Active bit NOT NULL,
	CreatedDate datetime NOT NULL,
	CreatedBy varchar(255) NOT NULL,
	ModifiedDate datetime NULL,
	ModifedBy varchar(255) NULL,
	DeletedDate datetime NULL,
	DeletedBy varchar(255) NULL
)
------------------------------------------------
---------CREATE TABLE LIVEMEETINGDETAILS
------------------------------------------------
GO
CREATE TABLE LIVEMEETING
(
     LiveMeetingId int IDENTITY(1,1) PRIMARY KEY,
	 LiveMeetingSubject varchar(255) NOT NULL,
	 LiveMeetingAttendees varchar(255) NOT NULL,
	 LiveMeetingAgenda varchar(255) NOT NULL,
	 LiveMeetingDate datetime NOT NULL,
	 LiveMeetingStartTime time NOT NULL,
	 LiveMeetingEndTime time NOT NULL,
	 CreatedDate datetime NOT NULL,
	 CreatedBy varchar(255) NOT NULL,
	 ModifiedDate datetime NULL,
	 ModifedBy varchar(255) NULL,
	 DeletedDate datetime NULL,
	 DeletedBy varchar(255) NULL
)
GO
---------------------------------------------------
---------------------------------------------------