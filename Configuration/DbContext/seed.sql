﻿go
USE llevellID;
go
INSERT INTO [system].[Platform] (Slug, Name, Scope, Description, Status, IsBlock, IsRemove,  ApplicationCollection)
VALUES ('llevell', 'Level Marketing Place', 'Level Marketing Place', 'Level Marketing Place', 'Ativo',0,0,null);
go
INSERT INTO  [system].[User] ( GuidPlataform, Name, Email, Password, Photo, Document, Status, IsBlock, IsRemove, Allow, [Deny], OrganizationCollection)
VALUES ('GUID_AQUI', 'level', 'level@exemplo.com', 'senha123', '/', '55544433300', 'Ativo',0,0, null, null,null);
go
UPDATE  [system].[User]
SET  GuidPlataform = (select max(a.Id) from [system].[Platform] a );



