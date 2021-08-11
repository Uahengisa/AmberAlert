										--Database Trigggers
CREATE TRIGGER tr_AddUser
ON [dbo].UserLoginInformation
AFTER INSERT
AS 
BEGIN 
		Declare @UserGuid uniqueidentifier
		SELECT	@UserGuid FROM inserted
		
		INSERT INTO	UserInformation Values (@UserGuid,'','','','','','');
END