using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Models
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int EditorialID { get; set; } = 1;
        public Editorial? Editorial { get; set; }
        [Required]
        public int Paginas { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string Sinopsis { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public string Portada { get; set; }
    }
}
