USE [proyectoFinal]
GO
/****** Object:  StoredProcedure [dbo].[registrarVisita]    Script Date: 16/12/2022 7:13:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[registrarVisita] @nombre varchar(50), @apellido varchar(50),@carrera varchar(50),@correo varchar(50),@horaEntrada varchar(50),@horaSalida varchar(50),
	@Aula varchar(4),@Edificio varchar(5)
AS
BEGIN
	INSERT INTO registroEdificio(Nombre, Apellido, Carrera, Correo, Edificio, horaEntrada, horaSalida, Aula)
	VALUES (@nombre, @apellido, @carrera, @correo, @Edificio, @horaEntrada, @horaSalida, @Aula);
END