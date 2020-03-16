using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Tarea
    {
        public int IdIndice { get; set; }
        public int IdRecurso { get; set; }
        public DateTime Fecha { get; set; }
        public string OT { get; set; }

        //Lo he puesto string porque llevan guión, -> comprobar que es así
        public string IdDocumento { get; set; }

        public string DescTarea { get; set; }
        public string Descripcion { get; set; }
        public int Horas { get; set; }
        public bool Bloqueo { get; set; }
        public string Alias { get; set; }

        //string porque no varía
        public string Cidentif { get; set; }
        public bool Finalizada { get; set; }
        public int Realizacion { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Facturable { get; set; }

        public virtual Recurso recurso { get; set; }

    }
}
