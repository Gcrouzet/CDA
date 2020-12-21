use papyrus;
GO
CREATE PROCEDURE GetCommandesParFournisseur
(@codeFournisseur int)
AS
SET NOCOUNT ON;
SELECT * FROM commande  
INNER JOIN ordre_commande  
ON commande.commande_id = ordre_commande.commande_id 
INNER JOIN produits  
ON ordre_commande.produits_id = produits.produits_id 
INNER JOIN fournisseur 
ON produits.fournisseur_id = fournisseur.fournisseur_id 
WHERE fournisseur.fournisseur_id =@codeFournisseur
GO