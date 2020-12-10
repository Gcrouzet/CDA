﻿USE master;
DROP DATABASE IF EXISTS Papyrus;
CREATE DATABASE Papyrus;
USE Papyrus;
create table produits
(
produits_id char(2) primary key,
produits_label varchar(50),
produits_stock_reel int,
produits_stock_critique int,
produits_qt_annuel int,
produits_mesure varchar(4),
) ;
create table fournisseur
(
fournisseur_id char(2) primary key,
fournisseur_nom varchar(50),
fournisseur_adresse varchar(100),
fournisseur_cp char(5),
fournisseur_ville varchar(50),
fournisseur_contact varchar(50),
fournisseur_satisfaction tinyint,
);
create table commande
(
commande_id char(2) primary key,
commande_date DATE,
commande_commentaire varchar(100),
);
create table vente
(
fournisseur_id char(2),
produits_id char(2),
CONSTRAINT pk_fournisseur_produits PRIMARY KEY (fournisseur_id , produits_id),
CONSTRAINT fk_fournisseur FOREIGN KEY (fournisseur_id)
        REFERENCES fournisseur (fournisseur_id),
CONSTRAINT fk_produits FOREIGN KEY (produits_id)
        REFERENCES produits (produits_id)
);
create table ordre_commande
(
produits_id char(2),
fournisseur_id char(2),
ordre_commande_quantite int,
ordre_commande_date DATE,
CONSTRAINT pk_commande PRIMARY KEY (fournisseur_id , produits_id),
CONSTRAINT fk_fournisseurs FOREIGN KEY (fournisseur_id)
        REFERENCES fournisseur (fournisseur_id),
CONSTRAINT fk_produit FOREIGN KEY (produits_id)
        REFERENCES produits (produits_id)
);
create table livraison
(
fournisseur_id char(2),
produits_id char(2),
CONSTRAINT pk_livraison PRIMARY KEY (fournisseur_id , produits_id),
CONSTRAINT fk_fournisseur_livraison FOREIGN KEY (fournisseur_id)
        REFERENCES fournisseur (fournisseur_id),
CONSTRAINT fk_produit_livraison FOREIGN KEY (produits_id)
        REFERENCES produits (produits_id)
);