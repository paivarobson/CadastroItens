
--create database CADASTRO;

--use CADASTRO;

--use master
--drop database cadastro
--drop table compra

--select * from PRODUTO;
--select * from ESTABELECIMENTO;
--select * from LOCALIDADE;
--select * from FORMA_PAGAMENTO;
--select * from COMPRA;

create table PRODUTO (
	COD_INT_PRO int identity,
	COD_PRO int null,
	DESC_INT_PRO varchar(250) null,
	DESC_PRO varchar(250) not null,
	constraint PK_COD_INT_PRO primary key (COD_INT_PRO)
);

create table ESTABELECIMENTO (
	COD_EST int identity,
	CNPJ_EST int not null,
	NOME_EST varchar(250) not null,
	constraint PK_COD_EST_ESTABELECIMENTO primary key (COD_EST)
);

create table LOCALIDADE (
	COD_LOC int identity,
	NOME_LOC varchar(100) not null,
	constraint PK_COD_LOC_LOCALIDADE primary key (COD_LOC)
);

create table FORMA_PAGAMENTO (
	COD_FORM_PAG int identity,
	DESC_FORM_PAG varchar(50) not null,
	constraint PK_COD_FORM_PAG primary key (COD_FORM_PAG)
);

create table COMPRA (
	COD_COMP int identity,
	DAT_COMP datetime not null,
	VLR_ITEM_COMP money not null,
	FORM_PAG_COMP int not null,
	COD_INT_PRO int not null,
	COD_EST int not null,
	COD_LOC int not null,
	constraint PK_COD_COMP_COMPRA primary key (COD_COMP),
	constraint FK_COD_PRO_PRODUTO foreign key (COD_INT_PRO) references PRODUTO(COD_INT_PRO),
	constraint FK_COD_EST_ESTABELECIMENTO foreign key (COD_EST) references ESTABELECIMENTO(COD_EST),
	constraint FK_COD_LOC_LOCALIDADE foreign key (COD_LOC) references LOCALIDADE(COD_LOC),
);


