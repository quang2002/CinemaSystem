USE master;
GO

IF DB_ID('CinemaSystem') IS NOT NULL 
BEGIN
	ALTER DATABASE [CinemaSystem] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [CinemaSystem];
END;
GO

CREATE DATABASE [CinemaSystem];
GO

USE [CinemaSystem];
GO

CREATE TABLE [dbo].[User] (
	[ID]			INT IDENTITY (1, 1),
	[Email]			NVARCHAR (64) NOT NULL,
	[Password]		NVARCHAR (64) NOT NULL,
	[Name]			NVARCHAR (64) NOT NULL,
	[AvatarURL]		NVARCHAR (128) NOT NULL,
	[Balance]		FLOAT NOT NULL DEFAULT 0,
	[Role]			INT NOT NULL DEFAULT 0,
	
	PRIMARY KEY		([ID]),
	UNIQUE			([Email]),
	CHECK			([Role] IN (0, 1, 2))
);

CREATE TABLE [dbo].[Room] (
	[ID]			INT IDENTITY (1, 1),
	[Name]			NVARCHAR (64) NOT NULL,
	[Rows]			INT NOT NULL,
	[Cols]			INT NOT NULL,
	
	PRIMARY KEY		([ID]),
	UNIQUE			([Name]),
	CHECK			([Rows] * [Cols] > 0)
);

CREATE TABLE [dbo].[Film] (
	[ID]			INT IDENTITY (1, 1),
	[Name]			NVARCHAR (64) NOT NULL,
	[Desc]			NVARCHAR (1024) NOT NULL,
	[Length]		INT NOT NULL,
	[ImageURL]		NVARCHAR (128) NOT NULL,
	[ReleaseDate]	DATE NOT NULL,

	PRIMARY	KEY		([ID]),
	CHECK			([Length] > 0)
);
	
CREATE TABLE [dbo].[Category] (
	[ID]			INT IDENTITY (1, 1),
	[Name]			NVARCHAR (64) NOT NULL,
	[Desc]			NVARCHAR (1024) NOT NULL,

	PRIMARY	KEY		([ID])
);

CREATE TABLE [dbo].[FilmCategory] (
	[FilmID]		INT,
	[CategoryID]	INT,

	PRIMARY KEY		([FilmID], [CategoryID]),
	FOREIGN KEY		([FilmID]) REFERENCES [dbo].[Film]([ID]) ON DELETE CASCADE,
	FOREIGN KEY		([CategoryID]) REFERENCES [dbo].[Category]([ID]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Show] (
	[ID]			INT IDENTITY (1, 1),
	[FilmID]		INT NOT NULL,
	[Start]			DATETIME NOT NULL,
	[End]			DATETIME NOT NULL,
	[TicketPrice]	FLOAT NOT NULL,
	[RoomID]		INT NOT NULL,

	PRIMARY	KEY		([ID]),
	FOREIGN KEY		([FilmID]) REFERENCES [dbo].[Film]([ID]) ON DELETE CASCADE,
	FOREIGN KEY		([RoomID]) REFERENCES [dbo].[Room]([ID]) ON DELETE CASCADE,
	CHECK			([TicketPrice] >= 0)
);

CREATE TABLE [dbo].[Ticket] (
	[ShowID]		INT,
	[UserID]		INT,
	[OTP]			CHAR (6) NOT NULL,
	[Row]			INT NOT NULL,
	[Col]			INT NOT NULL,
	[IsUsed]		BIT NOT NULL DEFAULT 0,

	PRIMARY KEY		([ShowID], [Row], [Col]),
	FOREIGN KEY		([ShowID]) REFERENCES [dbo].[Show]([ID]) ON DELETE CASCADE,
	FOREIGN KEY		([UserID]) REFERENCES [dbo].[User]([ID]) ON DELETE CASCADE,

	CHECK			([OTP] LIKE '[0-9][0-9][0-9][0-9][0-9][0-9]')
);