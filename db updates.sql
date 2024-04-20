ALTER TABLE eventRequest
ADD societyID int,
FOREIGN KEY (societyID) REFERENCES Society(societyID);

ALTER TABLE Society
ADD leadID int,
FOREIGN KEY (leadID) REFERENCES User_(userID);

ALTER TABLE Society
ADD mentorID int,
FOREIGN KEY (mentorID) REFERENCES User_(userID);

ALTER TABLE events_
ADD societyID int,
FOREIGN KEY (societyID) REFERENCES Society(societyID);

ALTER TABLE announcements
ADD societyID int,
FOREIGN KEY (societyID) REFERENCES Society(societyID);

ALTER TABLE member_
DROP COLUMN sname;

ALTER TABLE member_
DROP COLUMN status_;

CREATE TABLE memberRequest
(
    userID int,
    societyID int,
    status_ varchar(100),
    FOREIGN KEY (userID) REFERENCES User_(userID),
    FOREIGN KEY (societyID) REFERENCES Society(societyID)
);

ALTER TABLE User_
ADD username varchar(100);