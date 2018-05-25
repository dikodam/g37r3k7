using System;
using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public class SammlerVerhalten : Verhalten
    {
        private Poltergeist poltergeist;
        private Random random;

        public SammlerVerhalten(Poltergeist poltergeist)
        {
            this.poltergeist = poltergeist;
            this.random = new Random();
        }

        public override void Wartet()
        {
        }

        public override void Tick()
        {
            if (poltergeist.Ziel == null)
            {
                var halberMaxWinkel = poltergeist.Drehgeschwindigkeit / 2;
                var randomRichtung = random.Next(-halberMaxWinkel, halberMaxWinkel);
                poltergeist.DreheUmWinkel(randomRichtung);
                poltergeist.GeheGeradeaus();
            }
        }

        public override void Sieht(Zucker zucker)
        {
            poltergeist.GeheZuZiel(zucker);
        }

        public override void ZielErreicht(Zucker zucker)
        {
            poltergeist.Nimm(zucker);
            poltergeist.GeheZuBau();
        }

        public override void Sieht(Obst obst)
        {
        }

        public override void ZielErreicht(Obst obst)
        {
        }

        public override void RiechtFreund(Markierung markierung)
        {
            if (markierung.Information >= (int) Marker.ZUCKER_GESEHEN &&
                markierung.Information < (int) Marker.OBST_GESEHEN) // TODO mach schöner
            {
                poltergeist.GeheZuZiel(markierung);
            }
        }

        public override void SiehtFeind(Ameise ameise)
        {
        }

        public override void SiehtFeind(Wanze wanze)
        {
        }

        public override void SiehtFreund(Ameise ameise)
        {
        }

        public override void SiehtVerbündeten(Ameise ameise)
        {
        }

        public override void WirdAngegriffen(Ameise ameise)
        {
        }

        public override void WirdAngegriffen(Wanze wanze)
        {
        }

        public override void WirdMüde()
        {
        }

        public override void IstGestorben(Todesart todesart)
        {
        }
    }
}