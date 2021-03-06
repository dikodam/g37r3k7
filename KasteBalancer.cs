﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AntMe.Spieler.g37r3k7
{
    public class KasteBalancer
    {
        private readonly Dictionary<string, int> anzahl;

        public KasteBalancer(Dictionary<string, int> anzahl)
        {
            this.anzahl = anzahl;
        }

        public Verhalten BestimmeKaste(Poltergeist poltergeist)
        {
            var gesamt =
                (from kvPair in anzahl
                    select kvPair.Value)
                .Aggregate((x, y) => x + y);

            var scoutAnteil = (anzahl["Scout"] * 1.0) / gesamt;

            if (anzahl["Scout"] < 5 || scoutAnteil < 0.2)
            {
                return new ScoutVerhalten(poltergeist);
            }

            return new SammlerVerhalten(poltergeist);
        }
    }
}