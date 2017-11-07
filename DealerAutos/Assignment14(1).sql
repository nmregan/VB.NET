-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbSQL1;     -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TDealerAutos' )			IS NOT NULL DROP TABLE	TDealerAutos
IF OBJECT_ID( 'TAutos' )				IS NOT NULL DROP TABLE	TAutos
IF OBJECT_ID( 'TDealers' )				IS NOT NULL DROP TABLE	TDealers

IF OBJECT_ID( 'uspDeleteDealer' )		IS NOT NULL DROP PROCEDURE	uspDeleteDealer
IF OBJECT_ID( 'uspDeleteAuto' )		IS NOT NULL DROP PROCEDURE	uspDeleteAuto

IF OBJECT_ID('VDealerAutos')			IS NOT NULL DROP VIEW VDealerAutos
IF OBJECT_ID('VAvailableAutos')			IS NOT NULL DROP VIEW VAvailableAutos



-- --------------------------------------------------------------------------------
-- Step #1: Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TAutos
(
	 intAutoID			INTEGER			NOT NULL
	,strMake			VARCHAR(50)		NOT NULL
	,strModel			VARCHAR(50)		NOT NULL
	,strYear			VARCHAR(50)		NOT NULL
	,strMileage			VARCHAR(50)		NOT NULL
	,CONSTRAINT TAutos_PK PRIMARY KEY ( intAutoID )
)

CREATE TABLE TDealers
(
	 intDealerID		INTEGER			NOT NULL
	,strDealerName		VARCHAR(50)		NOT NULL
	,strAddress			VARCHAR(50)		NOT NULL
	,strCity			VARCHAR(50)		NOT NULL
	,strState			VARCHAR(50)		NOT NULL
	,strZip				VARCHAR(50)		NOT NULL
	,CONSTRAINT TDealers_PK PRIMARY KEY ( intDealerID )
)

CREATE TABLE TDealerAutos
(
	 intAutoID			INTEGER			NOT NULL
	,intDealerID		INTEGER			NOT NULL
	,CONSTRAINT TDealerAutos_PK PRIMARY KEY ( intAutoID, intDealerID )
	,CONSTRAINT UQ_intAutoID UNIQUE( intAutoID ) 
)


-- --------------------------------------------------------------------------------
-- Step #2: Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child								Parent						Column(s)
-- -	-----								------						---------
-- 1	TTeamPlayers						TTeams						intTeamID
-- 2	TTeamPlayers						TPlayers					intPlayerID

-- 1
ALTER TABLE TDealerAutos ADD CONSTRAINT TDealerAutos_TAutos_FK
FOREIGN KEY ( intAutoID ) REFERENCES TAutos ( intAutoID )

-- 2
ALTER TABLE TDealerAutos ADD CONSTRAINT TDealerAutos_TDealers_FK
FOREIGN KEY ( intDealerID ) REFERENCES TDealers ( intDealerID )
-- --------------------------------------------------------------------------------
-- Step #3: Add at least 6 autos
-- --------------------------------------------------------------------------------
INSERT INTO TAutos ( intAutoID, strMake, strModel, strYear, strMileage )
VALUES	 ( 1, 'Chevrolet', 'Corvette', '1979', '42368' )
		,( 2, 'Ford', 'Mustang', '1965', '68392' )
		,( 3, 'Chevrolet', 'Monte Carlo', '1970', '51067' )
		,( 4, 'Ford', 'Bronco', '1974', '98038' )
		,( 5, 'Chevrolet', 'Chevelle', '1969', '17098' )
		,( 6, 'Ford', 'Gran Torino', '1974', '87623' )

-- --------------------------------------------------------------------------------
-- Step #4: Add at least 2 Dealers
-- --------------------------------------------------------------------------------
INSERT INTO TDealers ( intDealerID, strDealerName, strAddress, strCity, strState, strZip )
VALUES	 ( 1, 'Chevrolet Brothers', '457 Large Block Lane', 'Detroit', 'MI', '42368' )
		,( 2, 'Henry Fords', '289 Mustang Lane', 'Livonia', 'MI', '42109' )

-- --------------------------------------------------------------------------------
-- Step #5: Add at at least 6 Auto/Dealer assignments
-- --------------------------------------------------------------------------------
INSERT INTO TDealerAutos ( intDealerID, intAutoID )
VALUES	 ( 1, 1 )
		,( 1, 3 )
		,( 1, 5 )
		,( 2, 2 )
		,( 2, 4 )
		,( 2, 6 )

-- --------------------------------------------------------------------------------
-- Step #6: uspDeleteDealer
-- --------------------------------------------------------------------------------
GO
CREATE PROCEDURE uspDeleteDealer
	@intDealerID					INTEGER
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION 

DELETE FROM TDealerAutos WHERE intDealerID = @intDealerID

DELETE FROM TDealers WHERE intDealerID = @intDealerID

COMMIT TRANSACTION 
GO

-- --------------------------------------------------------------------------------
-- Step #6: uspDeleteAuto
-- --------------------------------------------------------------------------------
GO
CREATE PROCEDURE uspDeleteAuto
	@intAutoID					INTEGER
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION 

DELETE FROM TDealerAutos WHERE intAutoID = @intAutoID

DELETE FROM TAutos WHERE intAutoID = @intAutoID

COMMIT TRANSACTION 
GO

-- --------------------------------------------------------------------------------
-- Step #7: VDealerAutos
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VDealerAutos
AS

SELECT
	TA.intAutoID,
	TA.strMake,
	TA.strModel,
	TA.strYear,
	TA.strMileage,
	TD.intDealerID,
	TD.strDealerName

FROM
	TAutos			AS	TA, 
	TDealerAutos	AS	TDA,
	TDealers		AS	TD

WHERE
	TA.intAutoID = TDA.intAutoID and
	TDA.intDealerID = TD.intDealerID

GO

SELECT * FROM VDealerAutos

ORDER BY
	strDealerName
		
-- --------------------------------------------------------------------------------
-- Step #8: VAvailableAutos
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VAvailableAutos
AS

SELECT
	TA.intAutoID,
	TA.strMake,
	TA.strModel,
	TA.strYear,
	TA.strMileage

FROM
	TAutos			AS	TA
		LEFT JOIN	TDealerAutos AS TDA ON TDA.intAutoID = TA.intAutoID

WHERE		 
	TDA.intAutoID IS NULL
									
GO

SELECT * FROM VAvailableAutos

ORDER BY
	intAutoID,
	strMake


	















