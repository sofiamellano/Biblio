﻿ using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Service.Models
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int EditorialId { get; set; } = 1;
        public Editorial? Editorial { get; set; }
        [Required]
        public int Paginas { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string Sinopsis { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public string Portada { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public override string ToString()
        {
            return Titulo;
        }

    }
}
