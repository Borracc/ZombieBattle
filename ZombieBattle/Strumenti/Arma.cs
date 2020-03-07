using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class Arma : Strumento
    {

        public int GitMin { get; set; }
        public int GitMax { get; set; }
        public int Dadi { get; set; }
        public int Minimo { get; set; }
        public int Danni { get; set; }
        public bool Rumore { get; set; }
        public bool Porte { get; set; }

        public Arma()
        {
            new Strumento("Arma di Base", "arma di default");
            GitMin = 0;
            GitMax = 3;
            Dadi = 1;
            Minimo = 4;
            Danni = 1;
            Rumore = true;
            Porte = true;
        }//costruttore di default

        public Arma(String sN, String sT, int gMin, int gMax, int dd, int m, int dn, bool r, bool p)
        {
            new Strumento(sN, sT);
            GitMin = gMin;
            GitMax = gMax;
            Dadi = dd;
            Minimo = m;
            Danni = dn;
            Rumore = r;
            Porte = p;
        }//costruttore parametrico

        public Arma(Arma a)
        {
            new Strumento(a.Nome, a.Info);
            GitMin = a.GitMin;
            GitMax = a.GitMax;
            Dadi = a.Dadi;
            Minimo = a.Minimo;
            Danni = a.Danni;
            Rumore = a.Rumore;
            Porte = a.Porte;
        }//costruttore di copia

        public String ToString()
            {
                String s = ((Strumento) this).toString() + " " + GitMin + "-" + GitMax + "/" + Dadi + "/" + Danni + "/";
                if (Rumore)
                {
                    s += "♫/";
                }
                else
                {
                    s += "▬/";
                }//if-eslse
                if (Porte)
                {
                    s += "⌂";
                }
                else
                {
                    s += "▬";
                }//if-eslse
                return s;
            }//toString

    }//Arma
}
