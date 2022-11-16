CREATE PROCEDURE [dbo].[GetNewStudentID]
AS

BEGIN
	-- StudentID Example: ST2022080000001
	DECLARE @LatestStudentID VARCHAR(15)
	DECLARE @No INT = 1
	DECLARE @NewStudentID VARCHAR(15)
	DECLARE @CurrentDateMonth VARCHAR(15)

	SET @CurrentDateMonth = FORMAT(GETDATE(), 'yyyyMM')

	IF EXISTS (SELECT * FROM Student_MST)
	BEGIN
		SET @LatestStudentID = (SELECT TOP 1 StudentID FROM Student_MST ORDER BY StudentID DESC)
		SET @No = @LatestStudentID + 1
	END

	-- Generate New StudentID
	SET @NewStudentID = CONCAT('ST', @CurrentDateMonth, FORMAT(@No, '0000000'))
	SELECT @NewStudentID
END