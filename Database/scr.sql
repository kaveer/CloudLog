USE [CloudLog]
GO
/****** Object:  Table [dbo].[LogDetails]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogDetails](
	[detailsId] [int] IDENTITY(1,1) NOT NULL,
	[logId] [int] NULL,
	[logName] [varchar](100) NULL,
	[protoPayloadTypeUrl] [varchar](100) NULL,
	[protoPayloadValue] [varchar](500) NULL,
	[recieveTimestamp] [datetime] NULL,
	[severity] [varchar](100) NULL,
	[logTimestamp] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[detailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogResources]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogResources](
	[resourceId] [int] IDENTITY(1,1) NOT NULL,
	[logId] [int] NULL,
	[resourceKey] [varchar](100) NULL,
	[resourceValue] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[resourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[logId] [int] IDENTITY(1,1) NOT NULL,
	[insertId] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[logId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[LogsDetailsRetrieve]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LogsDetailsRetrieve]
	@logId int
AS
	BEGIN
		SELECT 
			l.logId, 
			l.insertId, 
			ld.logName, 
			ld.protoPayloadTypeUrl, 
			ld.protoPayloadValue, 
			ld.recieveTimestamp, 
			ld.severity, 
			ld.logTimestamp
		FROM dbo.Logs l
		INNER JOIN dbo.LogDetails ld ON l.logId = ld.logId
		WHERE l.logId = @logId
	END

GO
/****** Object:  StoredProcedure [dbo].[LogsResourceRetrieve]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LogsResourceRetrieve]
	@logId int
AS
	BEGIN
		SELECT 
			lr.resourceId, 
			lr.resourceKey, 
			lr.resourceValue
		FROM dbo.LogResources lr
		WHERE lr.logId = @logId
	END

GO
/****** Object:  StoredProcedure [dbo].[LogsRetrieve]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[LogsRetrieve]
AS
	BEGIN
		SELECT 
			l.logId, 
			l.insertId,
			ld.recieveTimestamp AS [log date]
		FROM dbo.Logs l
		INNER JOIN dbo.LogDetails ld ON ld.logId = l.logId
	END

GO
/****** Object:  StoredProcedure [dbo].[SaveLog]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SaveLog]
	@insertId varchar(50)
AS
	BEGIN
		DECLARE @isNew bit = 0;

		IF NOT EXISTS(SELECT * FROM dbo.Logs l WHERE l.insertId = @insertId)
			BEGIN
				SET @isNew = 1

				INSERT INTO dbo.Logs(insertId)
				VALUES(@insertId)		
			END
		
		IF EXISTS(SELECT * FROM dbo.Logs l WHERE l.insertId = @insertId)
			BEGIN
				SELECT 
					l.logId,
					l.insertId,
					@isNew AS isNew
				FROM dbo.Logs l
				WHERE l.insertId = @insertId
			END
		ELSE
			BEGIN
				SELECT 
					0 AS logId, 
					'no insert Id' AS insertId, 
					@isNew AS isNew
			END
		
	END
GO
/****** Object:  StoredProcedure [dbo].[SaveLogDetails]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveLogDetails]
	@logId int,
	@logName varchar(100),
	@ptypeUrl varchar(100),
	@pvalue varchar(500),
	@recieve datetime,
	@severity varchar(100),
	@logTimestamp datetime
AS
	BEGIN
		INSERT INTO dbo.LogDetails(logId, logName, protoPayloadTypeUrl, protoPayloadValue, recieveTimestamp, severity, logTimestamp )
		VALUES(@logId, @logName, @ptypeUrl, @pvalue, @recieve, @severity, @logTimestamp)
	END
GO
/****** Object:  StoredProcedure [dbo].[SaveLogResource]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveLogResource]
	@logId int,
	@rkey varchar(100),
	@rvalue varchar(100)
AS
	BEGIN
		INSERT INTO dbo.LogResources(logId, resourceKey, resourceValue)
		VALUES(@logId, @rkey, @rvalue)

		SELECT *
		FROM dbo.LogResources lr
		WHERE lr.logId = @logId
	END
GO
/****** Object:  StoredProcedure [dbo].[Search]    Script Date: 10/23/2019 8:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Search]
	@logId int,
	@insertId varchar(100),
	@logName varchar(100),
	@ptypeUrl varchar(100),
	@pvalue varchar(500),
	@recieveFrom datetime,
	@recieveTo datetime,
	@logChange bit,
	@RecieveChange bit,
	@severity varchar(100),
	@logTimestampFrom datetime,
	@logTimestampTo datetime,
	@resource varchar(100)

AS
	BEGIN
		CREATE TABLE #temp(
			logId int
		)

		IF(@logId > 0)
			BEGIN
				INSERT INTO #temp(logId)
				SELECT l.logId
				FROM dbo.Logs l
				WHERE l.logId = @logId
			END
		IF(@insertId != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT l.logId
				FROM dbo.Logs l
				WHERE l.insertId LIKE '%'+ @insertId +'%'
			END
		IF(@logName != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.logName LIKE '%' + @logname + '%'
			END
		IF(@ptypeUrl != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.protoPayloadTypeUrl LIKE '%' + @ptypeUrl + '%'
			END
		IF(@pvalue != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.protoPayloadValue LIKE '%' + @pvalue + '%'
			END
		IF(@RecieveChange = 'True')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.recieveTimestamp >= @recieveFrom AND ld.recieveTimestamp <= @recieveTo
			END
		IF(@logChange = 'True')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.logTimestamp >= @logChange AND ld.logTimestamp <= @logChange
			END
		IF(@severity != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT ld.logId
				FROM dbo.LogDetails ld
				WHERE ld.severity LIKE '%' + @severity + '%'
			END
		IF(@resource != '')
			BEGIN
				INSERT INTO #temp(logId)
				SELECT lr.logId
				FROM dbo.LogResources lr
				WHERE lr.resourceKey LIKE '%' + @resource + '%'

				
				INSERT INTO #temp(logId)
				SELECT lr.logId
				FROM dbo.LogResources lr
				WHERE lr.resourceValue LIKE '%' + @resource + '%'
			END

		SELECT 
			l.logId, 
			l.insertId,
			ld.logName, 
			ld.protoPayloadTypeUrl, 
			ld.protoPayloadValue, 
			ld.recieveTimestamp, 
			ld.severity, 
			ld.logTimestamp
		FROM dbo.Logs l
		INNER JOIN dbo.LogDetails ld ON l.logId = ld.logId
		WHERE l.logId IN (SELECT DISTINCT t.logId FROM #temp t)

		DROP TABLE #temp
	END
GO
