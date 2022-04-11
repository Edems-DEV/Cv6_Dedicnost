﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6_Dedicnosz
{
    class Pistole : Zbran
    {
        private int maxPocetNaboju;
        private int pocetNaboju;
        private int dostrel;

        public Pistole(int poskozeni, int odolnost, int maxPocetNaboju, int dostrel) : base(poskozeni, odolnost)
        {
            this.maxPocetNaboju = maxPocetNaboju;
            this.pocetNaboju = maxPocetNaboju;
            this.dostrel = dostrel;
        }

        public void Zautoc(int vzdalenost) //override?
        {
            if (vzdalenost <= this.dostrel && pocetNaboju > 0 && odolnost > 0)
            { 
                Console.WriteLine($"Zaútočili za {poskozeni}");
                pocetNaboju--;
                odolnost--;
            }
            else
            {
                base.Zautoc();
            }
        }
        public void Nabit()
        {
            pocetNaboju = maxPocetNaboju;
            Console.WriteLine($"Zbran byla nabita.");
        }
    }
}
