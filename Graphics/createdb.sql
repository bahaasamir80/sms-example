create database ozeki
GO

use database ozeki
GO

CREATE TABLE ozekimessagein (
 id int IDENTITY (1,1),
 sender varchar(30),
 receiver varchar(30),
 msg varchar(160),
 senttime varchar(100),
 receivedtime varchar(100),
 operator varchar(30),
 msgtype varchar(30),
 reference varchar(30),
);

CREATE TABLE ozekimessageout (
 id int IDENTITY (1,1),
 sender varchar(30),
 receiver varchar(30),
 msg varchar(160),
 senttime varchar(100),
 receivedtime varchar(100),
 operator varchar(100),
 msgtype varchar(30),
 reference varchar(30),
 status varchar(30),
 errormsg varchar(250)
);

GO

sp_addLogin 'ozekiuser', 'ozekipass'
GO

sp_addsrvrolemember 'ozekiuser', 'sysadmin'
GO

