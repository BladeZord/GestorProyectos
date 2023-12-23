using Newtonsoft.Json;
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
        [JsonProperty]
        public DateTime Fecha_Creacion { get; private set; } = DateTime.UtcNow;

        [JsonProperty]
        public DateTime Fecha_Actualizacion { get; private set; } = DateTime.UtcNow;
    }

}
