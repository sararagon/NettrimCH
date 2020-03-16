using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Interno { get; set; }
        public bool Facturar { get; set; }
        public string Area { get; set; }
        public string Plataforma { get; set; }
        public bool Cerrado { get; set; }
  
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
        public virtual ICollection<Empleado> Empleados{ get; set; }

    }
}
