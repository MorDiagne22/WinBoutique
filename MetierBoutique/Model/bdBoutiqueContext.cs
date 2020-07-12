using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MetierBoutique.Model
{
    public class bdBoutiqueContext:DbContext
    {
        public bdBoutiqueContext():base("ConnBoutique") {
         Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Categorie> categories { get; set; }

        public DbSet<Produit> produits { get; set; }

        public DbSet<TdErreur> tdErreurs { get; set; }
    }
}