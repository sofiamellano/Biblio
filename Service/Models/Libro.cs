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

        [NotMapped]
        virtual public string Autores
        {
            get
            {
                if (LibrosAutores == null || LibrosAutores.Count == 0)
                    return string.Empty;
                var textAutor = LibrosAutores.Count > 1 ? "Autores: " : "Autor: ";
                return textAutor + string.Join(", ", LibrosAutores.Where(la => la.Autor != null && !la.Autor.IsDeleted).Select(la => la.Autor!.Nombre));
            }
        }
        [NotMapped]
        virtual public string Generos
        {
            get
            {
                if (LibrosGeneros == null || LibrosGeneros.Count == 0)
                    return string.Empty;
                var textGenero = LibrosGeneros.Count > 1 ? "Géneros: " : "Género: ";
                return textGenero + string.Join(", ", LibrosGeneros.Where(lg => lg.Genero != null).Select(lg => lg.Genero!.Nombre));
            }
        }

        virtual public ICollection<LibroAutor> LibrosAutores { get; set; } = new List<LibroAutor>();
        virtual public ICollection<LibroGenero> LibrosGeneros { get; set; } = new List<LibroGenero>();
        public override string ToString()
        {
            return Titulo;
        }

    }
}
