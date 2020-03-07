using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class ArcoCorto : Arma
    {

        public ArcoCorto()
        {
            new Arma("Arco corto", "Arco semplice", 1, 2, 1, 3, 1, false, false);
        }//costruttore di default

    }//ArcoCorto
}
