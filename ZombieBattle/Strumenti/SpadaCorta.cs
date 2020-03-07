using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class SpadaCorta : Arma
    {

        public SpadaCorta()
        {
            new Arma("Spada corta", "Spada semplice", 0, 0, 1, 4, 1, true, true);
        }//costruttore di default

    }//SpadaCorta
}
