using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol9Zamestanec
{
    class Vedouci : Zamestnanec
    {
        int priplatekZaVedeni;
        string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda,int priplatek, string titul) : base(jmeno,prijmeni,datumNastupu,hodinovaMzda)
        {
            priplatekZaVedeni = priplatek;
            this.titul= titul;
            base.hodinovaMzda += priplatekZaVedeni;
        }

        public override int VypoctiMzdu()
        {
            // return (base.VypoctiMzdu() + priplatekZaVedeni);
            return odpracovanehodiny * HodinovaMzda;
        }

        public override string Vypis()
        {
            return "Vedouci :"+ titul + base.Vypis();
        }
    }
}
