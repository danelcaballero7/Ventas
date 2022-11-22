namespace SistemaVenta.AplicacionWeb.Models.ViewModels
{
    public class VMReporteVenta
    {
        public string? NumeroVenta { get; set; }        
        public string? DocumentoCliente { get; set; }
        public string? NombreCliente { get; set; }
        public decimal? SubTotalVenta { get; set; }
        public decimal? ImpuestoTotalVenta { get; set; }
        public decimal? TotalVenta { get; set; }
        public string? FechaRegistro { get; set; }
        public string? TipoDocumento { get; set; }  
        public string? Producto { get; set; }   
        public int Cantidad { get; set; }   
        public string? Precio { get; set; }
        public string? Total { get; set; }
    }
}
