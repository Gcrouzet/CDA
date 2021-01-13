using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Categories
    {
        [Column("cat_Id")]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("cat_Nom", TypeName = "varchar")]
        public string Nom { get; set; }

        [Column("cat_description", TypeName = "Text")]
        public string Description { get; set; }
    }
}
