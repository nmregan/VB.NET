-- --------------------------------------------------------------------------------
-- Name: Nicholas Regan
-- Class: IT-102-001
-- Abstract: Final Project SQL
-- --------------------------------------------------------------------------------

-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbSQL1;     -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TGolferEventYearSponsors' )		IS NOT NULL DROP TABLE	TGolferEventYearSponsors
IF OBJECT_ID( 'TGolferEventYears' )				IS NOT NULL DROP TABLE	TGolferEventYears
IF OBJECT_ID( 'TEventYears' )					IS NOT NULL DROP TABLE	TEventYears
IF OBJECT_ID( 'TGolfers' )						IS NOT NULL DROP TABLE	TGolfers
IF OBJECT_ID( 'TGenders' )						IS NOT NULL DROP TABLE	TGenders
IF OBJECT_ID( 'TShirtSizes' )					IS NOT NULL DROP TABLE	TShirtSizes
IF OBJECT_ID( 'TPaymentTypes' )					IS NOT NULL DROP TABLE	TPaymentTypes
IF OBJECT_ID( 'TSponsors' )						IS NOT NULL DROP TABLE	TSponsors
IF OBJECT_ID( 'TSponsorTypes' )					IS NOT NULL DROP TABLE	TSponsorTypes

IF OBJECT_ID( 'uspDeleteSponsor' )				IS NOT NULL DROP PROCEDURE	uspDeleteSponsor
IF OBJECT_ID( 'uspDeleteGolfer' )				IS NOT NULL DROP PROCEDURE	uspDeleteGolfer
IF OBJECT_ID( 'uspUpdateGolfer' )				IS NOT NULL DROP PROCEDURE	uspUpdateGolfer

IF OBJECT_ID('VGolferInfo')						IS NOT NULL DROP VIEW VGolferInfo
IF OBJECT_ID('VSponsorTotals')					IS NOT NULL DROP VIEW VSponsorTotals
IF OBJECT_ID('VGolferTotals')					IS NOT NULL DROP VIEW VGolferTotals
IF OBJECT_ID('VYearTotals')						IS NOT NULL DROP VIEW VYearTotals
IF OBJECT_ID('VEventTotals')					IS NOT NULL DROP VIEW VEventTotals

-- --------------------------------------------------------------------------------
-- Step #1: Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TEventYears
(
	 intEventYearID			INTEGER			NOT NULL
	,intEventYear			INTEGER			NOT NULL
	,CONSTRAINT TEventYears_PK PRIMARY KEY ( intEventYearID	)
)

CREATE TABLE TGenders
(
	 intGenderID			INTEGER			NOT NULL
	,strGenderDesc			VARCHAR(50)		NOT NULL
	,CONSTRAINT TGenders_PK PRIMARY KEY ( intGenderID )
)

CREATE TABLE TShirtSizes
(
	 intShirtSizeID			INTEGER			NOT NULL
	,strShirtSizeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TShirtSizes_PK PRIMARY KEY ( intShirtSizeID )
)

CREATE TABLE TGolfers
(
	 intGolferID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(50)		NOT NULL
	,strLastName			VARCHAR(50)		NOT NULL
	,strStreetAddress		VARCHAR(50)		NOT NULL
	,strCity				VARCHAR(50)		NOT NULL
	,strState				VARCHAR(50)		NOT NULL
	,strZip					VARCHAR(50)		NOT NULL
	,strPhoneNumber			VARCHAR(50)		NOT NULL
	,strEmail				VARCHAR(50)		NOT NULL
	,intShirtSizeID			INTEGER			NOT NULL
	,intGenderID			INTEGER			NOT NULL
	,CONSTRAINT TGolfers_PK PRIMARY KEY ( intGolferID )
)

CREATE TABLE TSponsors
(
	 intSponsorID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(50)		NOT NULL
	,strLastName			VARCHAR(50)		NOT NULL
	,strStreetAddress		VARCHAR(50)		NOT NULL
	,strCity				VARCHAR(50)		NOT NULL
	,strState				VARCHAR(50)		NOT NULL
	,strZip					VARCHAR(50)		NOT NULL
	,strPhoneNumber			VARCHAR(50)		NOT NULL
	,strEmail				VARCHAR(50)		NOT NULL
	,CONSTRAINT TSponsors_PK PRIMARY KEY ( intSponsorID )
)

CREATE TABLE TPaymentTypes
(
	 intPaymentTypeID		INTEGER			NOT NULL
	,strPaymentTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TPaymentTypes_PK PRIMARY KEY ( intPaymentTypeID )
)

CREATE TABLE TGolferEventYears
(
	 intGolferID			INTEGER			NOT NULL
	,intEventYearID			INTEGER			NOT NULL
	,CONSTRAINT TGolferEventYears_PK PRIMARY KEY ( intGolferID, intEventYearID )
)


