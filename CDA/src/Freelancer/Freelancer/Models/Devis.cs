using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Devis
    {
        [Key]
        [Column("devis_id")]
        public int DevisId { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un état")]
        [StringLength(10, ErrorMessage = "Limite maximum de 10 caractères")]
        [Column("devis_etat", TypeName = "char")]
        public char Etat { get; set; }

        [Required(ErrorMessage = "Veuillez saisir une date")]
        [DataType(DataType.Date)]
        [Column("devis_date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un montant")]
        [Column("devis_montant")]
        public int Montant { get; set; }

        [DataType(DataType.Date)]
        [Column("devis_date_finale")]
        public DateTime DevisDateFinale { get; set; }

        [Column("devis_montant_final")]
        public int MontantFinal { get; set; }

        [Required(ErrorMessage = "Veuillez saisir une mission")]
        [Column("mission_id")]
        [ForeignKey("Missions")]
        public int MissionId { get; set; }
    }
}
