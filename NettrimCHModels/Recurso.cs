using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NettrimCHModels.Recursos
{
    public class Recurso
    {
        public int IdRecurso { get; set; }
        public string Nombre { get; set; }
        public int Clave { get; set; }
        public string Email { get; set; }  
        public bool Baja { get; set; }       
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string DNI { get; set; }
    }
}
