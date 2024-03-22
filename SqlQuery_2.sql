use SE_DB

-- userstory 01 query
select * from Society

-- userstory 02 query (signup)
-- to see if the email already exists in the db
 select count(*) from User_ where email = @email;

-- to insert the details into the db
insert into User_ (fname, lname, email, usertype, pass)
values (@fname, @lname, @email, @usertype, @pass);

-- userstory 03 query
insert into events_ (eventName, societyID, eventDateTime, eventLocation, eventDescription)
values (@eventName, @societyID, @eventDateTime, @eventLocation, @eventDescription);

-- userstory 04 query
insert into Society (sname, description)
values (@sname, @description);
