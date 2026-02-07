using System;
using System.ComponentModel.DataAnnotations;

namespace PersonasApi.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
