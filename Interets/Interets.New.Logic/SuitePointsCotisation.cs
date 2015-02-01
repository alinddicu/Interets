namespace Interets.New.logic
{
    using System.Collections.Generic;

    public class SuitePointsCotisation
    {
        public IEnumerable<PointDonnees> Generate(double primeMensuelle, double anneesContrat)
        {
            for (var i = 0; i <= anneesContrat; i++)
            {
                yield return new PointDonnees(i, i * 12 * primeMensuelle);
            }
        }
    }
}
