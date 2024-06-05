CREATE TABLE [dbo]. [Exemplo]
(-- chave primaria auto encrement
[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Nome] NVARCHAR(MAX),
[Sobrenome] NVARCHAR(MAX)
);

INSERT INTO Exemplo (Nome, Sobrenome) VALUES ('Cássio', 'Capucho');
INSERT INTO Exemplo (Nome, Sobrenome) VALUES ('João', 'Silve');
INSERT INTO Exemplo (Nome, Sobrenome) VALUES ('Pedro', 'Souza');

select * from Exemplo;