create database bdExemploCrud;

use bdExemploCrud;

create table tbTarefas (
	id int not null primary key auto_increment,
	descricao varchar(100) not null,
	dataInicio date not null,
	dataFinal date null,
	nomeResponsavel varchar(100) null,
	categoria varchar(20),
	status varchar(20),
	observacoes text
);

create table tbUsuario (
	idUser int not null primary key auto_increment,
	nome varchar(100) not null,
	email varchar(100) unique not null,
	senha varchar(100) not null
);


