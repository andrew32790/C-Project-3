USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[PNInsert]    Script Date: 5/14/2019 10:33:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PNInsert]
@Nume nvarchar(50),
@Prenume nvarchar(50),
@Email nvarchar(100),
@Telefon varchar(20)
AS
BEGIN
SET NOCOUNT ON;

insert into dbo.Persoane (Nume, Prenume, Email, Telefon)
values (@Nume, @Prenume, @Email, @Telefon );

END