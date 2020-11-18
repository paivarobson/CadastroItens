
--create database CADASTRO;

--use CADASTRO;

--use master;
--drop database cadastro;


--drop table PRODUTO;
--drop table ESTABELECIMENTO;
--drop table LOCALIDADE;
--drop table FORMA_PAGAMENTO;
--drop table COMPRA;
--drop table COMPRA_ITEM;


--select * from PRODUTO;
--select * from ESTABELECIMENTO;
--select * from LOCALIDADE;
--select * from FORMA_PAGAMENTO;
--select * from COMPRA;
--select * from COMPRA_ITEM;

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
	QTD_ITENS_COMP int null,
	VLR_COMP money not null,
	OBS_COMPRA varchar(500) null,
	FORM_PAG_COMP int not null,
	COD_EST int not null,
	COD_LOC int not null,
	constraint PK_COD_COMP_COMPRA primary key (COD_COMP),
	constraint FK_COD_EST_ESTABELECIMENTO foreign key (COD_EST) references ESTABELECIMENTO(COD_EST),
	constraint FK_COD_LOC_LOCALIDADE foreign key (COD_LOC) references LOCALIDADE(COD_LOC),
);

create table COMPRA_ITEM (
	COD_COMP_ITEM int identity,
	COD_COMP int not null,
	COD_INT_PRO int not null,
	QTD_COMP_ITEM int not null,
	VLR_UNT_COMP_ITEM money not null,
	constraint PK_COD_COMP_COMPRA_ITEM primary key (COD_COMP_ITEM),
	constraint FK_COD_COMP_COMPRA foreign key (COD_COMP) references COMPRA(COD_COMP),
	constraint FK_COD_PRO_PRODUTO foreign key (COD_INT_PRO) references PRODUTO(COD_INT_PRO),
);


