using Baalhyttebooking;

namespace baalhyttebooking_
{
    public enum Aldersgruppe
    {
        Pusling,
        Tumling,
        Pilt,
        Væbner,
        Seniorvæbner
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Opgave 1: Opret Klassen BørneGruppe
            BoerneGruppe G1 = new BoerneGruppe("G1", "Børnegruppe A", Aldersgruppe.Pusling, 15);
            BoerneGruppe G2 = new BoerneGruppe("G2", "Børnegruppe B", Aldersgruppe.Tumling, 7);

            //opg.9 skabe en Exception handling
            ReservationerDictionary reservationsListe = new ReservationerDictionary(2023);

            try
            {
                DateTime tidspunktede = new DateTime(2023, 6, 15, 12, 0, 0);
                Reservation R1 = new Reservation(1, tidspunktede, G1);
                Reservation R2 = new Reservation(2, tidspunktede, G2);

                reservationsListe.RegistrerReservation(R1);
                reservationsListe.RegistrerReservation(R2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl under registrering af reservation: " + ex.Message);
            }

            Console.WriteLine("Boernegrupper:");
            Console.WriteLine(G1.ToString());
            Console.WriteLine(G2.ToString());

            // Opgave 2: Opret Klassen Reservation
            DateTime tidspunkt = new DateTime(2023, 6, 15, 12, 0, 0);
            Reservation reservation1 = new Reservation(1, tidspunkt, G1);
            Reservation reservation2 = new Reservation(2, tidspunkt, G2);

            Console.WriteLine("Reservationer:");
            Console.WriteLine(reservation1.ToString());
            Console.WriteLine(reservation2.ToString());

            // Opgave 3: Opret klassen ReservationerDictionary
            ReservationerDictionary reservationerDictionary = new ReservationerDictionary(2023);
            reservationerDictionary.RegistrerReservation(reservation1);
            reservationerDictionary.RegistrerReservation(reservation2);

            Console.WriteLine("Reservationer efter registrering:");
            reservationerDictionary.PrintReservationer();

            // Opgave 6: Opret CRUD metoder på klassen ReservationManager
            Console.WriteLine("Antal reservationer for børnegruppe G1: " + reservationerDictionary.AntalReservationer(G1));
            Console.WriteLine("Er reservationstidspunktet ledigt? " + reservationerDictionary.ReservationLedig(reservation1));
            Console.WriteLine("Er reservationstidspunktet gyldigt? " + reservationerDictionary.ReservationsTidspunktOK(reservation1));

            reservationerDictionary.FjernReservation(reservation1);

            Console.WriteLine("Reservationer efter fjernelse:");
            reservationerDictionary.PrintReservationer();

            // Opgave 8: Validerings funktioner
            Console.WriteLine("ReservationOK(reservation1): " + reservationerDictionary.ReservationOK(reservation1));
            Console.WriteLine("ReservationOK(reservation2): " + reservationerDictionary.ReservationOK(reservation2));

            Console.ReadLine();
        }
    }

}