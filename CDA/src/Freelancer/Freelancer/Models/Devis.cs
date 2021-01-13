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

        [Required]
        [StringLength(10)]
        [Column("devis_etat", TypeName = "char")]
        public char Etat { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column("devis_date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("devis_montant")]
        public int Montant { get; set; }

        [DataType(DataType.Date)]
        [Column("devis_date_finale")]
        public DateTime DevisDateFinale { get; set; }

        [Column("devis_montant_final")]
        public int MontantFinal { get; set; }

        [Required]
        [Column("mission_id")]
        [ForeignKey("Missions")]
        public int MissionId { get; set; }
    }
}
