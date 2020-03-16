using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    public class Proyecto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Cerrado { get; set; }
        public int Tipo { get; set; }
    }
}
