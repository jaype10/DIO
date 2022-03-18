CREATE TABLE pessoas (
    id INT NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome VARCHAR(30) NOT NULL,
    nascimento DATE
)

INSERT INTO pessoas (nome, nascimento) VALUES ('João Paulo', '1996 07 15')
INSERT INTO pessoas (nome, nascimento) VALUES ('Pedro', '1994 08 17')
INSERT INTO pessoas (nome, nascimento) VALUES ('Marcela', '2000 04 03')
INSERT INTO pessoas (nome, nascimento) VALUES ('Bruna', '2005 11 20')