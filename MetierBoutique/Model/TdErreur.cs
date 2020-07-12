using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierBoutique.Model
{
    public class TdErreur
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Libelle { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime dateErreur { get; set; }

        public TdErreur()
        {
            dateErreur = DateTime.Now;
        }

    }
}