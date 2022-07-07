create table Estados
(
	estado varchar(10),
	valor money
)

insert into Estados VALUES
('SP', 1000),
('SP', 1234),
('SP', 1234),
('SP', 1234),
('SP', 1234),
('SP', 5000),
('SP', 8352),
('RJ', 532),
('RJ', 1225),
('RJ', 6333),
('RJ', 1235),
('RJ', 9000)


-- Soma valores dos estados e agrupa os estados iguais
select Estado, sum(valor) FROM Estados group by estado

-- Traz o maior valor
select Estado, max(valor) FROM Estados group by estado

-- Traz o menor valor
select Estado, min(valor) FROM Estados group by estado
-- Traz a média total
select Estado, avg(valor) FROM Estados group by estado
-- Traz a quantidade de valores para os estados agrupados.
select Estado, count(valor) FROM Estados group by estado

-- Inner join
SELECT Nome, Email, CPF, Endereço, [Numero da conta], Saldo FROM Clientes INNER JOIN Contas ON Clientes.Id_Contas = Contas.Id-- Traz valores nulos da tabela Clientes
SELECT * FROM Clientes INNER JOIN Contas ON Clientes.Id_Contas = Contas.Id order by Saldo asc
-- Left join
SELECT * FROM Clientes LEFT JOIN Contas ON Clientes.Id_Contas = Contas.Id -- Traz valores nulos da tabela Contas
-- Right join
SELECT Nome, Email, CPF, Endereço, Saldo FROM Clientes right JOIN Contas ON Clientes.Id_Contas = Contas.Id-- Traz valores nulos da tabela Clientes
SELECT * FROM Clientes RIGHT JOIN Contas ON Clientes.Id_Contas = Contas.Id



-- INSERT

insert into Clientes values
('Lucia Helena Silva', 'luciasilva@gmail.com', '24612496321', 'R. Pampulha, B. Santa, N 214, Cidade BH, estado MG', 2),
('Tatiane Rocha', 'tatianerocha@gmail.com', '12396432196', ' ', 4)

insert into Clientes Values
('Maria Eduarda Sampaio', 'mariaduda@gmail.com', '34851924012', 'R. Andrade, B. Male, n 12, Cidade BH, estado MG', 5),
('Maria Cecília Alves', 'macecilia@gmail.com', '38591029481', '', 6),
('Luiza Batista', 'lubatista@hotmail.com', '12952839291', '', 7)

insert into Clientes Values
('Mariana Alva', 'marianaalva@hotmail.com', '7564837465', 'R. Maria Helena, B. Generoso, N 2341, Cidade BH, estado MG', 10)

insert into Contas values
(52, 3400),
(46, 30000)

-- UPDATE

update Contas set [Saldo] = [Saldo] * 2 WHERE [Numero da conta] = 23 -- Duplica saldo

SELECT * FROM Contas