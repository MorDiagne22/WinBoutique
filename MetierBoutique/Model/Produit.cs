using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierBoutique.Model
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }

        [StringLength(4), Required]
        public string CodeProduit { get; set; }

        [StringLength(100), Required]
        public string DesignationProduit { get; set; }
        public double? Quantite { get; set; }
        public double? QuantiteMinimale { get; set; }
        public double? QuantiteQritique { get; set; }

        public double Pu { get; set; }

        [StringLength(100)]
        public string Image { get; set; }
        public int IdCategorie { get; set; }

       // [ForeignKey("IdCategorie")]
        //public virtual Categorie Categorie { get; set; }
    }
}