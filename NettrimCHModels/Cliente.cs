using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Cliente
    {
        
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Responsable { get; set; }

        public string Telefono { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
