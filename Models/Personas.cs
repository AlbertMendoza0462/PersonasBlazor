using System.ComponentModel.DataAnnotations;

namespace PersonasBlazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaID { get; set; }
        [Required(ErrorMessage = "Digete el nombre.")]
        public String Nombre { get; set; }
        [Range(2, 10, ErrorMessage = "Estatura Invalida!")]
        public float EstaturaEnPies { get; set; }
    }
}
