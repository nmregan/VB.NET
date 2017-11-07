-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbSQL1;     -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TTeamPlayers' )					IS NOT NULL DROP TABLE	TTeamPlayers
IF OBJECT_ID( 'TPlayers' )					IS NOT NULL DROP TABLE	TPlayers
IF OBJECT_ID( 'TTeams' )					IS NOT NULL DROP TABLE	TTeams

-- --------------------------------------------------------------------------------
-- Step #1.1: Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TTeams
(
	 intTeamID		INTEGER			NOT NULL
	,strTeam		VARCHAR(50)		NOT NULL
	,strMascot		VARCHAR(50)		NOT NULL
	,CONSTRAINT TTeams_PK PRIMARY KEY ( intTeamID )
)

CREATE TABLE TPlayers
(
	 intPlayerID	INTEGER			NOT NULL
	,strFirstName	VARCHAR(50)		NOT NULL
	,strLastName	VARCHAR(50)		NOT NULL
	,strAddress	VARCHAR(50)		NOT NULL
	,strCity	VARCHAR(50)		NOT NULL
	,strState	VARCHAR(50)		NOT NULL
	,strZip		VARCHAR(50)		NOT NULL
	,CONSTRAINT TPlayers_PK PRIMARY KEY ( intPlayerID )
)

CREATE TABLE TTeamPlayers
(
	 intTeamID		INTEGER			NOT NULL
	,intPlayerID	INTEGER			NOT NULL
	,CONSTRAINT TTeamPlayers_PK PRIMARY KEY ( intTeamID, intPlayerID )
)

-- --------------------------------------------------------------------------------
-- Step #1.2: Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child								Parent						Column(s)
-- -	-----								------						---------
-- 1	TTeamPlayers						TTeams						intTeamID
-- 2	TTeamPlayers						TPlayers					intPlayerID

-- 1
ALTER TABLE TTeamPlayers ADD CONSTRAINT TTeamPlayers_TTeams_FK
FOREIGN KEY ( intTeamID ) REFERENCES TTeams ( intTeamID )

-- 2
ALTER TABLE TTeamPlayers ADD CONSTRAINT TTeamPlayers_TPlayers_FK
FOREIGN KEY ( intPlayerID ) REFERENCES TPlayers ( intPlayerID )

-- --------------------------------------------------------------------------------
-- Step #1.3: Add at least 3 teams
-- --------------------------------------------------------------------------------
INSERT INTO TTeams ( intTeamID, strTeam, strMascot )
VALUES	 ( 1, 'Cincinnati Reds', 'Gapper' )
		,( 2, 'Cincinnati Bengals', 'Bengal' )
		,( 3, 'Duke', 'Blue Devils' )
		
-- --------------------------------------------------------------------------------
-- Step #1.4: Add at least 3 players
-- --------------------------------------------------------------------------------
INSERT INTO TPlayers ( intPlayerID, strFirstName, strLastName,strAddress,strCity,strState,strZip)
VALUES	 ( 1, 'Joey', 'Votto', '123 Main St.', 'Cincinnati', 'Oh', '45201' )
		,( 2, 'Andy', 'Dalton', '321 Elm St.', 'Ft. Thomas', 'Ky', '44013' )
		,( 3, 'Christian', 'Laettner', '92 Championship Way', 'Durham', 'NC', '43512' )
		
-- --------------------------------------------------------------------------------
-- Step #1.5: Add at at least 6 team/player assignments
-- --------------------------------------------------------------------------------
INSERT INTO TTeamPlayers ( intTeamID, intPlayerID )
VALUES	 ( 1, 1 )
		,( 1, 2 )
		,( 2, 1 )
		,( 2, 3 )
		,( 3, 2 )
		,( 3, 3 )

	















