namespace LibreriaTp
{
    public class Ticket
    {
        public int NroTicket { get; set; }
        public Funcion Funcion { get; set; }
        public Butaca Butaca { get; set; }
        public Promo Promo { get; set; }

        public Ticket()
        {
            NroTicket = 0;
            Funcion = new Funcion();
            Butaca = new Butaca();
            Promo = new Promo();
        }


    }
}
