using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public abstract class Verhalten
    {
        public abstract string Name();
        public abstract void Tick();
        public abstract void RiechtFreund(Markierung markierung);
        public abstract void Sieht(Obst obst);
        public abstract void Sieht(Zucker zucker);
        public abstract void SiehtFeind(Ameise ameise);
        public abstract void SiehtFeind(Wanze wanze);
        public abstract void SiehtFreund(Ameise ameise);
        public abstract void SiehtVerbündeten(Ameise ameise);
        public abstract void Wartet();
        public abstract void WirdAngegriffen(Ameise ameise);
        public abstract void WirdAngegriffen(Wanze wanze);
        public abstract void ZielErreicht(Obst obst);
        public abstract void ZielErreicht(Zucker zucker);
        public abstract void WirdMüde();
        public abstract void IstGestorben(Todesart todesart);
    }
}