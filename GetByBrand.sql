USE [Proiect ]
GO
/****** Object:  StoredProcedure [dbo].[spVehicule_GetByBrand]    Script Date: 5/14/2019 10:37:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spVehicule_GetByBrand]
            @Brand nvarchar(50)
as
begin
    select id, Brand, Model, An, Numar
	from dbo.Vehicule
	where Brand = @Brand;

	end