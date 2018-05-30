using System;
using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public class SammlerVerhalten : Verhalten
    {
        private Poltergeist poltergeist;
        private Random random;
        private Marker marker;

        public SammlerVerhalten(Poltergeist poltergeist)
        {
            this.poltergeist = poltergeist;
            this.random = new Random();
            this.marker = new Marker();
        }

        public override string Name() => "Sammler";

        public override void Wartet()
        {
            // TODO 
            // kein ziel => random lauf
            // ziel vorhanden => ists noch wert? evtl ziel löschen oder random laufen
            // ziel erschöpft => ziel löschen
            /*
            var halberMaxWinkel = poltergeist.Drehgeschwindigkeit / 2;
            var randomRichtung = random.Next(-halberMaxWinkel, halberMaxWinkel);
            poltergeist.DreheUmWinkel(randomRichtung);
            poltergeist.GeheGeradeaus();
             */
        }

        public override void Tick()
        {
            if (poltergeist.MussSchlafen)
            {
                poltergeist.GeheZuBau();
            }
        }

        public override void Sieht(Zucker zucker)
        {
            if (poltergeist.MussSchlafen)
            {
                return;
            }

            poltergeist.SprüheMarkierung(marker.ZUCKER_GESEHEN + zucker.Menge, marker.RANGE);
            if (poltergeist.IstNichtVollBeladen && poltergeist.Ziel != zucker)
            {
                (poltergeist as Basisameise).GeheZuZiel(zucker);
            }
        }

        public override void ZielErreicht(Zucker zucker)
        {
            poltergeist.Nimm(zucker);
            poltergeist.SprüheMarkierung(marker.ZUCKER_LOKALISIERT + zucker.Menge, marker.RANGE);
            poltergeist.GeheZuBau();
            // poltergeist.Ziel = zucker;
        }

        public override void Sieht(Obst obst)
        {
        }

        public override void ZielErreicht(Obst obst)
        {
        }

        public override void RiechtFreund(Markierung markierung)
        {
            if (poltergeist.IstVollBeladen || poltergeist.MussSchlafen)
            {
                return;
            }

            if (poltergeist.Ziel == null && marker.IstZucker(markierung))
            {
                poltergeist.GeheZuZiel(markierung);
            }
            else
                //  ziel != null
            if (poltergeist.Ziel is Zucker)
            {
                // erstmal nix tun, geht ja schon zu zucker
                // TODO prioritätsabschätzung
                // prioabwägung: abstand, menge
            }
            // b) ziel != zucker &&  marker = zuckerLokalisiert => ziel ändern
            else if (!(poltergeist.Ziel is Zucker) && marker.IstZuckerLokalisiert(markierung))
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