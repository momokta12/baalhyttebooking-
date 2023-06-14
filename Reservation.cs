using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baalhyttebooking_
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime Tidspunkt { get; set; } 
        public BoerneGruppe BoerneGruppe { get; set; }


        public Reservation(int id, DateTime tidspunkt, BoerneGruppe boerneGruppe)
        {
            ID = id;
            Tidspunkt = tidspunkt;
            BoerneGruppe = boerneGruppe;
        }

        public override string ToString()
        {
             return $"ID: {ID}\nTidspunkt: {Tidspunkt}\nBoernegruppe:\n{BoerneGruppe}";
        }
    }
}
