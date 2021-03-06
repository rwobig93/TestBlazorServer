IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND OBJECT_ID = OBJECT_ID('[dbo].[User_Role_Junction]'))
begin
    CREATE TABLE [dbo].[User_Role_Junction](
        [UserId] UNIQUEIDENTIFIER NOT NULL,
        [RoleId] UNIQUEIDENTIFIER NOT NULL,
        CONSTRAINT User_Role_PK PRIMARY KEY (UserId, RoleId),
        CONSTRAINT FK_User
            FOREIGN KEY (UserId) REFERENCES dbo.[Users] (UserId),
        CONSTRAINT FK_Role
            FOREIGN KEY (RoleId) REFERENCES dbo.[Roles] (RoleId)
    )
end
