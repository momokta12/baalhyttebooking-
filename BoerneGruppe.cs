using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baalhyttebooking_
{
    public  class BoerneGruppe
    {
        public string ID { get; set; }
        public string Navn { get; set; }
        public Aldersgruppe Aldersgruppe { get; set; }
        public int AntalDeltagere { get; set;}


        public BoerneGruppe(string iD, string navn, Aldersgruppe aldersgruppe, int antalDeltagere)
        {
            ID = iD;
            Navn = navn;
            Aldersgruppe = aldersgruppe;
            AntalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"ID {ID}\nNavn : {Navn}\nAldersgruppe : {Aldersgruppe}\nAntal Deltagere {AntalDeltagere}";
        }
    }

}
