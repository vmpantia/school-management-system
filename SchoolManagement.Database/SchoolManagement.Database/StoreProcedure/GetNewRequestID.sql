CREATE PROCEDURE [dbo].[GetNewRequestID]
AS

BEGIN
	-- RequestID Example: 202208080000001
	DECLARE @LatestRequestID VARCHAR(15)
	DECLARE @No INT = 1
	DECLARE @NewRequestID VARCHAR(15)
	DECLARE @CurrentDate VARCHAR(15)

	SET @CurrentDate = FORMAT(GETDATE(), 'yyyyMMdd')

	IF EXISTS (SELECT * FROM Student_MST)
	BEGIN
		SET @LatestRequestID = (SELECT TOP 1 RequestID FROM Request_LST ORDER BY RequestID DESC)
		SET @No = @LatestRequestID + 1
	END

	-- Generate New RequestID
	SET @NewRequestID = CONCAT(@CurrentDate, FORMAT(@No, '0000000'))
	SELECT @NewRequestID
END