drop database if exists auth_users;
create database auth_users;
USE auth_users;

DROP TABLE if exists user;
create table user
(
	idUser int NOT NULL auto_increment primary key,
    pseudo varchar(50),
    mail varchar (50),
    passwd varchar(40))engine=innodb;

DROP TABLE if exists information;
create table information 
(
    idInfo int NOT Null auto_increment PRIMARY KEY,
    idUser int , 
    prenom varchar(50),
	nom varchar(50),
    nomEntreprise varchar(50),
    rue varchar (50),
    ville varchar (40),
    codePostal int (6),
    dateCreation date,
    tel int (12))engine=innodb;

DROP TABLE if exists formation;
create table formation 
(
    idForm int not null auto_increment primary key,
    libelle varchar(50),
    prix int, 
    idUser int)engine=innodb;

    
alter table information
add constraint fk_information_idUser FOREIGN KEY (idUser) REFERENCES user(idUser);

alter table formation
add constraint fk_formation_idUser FOREIGN KEY (idUser) REFERENCES user(idUser);

ALTER TABLE information
ADD tel int (12);

select idUser, mail from user where mail = "lout@gmail.com";

insert into information values (,1,"yass","loutfi","Cabinet","garag", "lyvr",95140,2021-04-04,0650744930);