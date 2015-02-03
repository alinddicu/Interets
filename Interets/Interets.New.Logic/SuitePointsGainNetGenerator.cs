namespace Interets.New.logic
{
    using System.Collections.Generic;

    public class SuitePointsGainNetGenerator
    {
        private readonly FormuleGain _formuleGain;

        public SuitePointsGainNetGenerator(FormuleGain formuleGain)
        {
            _formuleGain = formuleGain;
        }

        public IEnumerable<PointDonnees> Generate(
            double interetsMoyensNetsAnnuels,
            double primeMensuelle,
            double anneesContrat)
        {
            for (var x = 0; x <= anneesContrat; x++)
            {
                var gain = _formuleGain.Calculer(interetsMoyensNetsAnnuels, primeMensuelle, x);
                yield return new PointDonnees(x, gain);
            }
        }
    }
}
