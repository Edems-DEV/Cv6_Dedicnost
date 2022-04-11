using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6_Dedicnosz
{
    public class Zbran
    {
        protected int poskozeni; //demage
        protected int odolnost; //durability

        public Zbran(int poskozeni, int odolnost)
        {
            this.poskozeni = poskozeni;
            this.odolnost = odolnost;
        }

        public virtual int Zautoc()
        {
            Console.WriteLine("Zbraň nemůže zaútočit.");
            return 0;
        }
    }
}
