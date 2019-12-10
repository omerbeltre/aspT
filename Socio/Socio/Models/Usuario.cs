using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Socio.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public int Cedula { get; set; }

        public String Direccion { get; set; }

        public int Telefono { get; set; }

        public String Sexo { get; set; }

        public int Edad { get; set; }

        public String FechaNacimiento { get; set; }

        public String Afiliados { get; set; }

        public String DatoMembresia { get; set; }

        public String LugarTrabajo { get; set; }

        public String DireccionOficina { get; set; }

        public int TelefonoOficina { get; set; }

        public String EstadoMembresia { get; set; }

        public String FechaIngreso { get; set; }

        public String FechaSalida { get; set; }
    }
}