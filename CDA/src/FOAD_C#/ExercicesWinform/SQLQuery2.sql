use Papyrus;
INSERT INTO fournisseur VALUES (1,'Torrenti','rue du poulpe','13400','Aubagne','Antoine',5)
INSERT INTO fournisseur VALUES (2,'Crouzet','rue de la fripouille','06000','Nice','James',5)
INSERT INTO fournisseur VALUES (3,'Schmitt','rue du chat','67330','Neuwiller','Elodie',5)

INSERT INTO ordre_commande VALUES (1,1,10000,'10/02/2018')
INSERT INTO ordre_commande VALUES (3,2,25000,'10/08/2020')
INSERT INTO ordre_commande VALUES (2,3,50000,'10/07/2016')

INSERT INTO vente VALUES (1,1)
INSERT INTO vente VALUES (3,2)
INSERT INTO vente VALUES (2,3)


INSERT INTO produits VALUES (1,'Cyberpunk',90000,100,500000,'gr')
INSERT INTO produits VALUES (2,'World of Warcraft',50000,100,250000,'gr')
INSERT INTO produits VALUES (3,'Overwatch',70000,100,250000,'gr')

INSERT INTO livraison VALUES (2,3)
INSERT INTO livraison VALUES (3,2)
INSERT INTO livraison VALUES (1,1)