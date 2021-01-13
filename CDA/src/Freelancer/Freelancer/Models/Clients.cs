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

       
        [StringLength(100)]
        public string Nom { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column("cat_id")]
        [ForeignKey("Categories")]
        public int CatId { get; set; }

    }
}
