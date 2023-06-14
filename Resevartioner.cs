using baalhyttebooking_;
using System.Text;

namespace Baalhyttebooking
{
    public class ReservationerDictionary
    {
        private Dictionary<int, Reservation> Reservationer { get; set; }
        private int Aar { get; set; }

        public ReservationerDictionary(int aar)
        {
            Reservationer = new Dictionary<int, Reservation>();
            Aar = aar;
        }

        //Opg.6
        public void RegistrerReservation(Reservation reservation)
        {
            Reservationer.Add(reservation.ID, reservation);
        }

        public void PrintReservationer()
        {
            foreach (var reservation in Reservationer.Values)
            {
                Console.WriteLine(reservation.ToString());
            }
        }

        public void FjernReservation(Reservation reservation)
        {
            Reservationer.Remove(reservation.ID);
        }

        //Opga. 7
        public int AntalReservationer(BoerneGruppe bGruppe)
        {
            return Reservationer.Values.Count(r => r.BoerneGruppe == bGruppe);
        }

        public bool ReservationLedig(Reservation reservation)
        {
            return Reservationer.Values.All(r => r.Tidspunkt != reservation.Tidspunkt);
        }

        public bool ReservationsTidspunktOK(Reservation reservation)
        {
            return reservation.Tidspunkt.Year == Aar && reservation.Tidspunkt >= DateTime.Now;
        }

        //Opg.8
        public bool ReservationOK(Reservation reservation)
        {
            bool isValid = true;

            if (reservation.BoerneGruppe == null)
            {
                Console.WriteLine("Reservationer skal have en reference til et Boernegruppe object");
                isValid = false;
            }

            if (AntalReservationer(reservation.BoerneGruppe) >= 2)
            {
                Console.WriteLine("Antal reservationer for børnegruppen er allerede højere end 2");
                isValid = false;
            }

            if (!ReservationLedig(reservation))
            {
                Console.WriteLine("Tidspunktet for reservationen er allerede optaget");
                isValid = false;
            }

            if (!ReservationsTidspunktOK(reservation))
            {
                Console.WriteLine("Tidspunktet for reservationen er ikke gyldigt");
                isValid = false;
            }

            return isValid;
        }
    }
}