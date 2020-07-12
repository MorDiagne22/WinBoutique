using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierBoutique.Model
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(3), Required]
        public string CodeCategorie { get; set; }

        [StringLength(100), Required]
        public string DesignationCategorie { get; set; }

        
    }
}