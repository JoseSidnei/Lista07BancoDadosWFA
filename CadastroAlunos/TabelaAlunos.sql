﻿DROP TABLE alunos;
CREATE TABLE alunos(
	id INT IDENTITY (1,1) PRIMARY KEY,	
	nome VARCHAR(150) NOT NULL,
	codigo_matricula VARCHAR(100) NOT NULL,
	nota_1 FLOAT  NOT NULL,
	nota_2 FLOAT  NOT NULL,
	nota_3 FLOAT  NOT NULL,
	frequencia TINYINT
);