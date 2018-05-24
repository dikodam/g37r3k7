using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public class StandardVerhalten : Verhalten
    {
        private Poltergeist poltergeist;

        public StandardVerhalten(Poltergeist poltergeist)
        {
            this.poltergeist = poltergeist;
        }

        public override void Tick()
        {
            poltergeist.Denke("OH SHIAT");
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
            poltergeist.GeheGeradeaus();
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