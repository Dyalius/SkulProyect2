using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SkulProyect2.Models
{
    public class Representante
    {
        [Key]
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Parentesco { get; set; }
        public int Telefono { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }
    }
}