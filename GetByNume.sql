USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[spPersoane_GetByNume]    Script Date: 5/14/2019 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER procedure [dbo].[spPersoane_GetByNume]
            @Nume nvarchar(50)
as
begin
    select id, Nume, Prenume, Email, Telefon
	from dbo.Persoane
	where Nume = @Nume;

	end