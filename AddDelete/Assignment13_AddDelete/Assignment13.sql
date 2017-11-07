-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbSQL1;     -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TAutos' )						IS NOT NULL DROP TABLE	TAutos
IF OBJECT_ID( 'uspDeleteAuto' )					IS NOT NULL DROP PROCEDURE	uspDeleteAuto


-- --------------------------------------------------------------------------------
-- Step #1: Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TAutos
(
	 intAutoID		INTEGER			NOT NULL
	,strMake		VARCHAR(50)		NOT NULL
	,strModel		VARCHAR(50)		NOT NULL
	,strYear		VARCHAR(50)		NOT NULL
	,strMileage		VARCHAR(50)		NOT NULL
	,CONSTRAINT TAutos_PK PRIMARY KEY ( intAutoID		)
)


-- --------------------------------------------------------------------------------
-- Step #2: Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child								Parent						Column(s)
-- -	-----								------						---------
	--None
-- --------------------------------------------------------------------------------
-- Step #3: Add at least 3 autos
-- --------------------------------------------------------------------------------
INSERT INTO TAutos ( intAutoID, strMake, strModel, strYear, strMileage )
VALUES	 ( 1, 'Chevrolet', 'Corvette', '1979', '42368' )
		,( 2, 'Ford', 'Mustang', '1965', '68392' )
		,( 3, 'Porsche', 'Boxter', '2001', '21067' )
		
-- --------------------------------------------------------------------------------
-- Step #3: uspDeleteAuto
-- --------------------------------------------------------------------------------

GO
CREATE PROCEDURE uspDeleteAuto
	@intAutoID					INTEGER
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION 

DELETE FROM TAutos WHERE intAutoID = @intAutoID

COMMIT TRANSACTION 
GO

	















