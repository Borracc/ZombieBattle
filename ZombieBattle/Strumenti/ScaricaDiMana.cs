using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class ScaricaMana : Arma
    {

        public ScaricaMana()
        {
            new Arma("Scarica di mana", "Magia semplice", 0, 1, 1, 4, 1, false, false);
        }//costruttore di default

    }//ScaricaMana

}
