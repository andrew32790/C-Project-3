USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[ADInsert]    Script Date: 5/14/2019 10:32:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ADInsert]
@Strada nvarchar(50),
@Numar varchar(20)
AS
BEGIN
SET NOCOUNT ON;

insert into dbo.Adrese (Strada, Numar)
values (@Strada, @Numar);

END