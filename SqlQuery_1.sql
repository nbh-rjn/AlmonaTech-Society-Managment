create database societydb
use societydb

create table User_(
	userid int identity(1,1),
	primary key(userid),
	fname varchar(50),
	lname varchar(50),
	email varchar(50),
	usertype varchar(10),
	pass varchar(20)
)

create table eventRequest
(
	reqID int identity(1,1),
	primary key(reqID),
	eventName varchar(100),
	description_ varchar(250),
	date_ date,
	userID int
	foreign key (userID) references User_(userID)
)

create table Society
(
	societyID int identity(1,1),
	primary key(societyID),
	sname varchar(100),
	description_ varchar(max)
)

create table events_
(
    eventID int identity(1,1),
	primary key(eventID),
	eventName varchar(100),
	societyID int,
	eventDateTime datetime,
	eventLocation varchar(100),
	eventDescription varchar(max)
)

create table announcements
(
    userID int,
	announcementID int identity(1,1),
	announcementTitle varchar(100),
	announcementDesc varchar(max),
	announcementDateTime datetime,
	foreign key (userID) references User_(userID)

)