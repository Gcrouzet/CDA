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

        [Required(ErrorMessage = "Veuillez saisir un nom")]
        [StringLength(50, ErrorMessage = "Limite maximum de 50 caractères")]
        [Column("cat_Nom", TypeName = "varchar")]
        [Display(Name = "Nom de la catégorie")]
        public string Nom { get; set; }

        [Column("cat_description", TypeName = "Text")]
        [DataType(DataType.Text)]
        [Display(Name = "Description de la catégorie")]
        public string Description { get; set; }
    }
}
