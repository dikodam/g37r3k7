using System.Collections.Generic;

namespace AntMe.Player.toddlers
{
    public class CasteBalancer
    {
        private readonly Dictionary<string, int> _typeCount;
        private int overallAnts = 0;

        private readonly List<KeyValuePair<string, double>> _targetRatios =
            new List<KeyValuePair<string, double>>
            {
                new KeyValuePair<string, double>("Scout", 0.05),
                new KeyValuePair<string, double>("SugarCollector", 0.75),
                new KeyValuePair<string, double>("Warrior", 0.2)
            };

        public CasteBalancer(Dictionary<string, int> typeCount)
        {
            _typeCount = typeCount;
            foreach(var numberInCaste in typeCount)
            {
                overallAnts += numberInCaste.Value;
            }
        }

        public string DecideOnCaste()
        {
            foreach (var casteRatio in _targetRatios)
            {
                if (PercentageUnder(casteRatio.Key, casteRatio.Value))
                {
                    return casteRatio.Key;
                }
            }
            return "SugarCollector";
        }

        public bool PercentageUnder(string caste, double boundary)
            => (double)_typeCount[caste] / overallAnts < boundary;
    }
}