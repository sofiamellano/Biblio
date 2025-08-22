﻿using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Genero
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public bool IsDeleted { get; set; } = false;
        public override string ToString()
        {
            return Nombre;
        }

    }
}
