﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinBoutique.MetiersBoutique {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MetiersBoutique.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloWord", ReplyAction="http://tempuri.org/IService1/HelloWordResponse")]
        string HelloWord();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloWord", ReplyAction="http://tempuri.org/IService1/HelloWordResponse")]
        System.Threading.Tasks.Task<string> HelloWordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MetierBoutique.CompositeType GetDataUsingDataContract(MetierBoutique.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MetierBoutique.CompositeType> GetDataUsingDataContractAsync(MetierBoutique.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeCategorie", ReplyAction="http://tempuri.org/IService1/getListeCategorieResponse")]
        MetierBoutique.Model.Categorie[] getListeCategorie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeCategorie", ReplyAction="http://tempuri.org/IService1/getListeCategorieResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Categorie[]> getListeCategorieAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCategorieById", ReplyAction="http://tempuri.org/IService1/getCategorieByIdResponse")]
        MetierBoutique.Model.Categorie getCategorieById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCategorieById", ReplyAction="http://tempuri.org/IService1/getCategorieByIdResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Categorie> getCategorieByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addCategorie", ReplyAction="http://tempuri.org/IService1/addCategorieResponse")]
        bool addCategorie(MetierBoutique.Model.Categorie categorie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addCategorie", ReplyAction="http://tempuri.org/IService1/addCategorieResponse")]
        System.Threading.Tasks.Task<bool> addCategorieAsync(MetierBoutique.Model.Categorie categorie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateCategorie", ReplyAction="http://tempuri.org/IService1/updateCategorieResponse")]
        bool updateCategorie(MetierBoutique.Model.Categorie categorie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateCategorie", ReplyAction="http://tempuri.org/IService1/updateCategorieResponse")]
        System.Threading.Tasks.Task<bool> updateCategorieAsync(MetierBoutique.Model.Categorie categorie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCategorie", ReplyAction="http://tempuri.org/IService1/deleteCategorieResponse")]
        bool deleteCategorie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteCategorie", ReplyAction="http://tempuri.org/IService1/deleteCategorieResponse")]
        System.Threading.Tasks.Task<bool> deleteCategorieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduits", ReplyAction="http://tempuri.org/IService1/getListeProduitsResponse")]
        MetierBoutique.Model.Produit[] getListeProduits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduits", ReplyAction="http://tempuri.org/IService1/getListeProduitsResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduitsByAttribut", ReplyAction="http://tempuri.org/IService1/getListeProduitsByAttributResponse")]
        MetierBoutique.Model.Produit[] getListeProduitsByAttribut(MetierBoutique.Model.Produit[] listeprod, string attribut, string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduitsByAttribut", ReplyAction="http://tempuri.org/IService1/getListeProduitsByAttributResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsByAttributAsync(MetierBoutique.Model.Produit[] listeprod, string attribut, string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduitsByAttributInt", ReplyAction="http://tempuri.org/IService1/getListeProduitsByAttributIntResponse")]
        MetierBoutique.Model.Produit[] getListeProduitsByAttributInt(MetierBoutique.Model.Produit[] listeprod, string attribut, double val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduitsByAttributInt", ReplyAction="http://tempuri.org/IService1/getListeProduitsByAttributIntResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsByAttributIntAsync(MetierBoutique.Model.Produit[] listeprod, string attribut, double val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addProduit", ReplyAction="http://tempuri.org/IService1/addProduitResponse")]
        bool addProduit(MetierBoutique.Model.Produit produit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addProduit", ReplyAction="http://tempuri.org/IService1/addProduitResponse")]
        System.Threading.Tasks.Task<bool> addProduitAsync(MetierBoutique.Model.Produit produit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateProduit", ReplyAction="http://tempuri.org/IService1/updateProduitResponse")]
        bool updateProduit(MetierBoutique.Model.Produit produit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateProduit", ReplyAction="http://tempuri.org/IService1/updateProduitResponse")]
        System.Threading.Tasks.Task<bool> updateProduitAsync(MetierBoutique.Model.Produit produit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProduitById", ReplyAction="http://tempuri.org/IService1/getProduitByIdResponse")]
        MetierBoutique.Model.Produit getProduitById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProduitById", ReplyAction="http://tempuri.org/IService1/getProduitByIdResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Produit> getProduitByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteProduit", ReplyAction="http://tempuri.org/IService1/deleteProduitResponse")]
        bool deleteProduit(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteProduit", ReplyAction="http://tempuri.org/IService1/deleteProduitResponse")]
        System.Threading.Tasks.Task<bool> deleteProduitAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCategorie", ReplyAction="http://tempuri.org/IService1/getCategorieResponse")]
        MetierBoutique.Model.Categorie getCategorie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCategorie", ReplyAction="http://tempuri.org/IService1/getCategorieResponse")]
        System.Threading.Tasks.Task<MetierBoutique.Model.Categorie> getCategorieAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WinBoutique.MetiersBoutique.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WinBoutique.MetiersBoutique.IService1>, WinBoutique.MetiersBoutique.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string HelloWord() {
            return base.Channel.HelloWord();
        }
        
        public System.Threading.Tasks.Task<string> HelloWordAsync() {
            return base.Channel.HelloWordAsync();
        }
        
        public MetierBoutique.CompositeType GetDataUsingDataContract(MetierBoutique.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.CompositeType> GetDataUsingDataContractAsync(MetierBoutique.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public MetierBoutique.Model.Categorie[] getListeCategorie() {
            return base.Channel.getListeCategorie();
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Categorie[]> getListeCategorieAsync() {
            return base.Channel.getListeCategorieAsync();
        }
        
        public MetierBoutique.Model.Categorie getCategorieById(int id) {
            return base.Channel.getCategorieById(id);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Categorie> getCategorieByIdAsync(int id) {
            return base.Channel.getCategorieByIdAsync(id);
        }
        
        public bool addCategorie(MetierBoutique.Model.Categorie categorie) {
            return base.Channel.addCategorie(categorie);
        }
        
        public System.Threading.Tasks.Task<bool> addCategorieAsync(MetierBoutique.Model.Categorie categorie) {
            return base.Channel.addCategorieAsync(categorie);
        }
        
        public bool updateCategorie(MetierBoutique.Model.Categorie categorie) {
            return base.Channel.updateCategorie(categorie);
        }
        
        public System.Threading.Tasks.Task<bool> updateCategorieAsync(MetierBoutique.Model.Categorie categorie) {
            return base.Channel.updateCategorieAsync(categorie);
        }
        
        public bool deleteCategorie(int id) {
            return base.Channel.deleteCategorie(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteCategorieAsync(int id) {
            return base.Channel.deleteCategorieAsync(id);
        }
        
        public MetierBoutique.Model.Produit[] getListeProduits() {
            return base.Channel.getListeProduits();
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsAsync() {
            return base.Channel.getListeProduitsAsync();
        }
        
        public MetierBoutique.Model.Produit[] getListeProduitsByAttribut(MetierBoutique.Model.Produit[] listeprod, string attribut, string val) {
            return base.Channel.getListeProduitsByAttribut(listeprod, attribut, val);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsByAttributAsync(MetierBoutique.Model.Produit[] listeprod, string attribut, string val) {
            return base.Channel.getListeProduitsByAttributAsync(listeprod, attribut, val);
        }
        
        public MetierBoutique.Model.Produit[] getListeProduitsByAttributInt(MetierBoutique.Model.Produit[] listeprod, string attribut, double val) {
            return base.Channel.getListeProduitsByAttributInt(listeprod, attribut, val);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Produit[]> getListeProduitsByAttributIntAsync(MetierBoutique.Model.Produit[] listeprod, string attribut, double val) {
            return base.Channel.getListeProduitsByAttributIntAsync(listeprod, attribut, val);
        }
        
        public bool addProduit(MetierBoutique.Model.Produit produit) {
            return base.Channel.addProduit(produit);
        }
        
        public System.Threading.Tasks.Task<bool> addProduitAsync(MetierBoutique.Model.Produit produit) {
            return base.Channel.addProduitAsync(produit);
        }
        
        public bool updateProduit(MetierBoutique.Model.Produit produit) {
            return base.Channel.updateProduit(produit);
        }
        
        public System.Threading.Tasks.Task<bool> updateProduitAsync(MetierBoutique.Model.Produit produit) {
            return base.Channel.updateProduitAsync(produit);
        }
        
        public MetierBoutique.Model.Produit getProduitById(int id) {
            return base.Channel.getProduitById(id);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Produit> getProduitByIdAsync(int id) {
            return base.Channel.getProduitByIdAsync(id);
        }
        
        public bool deleteProduit(int id) {
            return base.Channel.deleteProduit(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteProduitAsync(int id) {
            return base.Channel.deleteProduitAsync(id);
        }
        
        public MetierBoutique.Model.Categorie getCategorie(int id) {
            return base.Channel.getCategorie(id);
        }
        
        public System.Threading.Tasks.Task<MetierBoutique.Model.Categorie> getCategorieAsync(int id) {
            return base.Channel.getCategorieAsync(id);
        }
    }
}
