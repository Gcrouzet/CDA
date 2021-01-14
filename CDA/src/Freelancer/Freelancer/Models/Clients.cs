using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Clients
    {
        [Column("client_id")]
        [Key]
        public int ClientId { get; set; }

       
        [StringLength(100, ErrorMessage = "Limite maximum de 100 caractères")]
        public string Nom { get; set; }

        
        [Required(ErrorMessage = "Veuillez saisir une adresse e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez selectionner une catégorie")]
        [Column("cat_id")]
        [ForeignKey("Categories")]
        public int CatId { get; set; }

    }
}
