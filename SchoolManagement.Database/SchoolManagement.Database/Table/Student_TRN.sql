CREATE TABLE [dbo].[Student_TRN]
(
	[RequestID]	  VARCHAR(15)      NOT NULL PRIMARY KEY,
	[InternalID]  UNIQUEIDENTIFIER NOT NULL,
	[StudentID]   VARCHAR(15)      NOT NULL,
	[FirstName]   VARCHAR(20)      NOT NULL,
	[MiddleName]  VARCHAR(20)      NULL,
	[LastName]	  VARCHAR(20)      NOT NULL,
	[Gender]	  VARCHAR(6)       NOT NULL,
	[CivilStatus] VARCHAR(9)       NOT NULL,
	[BirthDate]	  DATE             NOT NULL,
	[Status]	  INT	           NOT NULL,
	[LastUpdate]  DATETIME         NOT NULL
)
