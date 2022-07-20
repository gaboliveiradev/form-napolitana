CREATE DATABASE napolitanaDB;

USE napolitanaDB;

CREATE TABLE IF NOT EXISTS Funcionario (
	id int auto_increment NOT NULL,
	nome varchar(100) NOT NULL,
	senha varchar(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS Despesas (
	id int auto_increment NOT NULL,
    nome varchar(100) NOT NULL,
    valor double NOT NULL,
    primary key (id)
);

CREATE TABLE IF NOT EXISTS Produto (
	id int auto_increment NOT NULL,
	nome varchar(100) NOT NULL,
	preco double NOT NULL,
    quantidade int NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS Venda (
	id int auto_increment NOT NULL,
	id_funcionario int NOT NULL,
	valor double NOT NULL,
	data_venda TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (id),
	FOREIGN KEY (id_funcionario) REFERENCES Funcionario(id)
);

CREATE TABLE IF NOT EXISTS Caixa (
	id int auto_increment NOT NULL,
	id_funcionario int NOT NULL,
	abertura TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	fechamento TIMESTAMP DEFAULT NULL,
	saldo double DEFAULT 0,
	PRIMARY KEY (id),
	FOREIGN KEY (id_funcionario) REFERENCES Funcionario(id)
);

CREATE TABLE IF NOT EXISTS VENDA_CAIXA_ASSOC (
	id int auto_increment NOT NULL,
	id_venda int NOT NULL,
	id_caixa int NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(id_venda) REFERENCES Venda (id),
	FOREIGN KEY(id_caixa) REFERENCES Caixa (id)
);

CREATE TABLE IF NOT EXISTS PRODUTO_VENDA_ASSOC (
	id int auto_increment NOT NULL,
	id_produto int NOT NULL,
	id_venda int NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(id_produto) REFERENCES Produto (id),
	FOREIGN KEY(id_venda) REFERENCES Venda (id)
);