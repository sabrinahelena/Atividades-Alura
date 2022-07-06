SELECT [CPF]
      ,[NOME]
      ,[ENDERECO1]
      ,[ENDERECO2]
      ,[BAIRRO]
      ,[CIDADE]
      ,[ESTADO]
      ,[CEP]
      ,[DATA DE NASCIMENTO]
      ,[IDADE]
      ,[SEXO]
      ,[LIMITE DE CREDITO]
      ,[VOLUME DE COMPRA]
      ,[PRIMEIRA COMPRA]
  FROM [TABELA DE CLIENTES]

  SELECT * FROM [TABELA DE PRODUTOS] --Mostra tabela


  SELECT * FROM [TABELA DE PRODUTOS] WHERE [CODIGO DO PRODUTO] = '235653'
    SELECT * FROM [TABELA DE PRODUTOS] WHERE SABOR = 'Lim�o' -- Filtros

UPDATE [TABELA DE PRODUTOS] SET [PRECO DE LISTA] = 1.1 * [PRECO DE LISTA] WHERE [SABOR] = 'Lim�o' -- Seta o valor do pre�o + 10%

SELECT * FROM [TABELA DE PRODUTOS] WHERE [PRECO DE LISTA] > 10 -- Traz pre�os menores que 10
SELECT * FROM [TABELA DE PRODUTOS] WHERE [SABOR] <= 'Uva' -- Traz os que est�o antes de U na ordem alfab�tica, al�m de uva.

SELECT * FROM [TABELA DE CLIENTES] WHERE YEAR([DATA DE NASCIMENTO]) = 1995 -- Traz clientes que nasceram no ano de 1995
SELECT * FROM [TABELA DE CLIENTES] WHERE MONTH([DATA DE NASCIMENTO]) = 01 -- Traz clientes que nasceram m�s 1

--Abaixo filtramos pessoas que moram na barra da tijuca e nasceram em janeiro.
SELECT * FROM [TABELA DE CLIENTES] WHERE MONTH([DATA DE NASCIMENTO]) = 01 AND ([BAIRRO]) = 'Barra da Tijuca'