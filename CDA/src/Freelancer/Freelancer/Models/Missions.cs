using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Missions
    {
        [Key]
        [Column("mission_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Column("mission_etat", TypeName = "char")]
        public char Etat { get; set; }

        [Required]
        [StringLength(100)]
        [Column("mission_titre")]
        public string Titre { get; set; }

        [DataType(DataType.Date)]
        [Column("mission_debut")]
        public DateTime Debut { get; set; }

        [DataType(DataType.Date)]
        [Column("mission_fin")]
        public DateTime Fin { get; set; }

        [Column("mission_description", TypeName = "text")]
        public string Description { get; set; }

        [Required]
        [Column("client_id")]
        [ForeignKey("Clients")]
        public int ClientId { get; set; }
    }
}
