using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6_Dedicnosz
{
    public class Program
    {
        static void Main(string[] args)
        {
            //11.4.2022 - 11:25 DONE

            Mec mec1 = new Mec(100, 100, true);
            Console.WriteLine("Mec:");
            mec1.Zautoc();

            Pistole pistole1 = new Pistole(100, 100, 1, 5);
            Console.WriteLine("Pistole:");
            pistole1.Zautoc(4);
            pistole1.Zautoc(4); //vybito
            pistole1.Nabit();
            pistole1.Zautoc(4);
            pistole1.Zautoc(10); //daleko

            Console.ReadKey();
        }
    }
}
