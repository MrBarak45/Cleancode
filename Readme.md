Nous allons creer :



# Un namespace INFRA qui contiendra :
- Les Entités : Prices, ProductCatalog, SellHistory et User.
- Les Repository : HistoryRepository, ProductRepository et UserRepository.
- Database



# Un namespace UserCases qui contiendra :
- ProductCalc : interface qui contiendra les methodes.
- PublicUserProductCalc : qui contiendra les regles metiers de calcul du prix dans le cas d'un utilisateur non enregistré
- RegisteredUserProductCalc : qui contiendra les regles metiers de calcul du prix dans le cas d'un utilisateur enregistré selon son historique sur les 6 derniers mois.
