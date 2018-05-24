using System;
using System.Collections.Generic;
using AntMe.Deutsch;
using AntMe.English;
using AntMe.Simulation;

namespace AntMe.Spieler.g37r3k7
{
    [Spieler(
        Volkname = "g37r3k7",
        Vorname = "Adam",
        Nachname = "Konieczny"
    )]
    [Kaste(
            Name = "Standard",
            AngriffModifikator = 0,
            EnergieModifikator = 0,
            LastModifikator = 0,
            ReichweiteModifikator = 0,
            DrehgeschwindigkeitModifikator = 0,
            GeschwindigkeitModifikator = 0,
            SichtweiteModifikator = 0
        )
    ]
    public class PoltergeistAmeise : Basisameise
    {
        private Spielobjekt bau;
        private Spielobjekt reiseziel;
        private Verhalten verhalten;

        public override string BestimmeKaste(Dictionary<string, int> anzahl)
        {
            verhalten = new StandardVerhalten(this);
            return verhalten.Name();
        }

        public override void RiechtFreund(Markierung markierung)
        {
            verhalten.RiechtFreund(markierung);
        }

        public override void Sieht(Obst obst)
        {
            verhalten.Sieht(obst);
        }

        public override void Sieht(Zucker zucker)
        {
            verhalten.Sieht(zucker);
        }

        public override void SiehtFeind(Ameise ameise)
        {
            verhalten.SiehtFeind(ameise);
        }

        public override void SiehtFeind(Wanze wanze)
        {
            verhalten.SiehtFeind(wanze);
        }

        public override void SiehtFreund(Ameise ameise)
        {
            verhalten.SiehtFreund(ameise);
        }

        public override void SiehtVerbündeten(Ameise ameise)
        {
            verhalten.SiehtVerbündeten(ameise);
        }

        public override void Tick()
        {
            verhalten.Tick();
        }

        public override void Wartet()
        {
            initBau();
            verhalten.Wartet();
        }

        private void initBau()
        {
            if (bau == null)
            {
                (this as Basisameise).GeheZuBau();
                bau = Ziel;
                BleibStehen();
            }
        }

        public override void WirdAngegriffen(Ameise ameise)
        {
            verhalten.WirdAngegriffen(ameise);
        }

        public override void WirdAngegriffen(Wanze wanze)
        {
            verhalten.WirdAngegriffen(wanze);
        }

        public override void ZielErreicht(Obst obst)
        {
            verhalten.ZielErreicht(obst);
        }

        public override void ZielErreicht(Zucker zucker)
        {
            verhalten.ZielErreicht(zucker);
        }

        public override void WirdMüde()
        {
            BleibStehen();
            Denke("MÜDE");
            GeheZuBau();
        }

        public override void IstGestorben(Todesart todesart)
        {
            verhalten.IstGestorben(todesart);
        }

        public new void GeheZuZiel(Spielobjekt ziel)
        {
            var richtung = Koordinate.BestimmeRichtung(this, ziel);
            DreheInRichtung(richtung);
            GeheGeradeaus();
        }

        public new void GeheZuBau()
        {
            GeheZuZiel(bau);
        }
    }
}