using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierBoutique.Model;
using System.IO;
using System.Diagnostics;

namespace MetierBoutique
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        private bdBoutiqueContext db = new bdBoutiqueContext();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string HelloWord()
        {
            return "Bonjour Le monde";
        }

        public List<Categorie> getListeCategorie()
        {
            return db.categories.ToList();
        } 

        public Categorie getCategorieById(int id)
        {
            return db.categories.Find(id);
        }

        public bool addCategorie(Categorie categorie)
        {
            bool rep = false;
            try
            {
                db.categories.Add(categorie);
                db.SaveChanges();
                rep = true;
            }
            catch(Exception ex)
            {

            }
            return rep;
        }

        public bool updateCategorie(Categorie categorie)
        {
            bool rep = false;
            try
            {
                db.Entry(categorie).State = EntityState.Modified;
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public bool deleteCategorie(int id)
        {
            bool rep = false;
            try
            {
                Categorie categorie = db.categories.Find(id);
                db.categories.Remove(categorie);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }
  
        // Service pour produit

        public List<Produit> getListeProduits()
        {
            return db.produits.ToList();
        }

        public bool addProduit(Produit produit)
        {
            bool rep = false;
            try
            {
                db.produits.Add(produit);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                TdErreur erreur = new TdErreur();
                erreur.Libelle = "Ajout de produit";
                erreur.Description = ex.ToString();
                //setErreur(erreur);
                //WriteError(erreur);
                writeLogSystem(erreur);
            }
            return rep;
        }

        public bool updateProduit(Produit produit)
        {
            bool rep = false;
            try
            {
                db.Entry(produit).State = EntityState.Modified;
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                TdErreur erreur = new TdErreur();
                erreur.Libelle = "Modification de produit";
                erreur.Description = ex.ToString();
                //setErreur(erreur);
                WriteError(erreur);
            }
            return rep;
        }

        public Produit getProduitById(int id)
        {
            return db.produits.Find(id);
        }

        public bool deleteProduit(int id)
        {
            bool rep = false;
            try
            {
                Produit produit = db.produits.Find(id);
                db.produits.Remove(produit);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                TdErreur erreur = new TdErreur();
                erreur.Libelle = "Suppression de produit";
                erreur.Description = ex.ToString();
                //setErreur(erreur);
                WriteError(erreur);
            }
            return rep;
        }

        public Categorie getCategorie(int id)
        {
            return db.categories.Find(id);
        }

        public static bool setErreur(TdErreur erreur)
        {
            bdBoutiqueContext db1 = new bdBoutiqueContext();
            bool rep = false;
            try
            {
                db1.tdErreurs.Add(erreur);
                db1.SaveChanges();
                rep = true;
            }catch(Exception ex)
            {
                WriteError(erreur);
            }

            return rep; 
        }

        public static void WriteError(TdErreur erreur)
        {
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/Error/fileError.txt");
                System.IO.TextWriter writeFile = new StreamWriter(path, true);
                writeFile.WriteLine("" + erreur.dateErreur);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.WriteLine(erreur.Libelle);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");
                writeFile.WriteLine(erreur.Description);
                writeFile.WriteLine("---------------------------------------------------------------------------------------");

                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException e)
            {
                // WriteError(e.ToString());
                writeLogSystem(erreur);
            }
        }

        public List<Produit> getListeProduitsByAttribut(List<Produit> listeprod, string attribut, string val)
        {
            switch (attribut)
            {
                case "code":
                    listeprod = listeprod.Where(s => s.CodeProduit.IndexOf(val, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                    return listeprod;
                    break;
                case "designation":
                    listeprod = listeprod.Where(s => s.DesignationProduit.IndexOf(val, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                    return listeprod;
                    break;

            }
            return listeprod;
        }

        public List<Produit> getListeProduitsByAttributInt(List<Produit> listeprod, string attribut, double val)
        {
            switch (attribut)
            {
                case "qteMin":
                    listeprod = listeprod.Where(s => s.QuantiteMinimale == val).ToList();
                    return listeprod;
                    break;
                case "qteCrit":
                    listeprod = listeprod.Where(s => s.QuantiteQritique == val).ToList();
                    return listeprod;
                    break;

            }
            return listeprod;
        }

        public static void writeLogSystem(TdErreur erreur)
        {
            using(EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "WinBoutique";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description: {2}", erreur.dateErreur, erreur.Libelle, erreur.Description));
            }
        }
    }
}
