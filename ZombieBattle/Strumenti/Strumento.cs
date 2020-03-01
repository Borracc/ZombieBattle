using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class Strumento
    {
        public String Nome { get; set; }
        public String Info { get; set; }

        public Strumento()
        {
            Nome = "Strumento Base";
            Info = "Non fa nulla di particolare";
        }//costruttore di default

        public Strumento(String n, String i)
        {
            Nome = n;
            Info = i;
        }//costruttore parametrico

        public Strumento(Strumento s)
        {
            Nome = s.Nome;
            Info = s.Info;
        }//costruttore di copia
            
        //public static Strumento[] giveZainoVuoto()
        //{
        //    Strumento[] zaino = new Strumento[6];
        //    for (int i = 0; i < 6; i++)
        //    {
        //        zaino[i] = new Nulla();
        //    }//for
        //    return zaino;
        //}//giveZainoVuoto

        public String toString()
        {
            return Nome + ": " + Info + " ";
        }//toString

    }//Strumento

}
