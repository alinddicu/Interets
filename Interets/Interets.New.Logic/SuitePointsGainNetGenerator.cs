namespace Interets.New.logic
{
    using System.Collections.Generic;

    public class SuitePointsGainNetGenerator
    {
        public IEnumerable<PointDonnees> Generate(
            double interetsMoyensNetsAnnuels,
            double primeMensuelle,
            double anneesContrat)
        {
            for (var x = 0; x <= anneesContrat; x++)
            {
                var gain = FormuleGain.Calculer(interetsMoyensNetsAnnuels, primeMensuelle, x);
                yield return new PointDonnees(x, gain);
            }
        }
    }
}
