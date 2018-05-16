using System;
using System.Collections.Generic;
using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    [Spieler(
        Volkname = "g37r3k7",
        Vorname = "Adam",
        Nachname = "Konieczny"
    )]
    [Kaste(
            Name = "Default",
            AngriffModifikator = 0,
            EnergieModifikator = 0,
            LastModifikator = 0,
            ReichweiteModifikator = 0,
            DrehgeschwindigkeitModifikator = 0,
            GeschwindigkeitModifikator = 0,
            SichtweiteModifikator = 0
        )
    ]
    public class ToddlersClass : Basisameise
    {
        public override string BestimmeKaste(Dictionary<string, int> anzahl)
        {
            return "Default";
        }

        public override void RiechtFreund(Markierung markierung)
        {
        }

        public override void Sieht(Obst obst)
        {
        }

        public override void Sieht(Zucker zucker)
        {
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


        public override void Wartet()
        {
            GeheGeradeaus();
        }

        public override void WirdAngegriffen(Ameise ameise)
        {
        }

        public override void WirdAngegriffen(Wanze wanze)
        {
        }

        public override void ZielErreicht(Obst obst)
        {
        }

        public override void ZielErreicht(Zucker zucker)
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