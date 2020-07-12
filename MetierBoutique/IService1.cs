using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text; 
using MetierBoutique.Model;

namespace MetierBoutique
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string HelloWord();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
 
        [OperationContract]
        List<Categorie> getListeCategorie();
        
        [OperationContract]
        Categorie getCategorieById(int id);

        [OperationContract]
        bool addCategorie(Categorie categorie);

        [OperationContract]
        bool updateCategorie(Categorie categorie);

        [OperationContract]
        bool deleteCategorie(int id);
        //Operation de service Produit

        [OperationContract]
        List<Produit> getListeProduits();

        [OperationContract]
        List<Produit> getListeProduitsByAttribut(List<Produit> listeprod, string attribut, string val);

        [OperationContract]
        List<Produit> getListeProduitsByAttributInt(List<Produit> listeprod, string attribut, double val);

        [OperationContract]
        bool addProduit(Produit produit);

        [OperationContract]
        bool updateProduit(Produit produit);
        
        [OperationContract]
        Produit getProduitById(int id);
        
        [OperationContract]
        bool deleteProduit(int id);

        [OperationContract]
        Categorie getCategorie(int id);


        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
