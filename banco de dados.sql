-- Comentarios Lineares
/*
	Comentarios
		Em
			Bloco
*/

--Criando a Base de Dados
CREATE DATABASE BDNoticias;

GO

--SELECIONA UM BD
USE BDNoticias;


CREATE TABLE TBCategoria(
	Cod		INT IDENTITY ,
	Nome	VARCHAR(30) NOT NULL ,
	CONSTRAINT PK_TBCategoria_Cod PRIMARY KEY (Cod) ,
	CONSTRAINT UQ_TBCategoria_Nome UNIQUE (Nome)
);

CREATE TABLE TBNoticia(
	Cod				INT IDENTITY ,
	Titulo			VARCHAR(50) NOT NULL ,
	Conteudo		VARCHAR(255) NOT NULL ,
	CodCategoria	INT NOT NULL,
	CONSTRAINT PK_TBNoticia_Cod PRIMARY KEY (Cod) ,
	CONSTRAINT UQ_TBNoticia_Titulo UNIQUE (Titulo) ,
	CONSTRAINT FK_TBNoticia_TBCategoria FOREIGN KEY (CodCategoria)
		REFERENCES TBCategoria(Cod)
);

SELECT COD, NOME FROM TBCategoria
where NOME LIKE '%B%';

delete from TBCategoria;