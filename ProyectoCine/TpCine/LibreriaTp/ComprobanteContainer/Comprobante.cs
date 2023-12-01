namespace LibreriaTp
{
    public class Comprobante
    {
        public int Id { get; set; }
        public List<FormaPago> FormaPagos { get; set; }
        public FormaVenta FormaVenta { get; set; }
        public DateTime Fecha { get;set; }
    }
}
