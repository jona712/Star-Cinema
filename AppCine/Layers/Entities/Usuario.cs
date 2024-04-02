using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public string Contrasena { get; set; }

        public int Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Tipo { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public byte[] Imagen { get; set; }

        public int NumeroMembresia { get; set; }

    }
}
