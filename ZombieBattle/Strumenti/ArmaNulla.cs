using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieBattle.Strumenti
{
    public class ArmaNulla : Arma
    {

        public ArmaNulla()
        {
            new Arma("ArmaNulla", "Spazio Arma libero", 0, 0, 0, 0, 0, false, false);
        }//costruttore di default

    }//ArmaNulla
}
