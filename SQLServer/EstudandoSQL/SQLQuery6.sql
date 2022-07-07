-- CRIAÇÃO DO BANCO DE DADOS
create database Banco
use Banco

-- CRIAÇÃO TABELA CLIENTES
create table Clientes
(
Nome varchar(60) not null,
Email varchar(100) not null,
CPF varchar(11)  not null,
[Endereço] varchar(100) not null

);

-- ADICIONANDO PK NA TABELA CLIENTES
ALTER TABLE Clientes 
ADD Constraint PK_CLIENTES PRIMARY KEY CLUSTERED (CPF)


-- CRIAÇÃO TABELA CONTAS
create table Contas(
Id int primary key identity,
[Numero da conta] smallint not null,
Saldo money not null,
);

-- CRIAÇÃO COLUNA ID_CONTAS PARA SER A FK 
ALTER TABLE Clientes
ADD Id_Contas int not null


-- ADICIONANDO FK NA Id_Contas REFERENCIANDO O PK DE CONTAS (Id).
ALTER TABLE Clientes
ADD CONSTRAINT FK_Contas_Clientes foreign key (Id_Contas) references Contas(Id)

-- Agora, 1 cliente pode acessar uma conta.


-- ADICIONANDO VALORES EM CONTA

INSERT INTO Contas VALUES
(
23,
2.232 --Automaticamente é adicionado na PK 1. id é 1
)

INSERT INTO Contas VALUES
( 54, 6.231 ),
( 48, 1.230 ),
( 12, 900),
( 89, 60.123),
( 73, 12),
( 05, 100)





-- ADICIONANDO VALORES EM CLIENTES
INSERT INTO Clientes VALUES 
(
'Sabrina Helena Ferreira',
'sabrinahelenaf@gmail.com',
'08915187521',
'R. Graças de Lurdes, B. Maria Helena, N 214, Cidade BH, estado MG.',
1 -- Add na PK Id de Contas 1, ou seja, associado a conta 1.
);

INSERT INTO Clientes VALUES
('Helena Santos', 'helenasantos@gmail.com', '12345678912', 'R. Tal de tal, B. Fulano, N 12, Cidade BH, estado MG', 3)

-- Exibindo tabela clientes
SELECT * FROM Clientes
-- Exibindo tabela contas
SELECT * FROM Contas

-- Filtros

SELECT * FROM Contas WHERE Saldo > 1.000 -- Filtra saldos maiores que 1.000

SELECT * FROM Clientes order by CPF desc; -- Mostra os clientes em ordem decrescente de cpf. Asc é crescente.

