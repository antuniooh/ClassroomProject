CREATE DATABASE [db_oturan];

USE db_oturan;

CREATE TABLE TB_USUARIO(ID_USUARIO INT IDENTITY(1,1)NOT NULL PRIMARY KEY,
NOME_USUARIO 	NVARCHAR(60) NOT NULL,
USER_USUARIO NVARCHAR(15) NOT NULL, CONSTRAINT UQUSER_USUARIO UNIQUE(USER_USUARIO),
SENHA_USUARIO NVARCHAR(20) NOT NULL,
EMAIL_USUARIO NVARCHAR(30) NOT NULL, CONSTRAINT UQEMAIL_USUARIO UNIQUE(EMAIL_USUARIO),
DATA_NASC_USUARIO DATE,
SEXO_USUARIO CHAR(1) NOT NULL,
FOTO_USUARIO VARBINARY(MAX),
AREA_USUARIO NVARCHAR(35) NOT NULL);

SELECT * FROM TB_USUARIO;

INSERT INTO TB_USUARIO(NOME_USUARIO, USER_USUARIO, SENHA_USUARIO, EMAIL_USUARIO, DATA_NASC_USUARIO, SEXO_USUARIO, AREA_USUARIO) VALUES
('Oturan Topster', 'oturanadm', 'oturan10', 'oturan@gmail.com', '07/03/18', 'M', 'Ci�ncias Exatas');