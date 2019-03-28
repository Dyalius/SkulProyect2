using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkulProyect2.Models
{
    public class Alumno
    {
        public int Ciescolar { get; set; }
        [ForeignKey("Representante")]
        public int Cedularepresentante { get; set; }
        public Representante Representante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Sexo { get; set; }
    }
}