namespace EmpresaAlkemyServicios.model
{
    public class TrabajosModels
    {
        public int CodTrabajo { get; set; }
        public DateTime Fecha { get; set; }
        public int CodProyecto { get; set; }
        //public virtual ProyectosModel ProyectosModel { get; set; }
        public int CodServicio { get; set; }

        //public virtual ServiciosModel ServiciosModel { get; set; }
        public int CantHoras { get; set; }
        public float ValorHora { get; set; }
        public float Costo { get; set; }
    }
}