CREATE TABLE TGolferEventYearSponsors
(
	 intGolferID			INTEGER			NOT NULL
	,intEventYearID			INTEGER			NOT NULL
	,intSponsorIndex		INTEGER			NOT NULL
	,intSponsorID			INTEGER			NOT NULL
	,monPledgeAmount		MONEY			NOT NULL
	,intSponsorTypeID		INTEGER			NOT NULL
	,intPaymentTypeID		INTEGER			NOT NULL
	,blnPaid				BIT				NOT NULL
	,CONSTRAINT TGolferEventYearSponsors_PK PRIMARY KEY ( intGolferID, intEventYearID, intSponsorID )
)

CREATE TABLE TSponsorTypes
(
	 intSponsorTypeID		INTEGER			NOT NULL
	,strSponsorTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TSponsorTypes_PK PRIMARY KEY ( intSponsorTypeID )
)


-- --------------------------------------------------------------------------------
-- Step #2: Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column(s)
-- -	-----							------						---------
-- 1	TGolfers						TGenders					intGenderID
-- 2	TGolfers						TShirtSizes					intShirtSizeID
-- 3    TGolferEventYears				TGolfers					intGolferID
-- 4	TGolferEventYearSponsors		TGolferEventYears			intGolferID, intEventYearID
-- 5	TGolferEventYears				TEventYears					intEventYearID
-- 6    TGolferEventYearSponsors		TSponsors					intSponsorID
-- 7	TGolferEventYearSponsors		TSponsorTypes				intSponsorTypeID
-- 8	TGolferEventYearSponsors		TPaymentTypes				intPaymentTypeID

-- 1
ALTER TABLE TGolfers ADD CONSTRAINT TGolfers_TGenders_FK
FOREIGN KEY ( intGenderID ) REFERENCES TGenders ( intGenderID )

-- 2
ALTER TABLE TGolfers ADD CONSTRAINT TGolfers_TShirtSizes_FK
FOREIGN KEY ( intShirtSizeID ) REFERENCES TShirtSizes ( intShirtSizeID )

-- 3
ALTER TABLE TGolferEventYears ADD CONSTRAINT TGolferEventYears_TGolfers_FK
FOREIGN KEY ( intGolferID ) REFERENCES TGolfers ( intGolferID )

-- 4
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TGolferEventYears_FK
FOREIGN KEY ( intGolferID, intEventYearID ) REFERENCES TGolferEventYears ( intGolferID, intEventYearID )

-- 5
ALTER TABLE TGolferEventYears ADD CONSTRAINT TGolferEventYears_TEventYears_FK
FOREIGN KEY ( intEventYearID ) REFERENCES TEventYears ( intEventYearID )

-- 6
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TSponsors_FK
FOREIGN KEY ( intSponsorID ) REFERENCES TSponsors ( intSponsorID )

-- 7
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TSponsorTypes_FK
FOREIGN KEY ( intSponsorTypeID ) REFERENCES TSponsorTypes ( intSponsorTypeID )

-- 8
ALTER TABLE TGolferEventYearSponsors ADD CONSTRAINT TGolferEventYearSponsors_TPaymentTypes_FK
FOREIGN KEY ( intPaymentTypeID ) REFERENCES TPaymentTypes ( intPaymentTypeID )

-- --------------------------------------------------------------------------------
-- Step #3: Add data to Gender
-- --------------------------------------------------------------------------------

INSERT INTO TGenders( intGenderID, strGenderDesc)
VALUES	 (1, 'Female')
		,(2, 'Male')

---- --------------------------------------------------------------------------------
---- Step #4: Add men's and women's shirt sizes
---- --------------------------------------------------------------------------------

INSERT INTO TShirtSizes( intShirtSizeID, strShirtSizeDesc)
VALUES	 (1, 'Mens Small')
		,(2, 'Mens Medium')
		,(3, 'Mens Large')
		,(4, 'Mens XLarge')
		,(5, 'Womens Small')
		,(6, 'Womens Medium')
		,(7, 'Womens Large')
		,(8, 'Womens XLarge')

---- --------------------------------------------------------------------------------
---- Step #5: Add years
---- --------------------------------------------------------------------------------
INSERT INTO TEventYears ( intEventYearID, intEventYear )
VALUES	 ( 1, 2015)
		,( 2, 2016)
		,( 3, 2017)

---- --------------------------------------------------------------------------------
---- Step #6: Add sponsor types
---- --------------------------------------------------------------------------------
INSERT INTO TSponsorTypes ( intSponsorTypeID, strSponsorTypeDesc)
VALUES	 (1, 'Parent')
		,(2, 'Alumni')
		,(3, 'Friend')
		,(4, 'Business')

