using System;
using System.Collections.Generic;
using System.Text;

namespace IlletekKalkulator
{
    internal class Szoba
    {
        //belso tarolok
        private int ejszakaiAr;
        private int ferohely;
        private static int osszesRegisztraltSzoba = 0;
        //tulajdonsag
        public string Szobaszam { get; set; }
        public int Emelet { get; set; }
        public int EjszakaiAr 
        {
            get => ejszakaiAr;
            set => ejszakaiAr = value < 0 ? 0 : value;
        }
        public int Ferohely
        {
            // nyilas fuggvenyek => feltetel ? igaz : hamis
            get => ferohely;
            set => ferohely = value < 1 ? 1 : value;
        }
        public static int OsszesRegisztraltSzoba
        {
            get => osszesRegisztraltSzoba;
        }
        public Szoba(string szobaszam, int emelet, int ejszakaiAr) : this(szobaszam, emelet, ejszakaiAr, 2)
        {
        }
        public Szoba(string szobaszam, int emelet, int ejszakaiAr, int ferohely)
        {
            //elobb property, aztan belso tarolo!
            Szobaszam = szobaszam;
            Emelet = emelet;
            EjszakaiAr = ejszakaiAr;
            Ferohely = ferohely;
            osszesRegisztraltSzoba++;
        }
        public override string ToString()
        {
            return $"{Szobaszam} Emelet: {Emelet}. | Férőhely: {Ferohely} | Ár: {EjszakaiAr} Ft/éj";
        }
        public int FoglalasErtek(int ejszakakSzama)
        {
            return ejszakakSzama * EjszakaiAr;
        }
    }
}
