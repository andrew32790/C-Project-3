USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[VHInsert]    Script Date: 5/14/2019 10:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[VHInsert]
@Brand nvarchar(50),
@Model nvarchar(50),
@An varchar(4),
@Numar varchar(20)
AS
BEGIN
SET NOCOUNT ON;

insert into dbo.Vehicule (Brand, Model, An, Numar)
values (@Brand, @Model, @An, @Numar);

END