---- --------------------------------------------------------------------------------
---- Step #7: Add payment types
---- --------------------------------------------------------------------------------
INSERT INTO TPaymentTypes ( intPaymentTypeID, strPaymentTypeDesc)
VALUES	 (1, 'Check')
		,(2, 'Cash')
		,(3, 'Credit Card')
---- --------------------------------------------------------------------------------
---- Step #8: Add sponsors
---- --------------------------------------------------------------------------------

INSERT INTO TSponsors ( intSponsorID, strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail )
VALUES	 ( 1, 'Jim', 'Smith', '1979 Wayne Trace Rd.', 'Willow', 'OH', '42368', '5135551212', 'jsmith@yahoo.com' )
		,( 2, 'Sally', 'Jones', '987 Mills Rd.', 'Cincinnati', 'OH', '45202', '5135551234', 'sjones@yahoo.com' )
		,( 3, 'Bob', 'Barker', '123 Broadway St.', 'Dayton', 'OH', '56808', '4196770022', 'bbarker@gmail.com' )

---- --------------------------------------------------------------------------------
---- Step #9: Add golfers
---- --------------------------------------------------------------------------------

INSERT INTO TGolfers ( intGolferID, strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, intShirtSizeID, intGenderID )
VALUES	 ( 1, 'Bill', 'Goldstein', '156 Main St.', 'Mason', 'OH', '45040', '5135559999', 'bGoldstein@yahoo.com', 1, 2 )
		,( 2, 'Tara', 'Everett', '3976 Deer Run', 'West Chester', 'OH', '45069', '5135550101', 'teverett@yahoo.com', 6, 1 )

---- --------------------------------------------------------------------------------
---- Step # 10: Add Golfers and sponsors to link them
---- --------------------------------------------------------------------------------

INSERT INTO TGolferEventYears ( intGolferID, intEventYearID)
VALUES	 (1, 1)
		,(2, 1)
		,(1, 2)
		,(2, 2)
		,(1, 3)
		,(2, 3)

---- --------------------------------------------------------------------------------
---- Step # 10: Add Golfers and sponsors to link them
---- --------------------------------------------------------------------------------
INSERT INTO TGolferEventYearSponsors ( intGolferID, intEventYearID, intSponsorIndex, intSponsorID, monPledgeAmount, intSponsorTypeID, intPaymentTypeID, blnPaid )
VALUES	 ( 1, 1, 1, 1, 25.00, 1, 1, 1 )
		,( 1, 1, 1, 2, 30.00, 1, 1, 1 )
		,( 2, 1, 2, 1, 25.00, 1, 1, 1 )
		,( 2, 1, 2, 2, 30.00, 1, 1, 1 )
		,( 2, 1, 1, 3, 5.00, 1, 1, 1 )
		,( 1, 2, 1, 1, 40.00, 1, 1, 1 )
		,( 2, 2, 2, 1, 45.00, 1, 1, 1 )
		,( 1, 2, 1, 2, 37.00, 1, 1, 1 )
		,( 2, 2, 1, 3, 14.00, 1, 1, 1 )
		,( 1, 3, 1, 3, 10.00, 1, 1, 1 )
		,( 1, 3, 1, 2, 15.00, 1, 1, 1 )
		,( 2, 3, 1, 1, 17.00, 1, 1, 1 )
		
-- --------------------------------------------------------------------------------
-- Step #11: uspDeleteSponsor
-- --------------------------------------------------------------------------------
GO

CREATE PROCEDURE uspDeleteSponsor
	@intSponsorID					INTEGER
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION 

DELETE FROM TGolferEventYearSponsors WHERE intSponsorID = @intSponsorID

DELETE FROM TSponsors WHERE intSponsorID = @intSponsorID

COMMIT TRANSACTION 

GO

-- --------------------------------------------------------------------------------
-- Step #12: uspDeleteGolfer
-- --------------------------------------------------------------------------------
GO

CREATE PROCEDURE uspDeleteGolfer
	@intGolferID					INTEGER
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION 

DELETE FROM TGolferEventYearSponsors WHERE intGolferID = @intGolferID

DELETE FROM TGolferEventYears WHERE intGolferID = @intGolferID

DELETE FROM TGolfers WHERE intGolferID = @intGolferID

COMMIT TRANSACTION 

GO

-- --------------------------------------------------------------------------------
-- Step #13: uspUpdateGolfer
-- --------------------------------------------------------------------------------

GO
CREATE PROCEDURE uspUpdateGolfer
	 @intGolferID			INTEGER
	,@strFirstName			VARCHAR(50)	
	,@strLastName			VARCHAR(50)		
	,@strStreetAddress		VARCHAR(80)		
	,@strCity				VARCHAR(50)		
	,@strState				VARCHAR(20)		
	,@strZip				VARCHAR(10)	
	,@strPhoneNumber		VARCHAR(50)
	,@strEmail				VARCHAR(50)
	,@strShirtSizeDesc		VARCHAR(50)
	,@strGenderDesc			VARCHAR(50)
