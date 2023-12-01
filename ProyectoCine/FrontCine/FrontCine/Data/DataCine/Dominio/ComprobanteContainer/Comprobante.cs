namespace LibreriaTp
{
    public class Comprobante
    {
        public int Id { get; set; }
        public List<Pagos> ListaPagos { get; set; }
        public FormaVenta FormaVenta { get; set; }
        public DateTime Fecha { get;set; }
        public List<Ticket> ltickets { get; set; }

        public Comprobante()
        {
            ltickets = new List<Ticket>();
            ListaPagos = new List<Pagos>();
            Fecha = DateTime.Now;
        }

        public void AgregarTicket (Ticket t)
        {
            ltickets.Add (t);
        }

        public void RemoverTicker (int pos)
        {
            ltickets.RemoveAt(pos);
        }
        public void AgregarPago(Pagos pago)
        {
            ListaPagos.Add(pago);
        }
    }
}
