﻿using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public class ScoutVerhalten : Verhalten
    {
        private Poltergeist poltergeist;

        public ScoutVerhalten(Poltergeist poltergeist)
        {
            this.poltergeist = poltergeist;
        }

        #region basics

        public override void Tick()
        {
        }

        public override void Wartet()
        {
        }

        #endregion

        #region scouting

        public override void Sieht(Zucker zucker)
        {
        }

        public override void Sieht(Obst obst)
        {
        }

        public override void SiehtFeind(Ameise ameise)
        {
        }

        public override void SiehtFeind(Wanze wanze)
        {
        }

        public override void RiechtFreund(Markierung markierung)
        {
        }

        public override void SiehtFreund(Ameise ameise)
        {
        }

        public override void SiehtVerbündeten(Ameise ameise)
        {
        }

        #endregion

        #region BLA

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

        #endregion
    }
}