AS

--SET NOCOUNT ON
SET XACT_ABORT ON 

BEGIN TRANSACTION

UPDATE TGolfers 

SET 
	strFirstname = @strFirstName, 
	strLastName = @strLastName, 
	strStreetAddress = @strStreetAddress,
	strCity = @strCity, 
	strState = @strState, 
	strZip = @strZip,
	strPhoneNumber = @strPhoneNumber,
	strEmail = @strEmail,
	intShirtSizeID = @strShirtSizeDesc,
	intGenderID = @strGenderDesc


	WHERE intGenderID = @intGolferID
	
	 
	 SELECT @@ROWCOUNT AS intRowsEffected
	 
	
COMMIT TRANSACTION 

GO

--EXECUTE uspUpdateGolfer 1, J, V, er, ham, ohg,123

-- --------------------------------------------------------------------------------
-- Step #14: VGolferInfo
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VGolferInfo
AS

SELECT
	TG.intGolferID,
	TG.strFirstName,
	TG.strLastName,
	TG.strStreetAddress,
	TG.strCity,
	TG.strState,
	TG.strZip,
	TG.strPhoneNumber,
	TG.strEmail,
	TSS.strShirtSizeDesc,
	TGN.strGenderDesc

FROM
	TGolfers			AS	TG, 
	TShirtSizes			AS	TSS,
	TGenders			AS	TGN
	
WHERE
		TG.intShirtSizeID = TSS.intShirtSizeID
	AND	TG.intGenderID = TGN.intGenderID

GO

SELECT * FROM VGolferInfo

ORDER BY
	intGolferID,
	strLastName

-- --------------------------------------------------------------------------------
-- Step #15: VSponsorTotals
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VSponsorTotals
AS

SELECT
	TGEYS.intSponsorID,
	TGEYS.intEventYearID,
	TEY.intEventYear,
	TS.strFirstName,
	TS.strLastName,
	SUM(TGEYS.monPledgeAmount) AS SponsorTotals

FROM
	TSponsors					AS	TS, 
	TGolferEventYearSponsors	AS	TGEYS,
	TEventYears					AS	TEY
	
WHERE
		TS.intSponsorID = TGEYS.intSponsorID
	AND TGEYS.intEventYearID = TEY.intEventYearID

GROUP BY
	TGEYS.intSponsorID,
	TGEYS.intEventYearID,
	TEY.intEventYear,
	TS.strFirstName,
	TS.strLastName

GO

SELECT * FROM VSponsorTotals

ORDER BY
	intEventYear,
	strLastName

-- --------------------------------------------------------------------------------
-- Step #16: VGolferTotals
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VGolferTotals
AS

SELECT
	TGEYS.intGolferID,
	TGEYS.intEventYearID,
	TEY.intEventYear,
	TG.strFirstName,
	TG.strLastName,
	SUM(TGEYS.monPledgeAmount)	AS GolferTotals

FROM
	TGolfers					AS	TG, 
	TGolferEventYearSponsors	AS	TGEYS,
	TEventYears					AS	TEY
	
WHERE
		TG.intGolferID = TGEYS.intGolferID
	AND TGEYS.intEventYearID = TEY.intEventYearID

GROUP BY
	TGEYS.intGolferID,
	TGEYS.intEventYearID,
	TEY.intEventYear,
	TG.strFirstName,
	TG.strLastName
	
GO

SELECT * FROM VGolferTotals

ORDER BY
	intEventYear,
	strLastName

-- --------------------------------------------------------------------------------
-- Step #17: VYearTotals
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VYearTotals
AS

SELECT
	TEY.intEventYearID,
	TEY.intEventYear,
	SUM(TGEYS.monPledgeAmount)	AS YearTotals

FROM
	TEventYears					AS	TEY, 
	TGolferEventYearSponsors	AS	TGEYS
	
WHERE
	TEY.intEventYearID = TGEYS.intEventYearID

GROUP BY
	TEY.intEventYearID,
	TEY.intEventYear

GO

SELECT * FROM VYearTotals

ORDER BY
	intEventYearID,
	intEventYear

-- --------------------------------------------------------------------------------
-- Step #18: VEventTotals
-- --------------------------------------------------------------------------------
GO

CREATE VIEW VEventTotals
AS

SELECT
	TEY.intEventYearID,
	TEY.intEventYear,
	SUM(TGEYS.monPledgeAmount)	AS EventTotals

FROM
	TEventYears					AS	TEY, 
	TGolferEventYearSponsors	AS	TGEYS
	
WHERE
	TEY.intEventYearID = TGEYS.intEventYearID

GROUP BY
	TEY.intEventYearID,
	TEY.intEventYear

GO

SELECT * FROM VEventTotals

ORDER BY
	intEventYearID,
	intEventYear








