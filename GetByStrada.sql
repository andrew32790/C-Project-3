USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[spAdrese_GetByStrada]    Script Date: 5/14/2019 10:41:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spAdrese_GetByStrada]
            @Strada nvarchar(50)
as
begin
    select id, Strada, Numar
	from dbo.Adrese
	where Strada = @Strada;

	end