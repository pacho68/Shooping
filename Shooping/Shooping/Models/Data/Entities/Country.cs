using System.ComponentModel.DataAnnotations;

namespace Shooping.Models.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display (Name ="Pais")]
        [MaxLength(50, ErrorMessage ="el campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage ="el campo {0} es obligatorio")]
        public string Name { get; set; }


    }
}
