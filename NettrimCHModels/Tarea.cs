using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Tarea
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Horas { get; set; }
        public bool Finalizada { get; set; }
        public bool Facturable { get; set; }


        public int EmpleadoId { get; set; }
        public int ProyectoId { get; set; }

        public virtual Proyecto Proyecto { get; set; }
        public virtual Empleado Empleado { get; set; }

        //public int Realizacion { get; set; }
        //public string IdDocumento { get; set; }
    }
}
