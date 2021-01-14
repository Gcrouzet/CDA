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

        [Required(ErrorMessage = "Veuillez saisir un état")]
        [StringLength(10, ErrorMessage = "Limite maximum de 10 caractères")]
        [Column("mission_etat", TypeName = "char")]
        public char Etat { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un titre")]
        [StringLength(100, ErrorMessage = "Limite maximum de 100 caractères")]
        [Column("mission_titre")]
        public string Titre { get; set; }

        [DataType(DataType.Date)]
        [Column("mission_debut")]
        public DateTime Debut { get; set; }

        [DataType(DataType.Date)]
        [Column("mission_fin")]
        public DateTime Fin { get; set; }

        [DataType(DataType.Text)]
        [Column("mission_description", TypeName = "text")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un client")]
        [Column("client_id")]
        [ForeignKey("Clients")]
        public int ClientId { get; set; }
    }
}
