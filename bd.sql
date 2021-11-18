create database joao47;
use joao47;

create table login(
id int auto_increment primary key,
nome varchar(50) not null,
senha varchar(50) not null
)ENGINE = innodb;

create table brinquedos(
id int auto_increment primary key,
nome varchar(80) not null,
preco double not null
)ENGINE = innodb;

create table categoria(
id int auto_increment primary key,
descricao varchar(80) not null,
tipo varchar(80) not null
)ENGINE = innodb;

alter table categoria add constraint fk_id foreign key (id) references brinquedos (id); 

