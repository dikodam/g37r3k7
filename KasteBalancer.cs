using System;
using System.Collections.Generic;
using System.Linq;

namespace AntMe.Spieler.g37r3k7
{
    public class KasteBalancer
    {
        private readonly Dictionary<string, int> kasten;

        public KasteBalancer(Dictionary<string, int> kasten)
        {
            this.kasten = kasten;
        }

        public string BestimmeKaste()
        {
            var gesamt =
                (from kvPair in kasten
                    select kvPair.Value)
                .Aggregate((x, y) => x + y);

            var scoutAnteil = (kasten["Scout"] * 1.0) / gesamt;

            return scoutAnteil < 0.2 ? "Scout" : "Sammler";
        }
    }
}