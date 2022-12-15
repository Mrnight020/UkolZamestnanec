﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol9Zamestanec
{
    class Zamestnanec
    {
        string jmeno;
        string prijmeni;
        DateTime datumNastupu;
        int odpracovanehodiny = 0;
        int hodinovaMzda;
        public int HodinovaMzda { get => hodinovaMzda; }

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
        }

        public double PocetDni()
        {
            DateTime dnes = DateTime.Now;
            TimeSpan dny = dnes - datumNastupu;
            return dny.TotalDays;
        }

        public void OdpracujHodiny(int hodiny)
        {
            odpracovanehodiny += hodiny;
        }

        public int VypoctiMzdu()
        {
            return odpracovanehodiny * HodinovaMzda;
        }

        public string Vypis()
        {
            return String.Format("Jmeno: {0} \n " +
                                 "Prijmeni: {1} \n " +
                                 "Datum Nastupu :{2} \n " +
                                 "Odpracovane Hodiny :{3} \n"  +
                                 "hodinova mzda: {4} \n" +
                                 "Vypoctena Mzda : {5}\n" +
                                 "",jmeno,prijmeni,datumNastupu,odpracovanehodiny,HodinovaMzda,VypoctiMzdu());
        }

    }
}
