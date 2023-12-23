using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GProyectos.Models
{
    public class Clients
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Empresa { get; set; }
        [Required]
        public string Representante1 { get; set; }
        [Required]
        public string Representante2 { get; set; }
        [Required]
        public string Representante3 { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Provincia { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Sector_Laboral { get; set; }
        [Required]
        public DateTime Fecha_Creacion { get; private set; } = DateTime.UtcNow;

        public DateTime Fecha_Actualizacion { get; set; } = DateTime.UtcNow;

        // Puedes agregar un constructor para inicializar la Fecha_Creacion al crear una nueva instancia
        public Clients()
        {
            Fecha_Creacion = DateTime.UtcNow;
        }

    }
}
