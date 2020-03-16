namespace NettrimCHModels.Modelos
{
    public class CodigosOT
    {
        public int CodigoID { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Descripcion { get; set; }

        public int CodigoCliente { get; set; }
        public string JP { get; set; }
        public bool Interna { get; set; }
        public string Cliente { get; set; }
        public string Proyecto { get; set; }
        public bool Facturable { get; set; }
        public bool Informe { get; set; }
        public string Area { get; set; }
        public string Plataforma { get; set; }
        public bool ProyectoCerrado { get; set; }
        public int TipoProyecto { get; set; }
    }
}
