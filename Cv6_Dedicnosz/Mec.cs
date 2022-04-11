using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6_Dedicnosz
{
    public class Mec : Zbran
    {
        private bool kritickyZasah;

        public Mec(int poskozeni, int odolnost, bool kritickyZasah) : base(poskozeni, odolnost)
        {
            this.kritickyZasah = kritickyZasah;
        }

        public override int Zautoc()
        {
            if (odolnost > 0)
            {
                if (kritickyZasah == true)
                {
                    poskozeni = poskozeni * 2;
                }

                Console.WriteLine($"Zautočil za {poskozeni}.");
                odolnost = odolnost-3;
            }
            else
            {
                base.Zautoc();
                return 0; //proc nefunguje -> base. je uz return ?
            }
            return poskozeni;
        }
    }
}
