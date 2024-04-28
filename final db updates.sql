ALTER TABLE memberRequest
ALTER COLUMN societyID INT NOT NULL;

ALTER TABLE memberRequest
ALTER COLUMN userID INT NOT NULL;

ALTER TABLE memberRequest
ADD CONSTRAINT PK_memberRequest PRIMARY KEY (userID, societyID);

ALTER TABLE announcements
DROP COLUMN announcementTitle;

ALTER TABLE announcements
DROP COLUMN announcementDateTime;