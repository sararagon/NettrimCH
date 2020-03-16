namespace NettrimCHModels.Modelos
{
    public class OperacionTrabajo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Descripcion { get; set; }

        public Cliente Cliente { get; set; }
        public Proyecto Proyecto { get; set; }

        public string JP { get; set; }
        public bool Interna { get; set; }
        public bool Facturable { get; set; }
        public bool Informe { get; set; }
        public string Area { get; set; }
        public string Plataforma { get; set; }
    }
}
