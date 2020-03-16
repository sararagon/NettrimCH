using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Clave { get; set; }
        public string Email { get; set; }
        public bool Baja { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Dni { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
