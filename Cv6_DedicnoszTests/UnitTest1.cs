using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Cv6_Dedicnosz;

namespace Cv6_DedicnoszTests
{
    [TestClass]
    public class UnitTest1
    {

        //Mec mec1 = new Mec(100, 100, true);
        //Console.WriteLine("Mec:");
        //    mec1.Zautoc();

        //    Pistole pistole1 = new Pistole(100, 100, 1, 5);
        //Console.WriteLine("Pistole:");
        //    pistole1.Zautoc(4);
        //    pistole1.Zautoc(4); //vybito
        //    pistole1.Nabit();
        //    pistole1.Zautoc(4);
        //    pistole1.Zautoc(10); //daleko

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void Mec_Zautoc()
        {
            int dmg = 5;
            int dur = 3; //  -3/utok
            Mec mec1 = new Mec(dmg, dur, true);
            int krytDmg = dmg * 2;
            Assert.AreEqual(krytDmg, mec1.Zautoc()); //-3 
            Assert.AreEqual(0, mec1.Zautoc());

            Mec mec2 = new Mec(dmg, dur, false);
            Assert.AreEqual(dmg, mec2.Zautoc()); //-3 
            Assert.AreEqual(0, mec2.Zautoc());
        }


        [TestMethod]
        public void Pistol_Zautoc()
        {
            int dmg = 5;
            int dur = 4;  // -1
            int ammo = 1; // -1
            int dostrel = 5;

            Pistole gun1 = new Pistole(dmg, dur, ammo, dostrel);
            Assert.AreEqual(dmg, gun1.Zautoc(dostrel));
            Assert.AreEqual(0, gun1.Zautoc(dostrel)); // 0 ammo
            gun1.Nabit();
            Assert.AreEqual(dmg, gun1.Zautoc(dostrel)); //reload
            Assert.AreEqual(0, gun1.Zautoc(dostrel + 1)); //příliš daleko
            Assert.AreEqual(0, gun1.Zautoc(dostrel)); // 0 durability
        }

    }
}
