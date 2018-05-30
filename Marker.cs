using System;
using AntMe.Deutsch;

namespace AntMe.Spieler.g37r3k7
{
    public class Marker
    {
        public int RANGE => 1000;

        public int ZUCKER_GESEHEN => 100_000_000;
        public int ZUCKER_LOKALISIERT => 200_000_000;

        public int OBST_GESEHEN => 300_000_000;
        public int OBST_LOKALISIERT => 400_000_000;

        public int FEINDAMEISE_GESEHEN => 500_000_000;
        public int WANZE_GESEHEN => 600_000_000;

        public bool IstZucker(Markierung markierung) =>
            IstZuckerGesehen(markierung) || IstZuckerLokalisiert(markierung);

        public bool IstZuckerGesehen(Markierung markierung)
        {
            var infoCode = markierung.Information;
            return infoCode >= ZUCKER_GESEHEN && infoCode < ZUCKER_LOKALISIERT;
        }

        public bool IstZuckerLokalisiert(Markierung markierung)
        {
            var infoCode = markierung.Information;
            return infoCode >= ZUCKER_LOKALISIERT && infoCode < OBST_GESEHEN;
        }
    }
}