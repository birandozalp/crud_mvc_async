CREATE DATABASE AsyncBusDb;
USE AsyncBusDb;
GO
CREATE TABLE Bus(
ID int,
Brand nvarchar(50),
Make nvarchar(50),
[Year] int)
;

INSERT INTO Bus VALUES(1,'Mercedes','A200',2011);
INSERT INTO Bus VALUES(2,'Otokar','Runner',2004);
INSERT INTO Bus VALUES(3,'BMC','K450',2018);
INSERT INTO Bus VALUES(4,'Mercedes','Longway',2009);
INSERT INTO Bus VALUES(5,'MAN','Strider',2014);